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
    public partial class AddTrackForm : Form
    {
        public int userId;
        public bool flag = false;

        public AddTrackForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            DB dB = new DB();

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand sqlCommand = new SqlCommand("SELECT a.AlbumId, a.AlbumName FROM Albums a INNER JOIN Album_User au ON a.AlbumId = au.AlbumId INNER JOIN Users u ON au.UserId = u.UserId WHERE DATEDIFF(HH, GETDATE(), a.UploadDate) < 24 AND au.UserId  = @uId", dB.getConnection());

            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;
            
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            DataRow dataRow;

            if (dataTable.Rows.Count > 0)
            {
                for (int i=0; i<dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    albums.Items.Add(dataRow["AlbumId"].ToString() + " - " + dataRow["AlbumName"].ToString());
                }
            }
            else
            {
                string msg = string.Format("Сначала создайте альбом!");
                MessageBox.Show(msg);
                flag = true;
            }

            dataTable.Reset();

            sqlCommand = new SqlCommand("SELECT * FROM Genres", dB.getConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            for (int i=0; i<dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                genres.Items.Add(dataRow["GenreId"].ToString() + " - " + dataRow["GenreName"].ToString());
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

        private void chooseSongBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    song.Text = openFileDialog.FileName;
                }
            }
        }

        private void addSongBtn_Click(object sender, EventArgs e)
        {
            string songNm = songName.Text;
            string songPath = song.Text;
            string arts = artists.Text.Trim().Replace(" ", "");
            string[] artArr;

            if (songNm.Length == 0)
            {
                string msg = string.Format("Введите название трека!");
                MessageBox.Show(msg);
                return;
            }

            if (songPath.Length == 0)
            {
                string msg = string.Format("Выберите трек!");
                MessageBox.Show(msg);
                return;
            }

            if (albums.SelectedIndex == -1)
            {
                string msg = string.Format("Выберите альбом!");
                MessageBox.Show(msg);
                return;
            }

            if (genres.SelectedIndex == -1)
            {
                string msg = string.Format("Выберите жанр!");
                MessageBox.Show(msg);
                return;
            }

            string[] albId = albums.SelectedItem.ToString().Split(' ');
            string[] genreId = genres.SelectedItem.ToString().Split(' ');

            if (arts.Length > 0)
            {
                string loginChars = "qwertyuiopasdfghjklzxcvbnm1234567890,";

                for (int i = 0; i < arts.Length; i++)
                {
                    if (!loginChars.Contains(arts[i]))
                    {
                        MessageBox.Show("Логин может состоять только из символов латинского алфавита и цифр. Введите логины через запятую!");
                        return;
                    }
                }

                artArr = arts.Split(',');

                DB db = new DB();

                SqlCommand command = new SqlCommand("SELECT * FROM Users u WHERE u.UserLogin = @uL AND u.UserRole > 0", db.getConnection());

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();

                for (int i = 0; i < artArr.Length; i++)
                {
                    if (artArr[i] != "")
                    {
                        command.Parameters.Add("@uL", SqlDbType.VarChar).Value = artArr[i];
                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            string strMsg = string.Format("Артиста с логином {0} не существует", artArr[i]);
                            MessageBox.Show(strMsg);
                            return;
                        }

                        command.Parameters.RemoveAt("@uL");
                        table.Reset();
                    }
                }
            }

            DB dB = new DB();

            SqlCommand sqlCommand = new SqlCommand("SELECT s.SongName FROM Songs s INNER JOIN Album_Song aas ON s.SongId = aas.SongId INNER JOIN Albums a ON aas.AlbumId = a.AlbumId INNER JOIN Album_User au ON a.AlbumId = au.AlbumId INNER JOIN Users u ON au.UserId = u.UserId WHERE s.SongName = @sNm AND au.UserId = @uId AND aas.AlbumId = @albId", dB.getConnection());

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlCommand.Parameters.Add("@sNm", SqlDbType.VarChar).Value = songNm;
            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;
            sqlCommand.Parameters.Add("@albId", SqlDbType.Int).Value = albId[0];

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                string msge = string.Format("В этом альбоме уже есть трек с таким названием!");
                MessageBox.Show(msge);
                return;
            }

            dataTable.Reset();
            sqlCommand.Parameters.RemoveAt("@sNm");
            sqlCommand.Parameters.RemoveAt("@uId");
            sqlCommand.Parameters.RemoveAt("@albId");

            sqlCommand = new SqlCommand("DECLARE @songId INT EXEC dbo.addSongMain @genId, @song, @songName, @usrId, @albId, @songId OUTPUT SELECT @songId AS SongId", dB.getConnection());

            byte[] bytes = System.IO.File.ReadAllBytes(songPath);
            int songId = -1;

            sqlCommand.Parameters.Add("@genId", SqlDbType.Int).Value = genreId[0];
            sqlCommand.Parameters.Add("@song", SqlDbType.VarBinary).Value = bytes;
            sqlCommand.Parameters.Add("@songName", SqlDbType.VarChar).Value = songNm;
            sqlCommand.Parameters.Add("@usrID", SqlDbType.Int).Value = this.userId;
            sqlCommand.Parameters.Add("@albId", SqlDbType.Int).Value = albId[0];

            dB.openConnetion();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                string msge = string.Format("Произошла ошибка, попробуйте позже.");
                MessageBox.Show(msge);
                return;
            }

            DataRow row;
            row = dataTable.Rows[0];

            songId = int.Parse(row["SongId"].ToString());

            dB.closeConnetion();

            if (arts.Length > 0)
            {
                artArr = arts.Split(',');

                for (int i = 0; i < artArr.Length; i++)
                {
                    if (artArr[i] != "")
                    {
                        AddRelationSongUser(songId, artArr[i]);
                    }
                }
            }

            string strMsge = string.Format("Ваш трек успешно добавлен!");
            MessageBox.Show(strMsge);

            albums.SelectedIndex = -1;
            songName.Text = string.Empty;
            song.Text = string.Empty;
            genres.SelectedIndex = -1;
            artists.Text = string.Empty;
        }

        private void AddRelationSongUser(int songId, string usrLgn)
        {
            DB db = new DB();

            SqlCommand com = new SqlCommand("EXEC dbo.addSongAdditional @usrLgn, @songId, @curUsrId", db.getConnection());

            com.Parameters.Add("@usrLgn", SqlDbType.VarChar).Value = usrLgn;
            com.Parameters.Add("@songId", SqlDbType.Int).Value = songId;
            com.Parameters.Add("@curUsrId", SqlDbType.Int).Value = this.userId;

            db.openConnetion();

            com.ExecuteNonQuery();

            db.closeConnetion();
        }
    }
}