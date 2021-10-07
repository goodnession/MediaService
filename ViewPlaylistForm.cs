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
using WMPLib;

namespace MediaService
{
    public partial class ViewPlaylistForm : Form
    {
        public int userId;
        public int plstId;
        private int counter = 0;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string folderPath = @"c:\temp";

        public ViewPlaylistForm(int userId, int plstId)
        {
            InitializeComponent();

            this.userId = userId;
            this.plstId = plstId;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users u WHERE u.UserId = @uId", db.getConnection());
            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row;
            row = table.Rows[0];

            if (int.Parse(row["UserRole"].ToString()) > 0)
                uploadBtn.Visible = true;

            table.Reset();
            command.Parameters.RemoveAt("@uId");

            command = new SqlCommand("SELECT p.PlaylistCover, p.PlaylistName, u.UserName FROM Playlists p INNER JOIN Users u ON p.UserId = u.UserId WHERE p.PlaylistId = @pId", db.getConnection());

            command.Parameters.Add("@pId", SqlDbType.Int).Value = this.plstId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            row = table.Rows[0];

            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            byte[] bytes = (byte[])row["PlaylistCover"];
            string outpath = folderPath + @"\tf" + this.counter.ToString() + ".png";
            this.counter += 1;
            System.IO.File.WriteAllBytes(outpath, bytes);

            playlistCover.ImageLocation = outpath;
            playlistName.Text = row["PlaylistName"].ToString();
            userName.Text = row["UserName"].ToString();

            table.Reset();

            command = new SqlCommand("SELECT a.AlbumCover, s.Song, s.SongName, s.SongId, a.AlbumName, a.AlbumId FROM Playlists p INNER JOIN Playlist_Song ps ON p.PlaylistId = ps.PlaylistID INNER JOIN Songs s ON ps.SongId = s.SongId INNER JOIN Album_Song aas ON s.SongId = aas.SongId INNER JOIN Albums a ON aas.AlbumId = a.AlbumId WHERE p.PlaylistId = @pId", db.getConnection());

            command.Parameters.Add("@pId", SqlDbType.Int).Value = this.plstId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            songs.AutoSize = true;
            songs.Font = new Font("Arial", 12, FontStyle.Bold);
            songs.ForeColor = Color.White;

            songs.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            songs.Controls.Add(new Label() { Text = "#", ForeColor = Color.Gray, AutoSize = true }, 0, 0);
            songs.Controls.Add(new Label() { Text = "Обложка", ForeColor = Color.Gray, AutoSize = true }, 1, 0);
            songs.Controls.Add(new Label() { Text = "Название", ForeColor = Color.Gray, AutoSize = true }, 2, 0);
            songs.Controls.Add(new Label() { Text = "Испольнитель", ForeColor = Color.Gray, AutoSize = true }, 3, 0);
            songs.Controls.Add(new Label() { Text = "Альбом", ForeColor = Color.Gray, AutoSize = true }, 4, 0);
            songs.Controls.Add(new Label() { Text = "", ForeColor = Color.Gray, AutoSize = true }, 5, 0);

            for (int i=0; i<table.Rows.Count; i++)
            {
                songs.RowCount += 1;
                songs.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                row = table.Rows[i];

                string arts = string.Empty;

                SqlCommand sqlCommand = new SqlCommand("SELECT u.UserName FROM Users u INNER JOIN Song_User su ON u.UserId = su.UserId WHERE su.SongId = @sId", db.getConnection());

                sqlCommand.Parameters.Add("@sId", SqlDbType.Int).Value = int.Parse(row["SongId"].ToString());

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataRow dataRow;

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    dataRow = dataTable.Rows[j];
                    if (j == dataTable.Rows.Count - 1)
                        arts += dataRow["UserName"].ToString();
                    else
                        arts += dataRow["UserName"].ToString() + ", ";
                }

                byte[] song = (byte[])row["Song"];
                string outpathSong = folderPath + @"\tf" + this.counter.ToString() + ".mp3";
                this.counter += 1;
                System.IO.File.WriteAllBytes(outpathSong, song);

                byte[] albCover = (byte[])row["AlbumCover"];
                string outpathAlbCover = folderPath + @"\tf" + this.counter.ToString() + ".png";
                this.counter += 1;
                System.IO.File.WriteAllBytes(outpathAlbCover, albCover);

                songs.Controls.Add(new Label() { Text = (i + 1).ToString(), ForeColor = Color.White, AutoSize = true }, 0, songs.RowCount - 1);
                songs.Controls.Add(new PictureBox() { ImageLocation = outpathAlbCover, Size = new Size(50, 50), SizeMode = PictureBoxSizeMode.StretchImage}, 1, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = row["SongName"].ToString(), ForeColor = Color.White, AutoSize = true, Cursor = Cursors.Hand, Name = outpathSong }, 2, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = arts, ForeColor = Color.White, AutoSize = true }, 3, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = row["AlbumName"].ToString(), ForeColor = Color.White, AutoSize = true, Cursor = Cursors.Hand, Name = row["AlbumId"].ToString() }, 4, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = "X", ForeColor = Color.Red, AutoSize = true, Cursor = Cursors.Hand, Name = row["SongId"].ToString() }, 5, songs.RowCount - 1);
            }

            for (int i = 0; i < songs.Controls.Count; i++)
            {
                songs.Controls[i].Anchor = AnchorStyles.None;
            }

            for (int i = 2; i < songs.Controls.Count; i += 6)
            {
                songs.Controls[i].MouseClick += new MouseEventHandler(songClick);
            }

            for (int i = 4; i < songs.Controls.Count; i += 6)
            {
                songs.Controls[i].MouseClick += new MouseEventHandler(albumClick);
            }

            for (int i = 5; i < songs.Controls.Count; i += 6)
            {
                songs.Controls[i].MouseClick += new MouseEventHandler(deleteClick);
            }
        }

        void songClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            string path = (string)parent.Name;

            int songId = int.Parse(songs.Controls[songs.Controls.IndexOf(parent) + 3].Name);

            DB dB = new DB();

            SqlCommand sqlCommand = new SqlCommand("UPDATE Songs SET ListeningCounter = ListeningCounter + 1 WHERE SongId = @sId", dB.getConnection());

            sqlCommand.Parameters.Add("@sId", SqlDbType.Int).Value = songId;

            dB.openConnetion();

            if (sqlCommand.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Произошла ошибка, попробуйте позже.");
                return;
            }

            sqlCommand = new SqlCommand("INSERT INTO ListeningHistory VALUES (@usrID, @sId, GETDATE())", dB.getConnection());
            sqlCommand.Parameters.Add("@sId", SqlDbType.Int).Value = songId;
            sqlCommand.Parameters.Add("@usrId", SqlDbType.Int).Value = this.userId;

            if (sqlCommand.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Произошла ошибка, попробуйте позже.");
                return;
            }

            dB.closeConnetion();

            songName.Text = parent.Text;
            player.controls.stop();
            player = new WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        void albumClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            int albId = int.Parse((string)parent.Name);

            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ViewAlbum viewAlbum = new ViewAlbum(this.userId, albId);
            viewAlbum.Show();
        }

        void deleteClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            int songId = int.Parse((string)parent.Name);

            DB dB = new DB();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Playlist_Song WHERE SongId = @sId AND PlaylistId = @pId", dB.getConnection());

            sqlCommand.Parameters.Add("@sId", SqlDbType.Int).Value = songId;
            sqlCommand.Parameters.Add("@pId", SqlDbType.Int).Value = this.plstId;

            dB.openConnetion();

            if (sqlCommand.ExecuteNonQuery() > 0)
                MessageBox.Show("Трек удалён из плейлиста");
            else
                MessageBox.Show("Возникла ошибка, попробуйте позже");

            dB.closeConnetion();
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
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

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
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void uploadIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void uploadLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            UploadAlbums uploadAlbums = new UploadAlbums(this.userId);
            uploadAlbums.Show();
        }

        private void libraryPanel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void libraryIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void libraryLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            LibraryForm libraryForm = new LibraryForm(this.userId);
            libraryForm.Show();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SearchForm searchForm = new SearchForm(this.userId);
            searchForm.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ProfileForm profileForm = new ProfileForm(this.userId);
            profileForm.Show();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.userId);
            settingsForm.Show();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            UserMainForm userMainForm = new UserMainForm(this.userId);
            userMainForm.Show();
        }

        private void mainIcon_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            UserMainForm userMainForm = new UserMainForm(this.userId);
            userMainForm.Show();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {
            this.player.close();

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

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
