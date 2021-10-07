using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaService
{
    public partial class CreatePlaylistForm : Form
    {
        public int userId;

        public CreatePlaylistForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            playlistCoverImg.ImageLocation = @"C:\Users\User\source\repos\MediaService\src\defaultImg.png";
        }

        private void addPlaylistCoverBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png and jpg files (*.png, *.jpg)|*.png;*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    playlistCover.Text = openFileDialog.FileName;
                    playlistCoverImg.ImageLocation = playlistCover.Text;
                }
            }
        }

        private void crtPlstBtn_Click(object sender, EventArgs e)
        {
            string plstName = playlistName.Text.Trim();

            if (plstName.Length == 0)
            {
                string strMsg = string.Format("Введите название плейлиста!");
                MessageBox.Show(strMsg);
                return;
            }

            DB dB = new DB();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Playlists WHERE UserId = @uId AND PlaylistName = @plstNm", dB.getConnection());

            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;
            sqlCommand.Parameters.Add("@plstNm", SqlDbType.VarChar).Value = plstName;

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                string msge = string.Format("У вас уже есть плейлист с таким названием!");
                MessageBox.Show(msge);
                return;
            }

            sqlCommand = new SqlCommand("INSERT INTO Playlists VALUES (@plstNm, @plstCover, @uId)", dB.getConnection());

            byte[] bytes = System.IO.File.ReadAllBytes(playlistCoverImg.ImageLocation);

            sqlCommand.Parameters.Add("@plstNm", SqlDbType.VarChar).Value = plstName;
            sqlCommand.Parameters.Add("@plstCover", SqlDbType.VarBinary).Value = bytes;
            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            dB.openConnetion();

            if (sqlCommand.ExecuteNonQuery() == 0)
                MessageBox.Show("Произошла ошибка, попробуйте позже.");

            dB.closeConnetion();

            playlistName.Text = string.Empty;
            playlistCoverImg.ImageLocation = @"C:\Users\User\source\repos\MediaService\src\defaultImg.png";
            playlistCover.Text = string.Empty;

            MessageBox.Show("Плейлист создан!");
        }

        Point lastPoint;

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.Size = new Size(minimizeBtn.Width + 2, minimizeBtn.Height + 2);
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.Size = new Size(minimizeBtn.Width - 2, minimizeBtn.Height - 2);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(closeBtn.Width + 2, closeBtn.Height + 2);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(closeBtn.Width - 2, closeBtn.Height - 2);
        }
    }
}
