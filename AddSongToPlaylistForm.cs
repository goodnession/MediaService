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
    public partial class AddSongToPlaylistForm : Form
    {
        public int userId;
        public int songId;
        public bool flag = false;
        
        public AddSongToPlaylistForm(int userId, int songId)
        {
            InitializeComponent();

            this.userId = userId;
            this.songId = songId;

            DB dB = new DB();

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand sqlCommand = new SqlCommand("SELECT PlaylistId, PlaylistName FROM Playlists WHERE UserId = @uId", dB.getConnection());

            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            DataRow dataRow;

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    playlists.Items.Add(dataRow["PlaylistId"].ToString() + " - " + dataRow["PlaylistName"].ToString());
                }
            }
            else
            {
                string msg = string.Format("Сначала создайте плейлист!");
                MessageBox.Show(msg);
                flag = true;
            }
        }

        private void addSongBtn_Click(object sender, EventArgs e)
        {
            if (playlists.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите плейлист!");
                return;
            }
            
            DB dB = new DB();

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Playlist_Song WHERE PlaylistId = @pId AND SongId = @sId", dB.getConnection());

            string[] plstId = playlists.SelectedItem.ToString().Split(' ');
            
            sqlCommand.Parameters.Add("@sId", SqlDbType.Int).Value = this.songId;
            sqlCommand.Parameters.Add("@pId", SqlDbType.Int).Value = int.Parse(plstId[0]);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            DataRow dataRow;

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("В этом плейлисте уже есть этот трек!");
                return;
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO Playlist_Song VALUES (@pId, @sId)", dB.getConnection());
                command.Parameters.Add("@sId", SqlDbType.Int).Value = this.songId;
                command.Parameters.Add("@pId", SqlDbType.Int).Value = int.Parse(plstId[0]);

                dB.openConnetion();

                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Трек добавлен в плейлист!");
                else
                    MessageBox.Show("Произошла ошибка, попробуйте позже.");

                dB.closeConnetion();

                playlists.SelectedIndex = -1;
            }
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
