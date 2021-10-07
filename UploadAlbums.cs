using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MediaService
{
    public partial class UploadAlbums : Form
    {
        public int userId;

        public UploadAlbums(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users u WHERE u.UserId = @uID", db.getConnection());
            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row;
            row = table.Rows[0];

            if (int.Parse(row["UserRole"].ToString()) > 0)
                uploadBtn.Visible = true;

            albumCoverImg.ImageLocation = @"C:\Users\User\source\repos\MediaService\src\defaultImg.png";
        }

        private void addAlbumBtn_Click(object sender, EventArgs e)
        {
            string albumNm = albumName.Text.Trim();
            string arts = artists.Text.Trim().Replace(" ", "");
            string[] artArr;

            if (albumNm.Length == 0)
            {
                string strMsg = string.Format("Введите название альбома");
                MessageBox.Show(strMsg);
                return;
            }

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

                command = new SqlCommand("SELECT * FROM Albums a INNER JOIN Album_User au ON a.AlbumId = au.AlbumId INNER JOIN Users u ON au.UserId = u.userId WHERE u.UserLogin = @uL AND a.AlbumName = @aN", db.getConnection());
                
                for (int i = 0; i < artArr.Length; i++)
                {
                    if (artArr[i] != "")
                    {
                        command.Parameters.Add("@uL", SqlDbType.VarChar).Value = artArr[i];
                        command.Parameters.Add("@aN", SqlDbType.VarChar).Value = albumNm;
                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string strMsg = string.Format("У артиста с логином {0} уже существует альбом с таким названием.", artArr[i]);
                            MessageBox.Show(strMsg);
                            return;
                        }

                        command.Parameters.RemoveAt("@uL");
                        command.Parameters.RemoveAt("@aN");
                        table.Reset();
                    }
                }
            }

            DB dB = new DB();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Albums a INNER JOIN Album_User au ON a.AlbumId = au.AlbumId WHERE au.UserId = @uId AND a.AlbumName = @aN", dB.getConnection());

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlCommand.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;
            sqlCommand.Parameters.Add("@aN", SqlDbType.VarChar).Value = albumNm;

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                string msge = string.Format("У вас уже есть альбом с таким названием!");
                MessageBox.Show(msge);
                return;
            }

            dataTable.Reset();
            sqlCommand.Parameters.RemoveAt("@uId");
            sqlCommand.Parameters.RemoveAt("@aN");

            sqlCommand = new SqlCommand("DECLARE @albId INT EXEC dbo.AddAlbumsMain @albCover, @rlsDate, @albName, @currDate, @usrId, @albId OUTPUT SELECT @albId AS AlbumId", dB.getConnection());

            byte[] bytes = System.IO.File.ReadAllBytes(albumCoverImg.ImageLocation);
            DateTime currDate = DateTime.Now;
            int albId = -1;

            sqlCommand.Parameters.Add("@albCover", SqlDbType.VarBinary).Value = bytes;
            sqlCommand.Parameters.Add("@rlsDate", SqlDbType.Date).Value = dateRelease.Value;
            sqlCommand.Parameters.Add("@albName", SqlDbType.VarChar).Value = albumNm;
            sqlCommand.Parameters.Add("@currDate", SqlDbType.DateTime).Value = currDate;
            sqlCommand.Parameters.Add("@usrId", SqlDbType.Int).Value = this.userId;

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

            albId = int.Parse(row["AlbumId"].ToString());

            dB.closeConnetion();

            if (arts.Length > 0)
            {
                artArr = arts.Split(',');

                for (int i = 0; i < artArr.Length; i++)
                {
                    if (artArr[i] != "")
                    {
                        AddRelationAlbumUser(albId, artArr[i]);
                    }
                }
            }

            string msg = string.Format("Ваш альбом успешно создан!");
            MessageBox.Show(msg);

            albumCoverImg.ImageLocation = @"C:\Users\User\source\repos\MediaService\src\defaultImg.png";
            albumName.Text = string.Empty;
            artists.Text = string.Empty;
            albumCover.Text = string.Empty;
            dateRelease.Value = DateTime.Now;
        }

        private void addAlbumCoverBtn_Click(object sender, EventArgs e)
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
                    albumCover.Text = openFileDialog.FileName;
                    albumCoverImg.ImageLocation = albumCover.Text;
                }
            }
        }

        private void AddRelationAlbumUser(int albId, string usrLgn)
        {
            DB db = new DB();

            SqlCommand com = new SqlCommand("EXEC dbo.AddAlbumsAdditional @usrLgn, @albId, @curUsrId", db.getConnection());

            com.Parameters.Add("@usrLgn", SqlDbType.VarChar).Value = usrLgn;
            com.Parameters.Add("@albId", SqlDbType.Int).Value = albId;
            com.Parameters.Add("@curUsrId", SqlDbType.Int).Value = this.userId;

            db.openConnetion();
            
            com.ExecuteNonQuery();

            db.closeConnetion();
        }

        private void addSongBtn_Click(object sender, EventArgs e)
        {
            AddTrackForm addTrackForm = new AddTrackForm(this.userId);
            addTrackForm.Show();
            if (addTrackForm.flag)
                addTrackForm.Close();
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
            Application.Exit();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(closeBtn.Width + 2, closeBtn.Height + 2);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(closeBtn.Width - 2, closeBtn.Height - 2);
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void uploadIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void uploadLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void libraryPanel_Click(object sender, EventArgs e)
        {
            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void libraryIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void libraryLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMainForm userMainForm = new UserMainForm(this.userId);
            userMainForm.Show();
        }

        private void mainIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMainForm userMainForm = new UserMainForm(this.userId);
            userMainForm.Show();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMainForm userMainForm = new UserMainForm(this.userId);
            userMainForm.Show();
        }

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.White;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.Gray;
        }

        private void mainIcon_MouseEnter(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.White;
        }

        private void mainIcon_MouseLeave(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.Gray;
        }

        private void mainLabel_MouseEnter(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.White;
        }

        private void mainLabel_MouseLeave(object sender, EventArgs e)
        {
            mainBtn.ForeColor = Color.Gray;
        }

        private void searchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.White;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.Gray;
        }

        private void searchIcon_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.White;
        }

        private void searchIcon_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.Gray;
        }

        private void searchLabel_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.White;
        }

        private void searchLabel_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.ForeColor = Color.Gray;
        }

        private void libraryPanel_MouseEnter(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.White;
        }

        private void libraryPanel_MouseLeave(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.Gray;
        }

        private void libraryIcon_MouseEnter(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.White;
        }

        private void libraryIcon_MouseLeave(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.Gray;
        }

        private void libraryLabel_MouseEnter(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.White;
        }

        private void libraryLabel_MouseLeave(object sender, EventArgs e)
        {
            libraryPanel.ForeColor = Color.Gray;
        }

        private void uploadBtn_MouseEnter(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.White;
        }

        private void uploadBtn_MouseLeave(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.Gray;
        }

        private void uploadIcon_MouseEnter(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.White;
        }

        private void uploadIcon_MouseLeave(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.Gray;
        }

        private void uploadLabel_MouseEnter(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.White;
        }

        private void uploadLabel_MouseLeave(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.Gray;
        }

        private void profileBtn_MouseEnter(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.White;
        }

        private void profileBtn_MouseLeave(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.Gray;
        }

        private void profileIcon_MouseEnter(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.White;
        }

        private void profileIcon_MouseLeave(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.Gray;
        }

        private void profileLabel_MouseEnter(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.White;
        }

        private void profileLabel_MouseLeave(object sender, EventArgs e)
        {
            profileBtn.ForeColor = Color.Gray;
        }

        private void settingsPanel_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.White;
        }

        private void settingsPanel_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.Gray;
        }

        private void settingsIcon_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.White;
        }

        private void settingsIcon_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.Gray;
        }

        private void settingsLabel_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.White;
        }

        private void settingsLabel_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.ForeColor = Color.Gray;
        }
    }
}