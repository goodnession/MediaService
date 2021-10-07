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
    public partial class LibraryForm : Form
    {
        public int userId;
        private int counter = 0;
        private string folderPath = @"c:\temp";

        public LibraryForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

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

            command = new SqlCommand("SELECT PlaylistId, PlaylistName, PlaylistCover FROM Playlists WHERE UserId = @uId", db.getConnection());

            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            playlists.AutoSize = true;
            playlists.Font = new Font("Arial", 12, FontStyle.Bold);
            playlists.ForeColor = Color.White;

            playlists.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            playlists.Controls.Add(new Label() { Text = "#", ForeColor = Color.Gray, AutoSize = true }, 0, 0);
            playlists.Controls.Add(new Label() { Text = "Обложка", ForeColor = Color.Gray, AutoSize = true }, 1, 0);
            playlists.Controls.Add(new Label() { Text = "Плейлист", ForeColor = Color.Gray, AutoSize = true }, 2, 0);
            playlists.Controls.Add(new Label() { Text = "", ForeColor = Color.Gray, AutoSize = true }, 3, 0);

            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                playlists.RowCount += 1;
                playlists.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                row = table.Rows[i];

                byte[] bytes = (byte[])row["PlaylistCover"];
                string outpath = folderPath + @"\tf" + this.counter.ToString() + ".png";
                this.counter += 1;
                System.IO.File.WriteAllBytes(outpath, bytes);

                playlists.Controls.Add(new Label() { Text = (i + 1).ToString(), ForeColor = Color.White, AutoSize = true }, 0, playlists.RowCount - 1);
                playlists.Controls.Add(new PictureBox() { ImageLocation = outpath, Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.StretchImage, Cursor = Cursors.Hand, Name = row["PlaylistId"].ToString() }, 1, playlists.RowCount - 1);
                playlists.Controls.Add(new Label() { Text = row["PlaylistName"].ToString(), ForeColor = Color.White, AutoSize = true }, 2, playlists.RowCount - 1);
                playlists.Controls.Add(new Label() { Text = "X", ForeColor = Color.Red, AutoSize = true, Cursor = Cursors.Hand, Name = row["PlaylistId"].ToString() }, 3, playlists.RowCount - 1);
            }

            for (int i = 0; i < playlists.Controls.Count; i++)
            {
                playlists.Controls[i].Anchor = AnchorStyles.None;
            }

            for (int i = 3; i < playlists.Controls.Count; i += 4)
            {
                playlists.Controls[i].MouseClick += new MouseEventHandler(deletePlaylistClick);
            }

            for (int i = 1; i < playlists.Controls.Count; i += 4)
            {
                playlists.Controls[i].MouseClick += new MouseEventHandler(viewPlaylistClick);
            }
        }

        private void crtPlstBtn_Click(object sender, EventArgs e)
        {
            CreatePlaylistForm createPlaylistForm = new CreatePlaylistForm(this.userId);
            createPlaylistForm.Show();
        }

        void deletePlaylistClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            int plstId = int.Parse((string)parent.Name);

            DialogResult dialogResult = MessageBox.Show("Уверены, что хотите удалить плейлист?", "Удаление плейлиста", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DB dB = new DB();

                SqlCommand command = new SqlCommand("DELETE FROM Playlists WHERE PlaylistId = @pId", dB.getConnection());
                command.Parameters.Add("@pId", SqlDbType.Int).Value = plstId;

                dB.openConnetion();

                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Плейлист удалён.");
                else
                    MessageBox.Show("Произошла ошибка, попробуйте позже");

                dB.closeConnetion();
            }
        }

        void viewPlaylistClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            int plstId = int.Parse((string)parent.Name);

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ViewPlaylistForm viewPlaylistForm = new ViewPlaylistForm(this.userId, plstId);
            viewPlaylistForm.Show();
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
