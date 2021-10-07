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
    public partial class ProfileForm : Form
    {
        public int userId;
        private int counter = 0;
        private string folderPath = @"c:\temp";

        public ProfileForm(int userId)
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
            {
                uploadBtn.Visible = true;
                relAlbLabel.Visible = true;
                relAlbums.Visible = true;
                unrelAlbLabel.Visible = true;
                unrelAlbums.Visible = true;
            }

            table.Reset();
            command.Parameters.RemoveAt("@uId");

            command = new SqlCommand("WITH aa AS( SELECT TOP 100 * FROM Albums a WHERE a.ReleaseDate <= GETDATE() ORDER BY a.ReleaseDate DESC, a.AlbumId) SELECT aa.AlbumId, aa.AlbumCover, FORMAT(aa.ReleaseDate, 'yyyy', 'en-US') AS ReleaseDate, aa.AlbumName FROM aa INNER JOIN Album_User au ON aa.AlbumId = au.AlbumId INNER JOIN Users u ON au.UserId = u.UserId WHERE u.UserId = @uId", db.getConnection());

            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            relAlbums.AutoSize = true;
            relAlbums.Font = new Font("Arial", 12, FontStyle.Bold);
            relAlbums.ForeColor = Color.White;

            relAlbums.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            relAlbums.Controls.Add(new Label() { Text = "#", ForeColor = Color.Gray, AutoSize = true }, 0, 0);
            relAlbums.Controls.Add(new Label() { Text = "Обложка", ForeColor = Color.Gray, AutoSize = true }, 1, 0);
            relAlbums.Controls.Add(new Label() { Text = "Альбом", ForeColor = Color.Gray, AutoSize = true }, 2, 0);
            relAlbums.Controls.Add(new Label() { Text = "Исполнитель", ForeColor = Color.Gray, AutoSize = true }, 3, 0);
            relAlbums.Controls.Add(new Label() { Text = "Дата релиза", ForeColor = Color.Gray, AutoSize = true }, 4, 0);

            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                relAlbums.RowCount += 1;
                relAlbums.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                row = table.Rows[i];

                byte[] bytes = (byte[])row["AlbumCover"];
                string outpath = folderPath + @"\tf" + this.counter.ToString() + ".png";
                this.counter += 1;
                System.IO.File.WriteAllBytes(outpath, bytes);

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand("SELECT u.UserName FROM Users u INNER JOIN Album_User au ON u.UserId = au.UserId WHERE au.AlbumId = @albId", db.getConnection());

                sqlCommand.Parameters.Add("@albId", SqlDbType.Int).Value = int.Parse(row["AlbumId"].ToString());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
                DataRow dataRow;

                string arts = string.Empty;

                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    dataRow = dataTable.Rows[j];
                    if (j == dataTable.Rows.Count - 1)
                        arts += dataRow["UserName"].ToString();
                    else
                        arts += dataRow["UserName"].ToString() + ", ";
                }

                relAlbums.Controls.Add(new Label() { Text = (i + 1).ToString(), ForeColor = Color.White, AutoSize = true }, 0, relAlbums.RowCount - 1);
                relAlbums.Controls.Add(new PictureBox() { ImageLocation = outpath, Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.StretchImage, Cursor = Cursors.Hand, Name = row["AlbumId"].ToString() }, 1, relAlbums.RowCount - 1);
                relAlbums.Controls.Add(new Label() { Text = row["AlbumName"].ToString(), ForeColor = Color.White, AutoSize = true }, 2, relAlbums.RowCount - 1);
                relAlbums.Controls.Add(new Label() { Text = arts, ForeColor = Color.White, AutoSize = true }, 3, relAlbums.RowCount - 1);
                relAlbums.Controls.Add(new Label() { Text = row["ReleaseDate"].ToString(), ForeColor = Color.White, AutoSize = true }, 4, relAlbums.RowCount - 1);
            }

            for (int i = 0; i < relAlbums.Controls.Count; i++)
            {
                relAlbums.Controls[i].Anchor = AnchorStyles.None;
            }

            for (int i = 6; i < relAlbums.Controls.Count; i += 5)
            {
                relAlbums.Controls[i].MouseClick += new MouseEventHandler(pictureBoxClick);
            }

            unrelAlbLabel.Location = new Point(20, relAlbums.Location.Y + relAlbums.Size.Height + 20);
            unrelAlbums.Location = new Point(15, unrelAlbLabel.Location.Y + unrelAlbLabel.Size.Height + 20);

            table.Reset();

            command = new SqlCommand("WITH aa AS( SELECT TOP 100 * FROM Albums a WHERE a.ReleaseDate > GETDATE() ORDER BY a.ReleaseDate DESC, a.AlbumId) SELECT aa.AlbumId, aa.AlbumCover, FORMAT(aa.ReleaseDate, 'dd/MM/yyyy', 'de-de') AS ReleaseDate, aa.AlbumName FROM aa INNER JOIN Album_User au ON aa.AlbumId = au.AlbumId INNER JOIN Users u ON au.UserId = u.UserId WHERE u.UserId = @uId", db.getConnection());

            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            unrelAlbums.AutoSize = true;
            unrelAlbums.Font = new Font("Arial", 12, FontStyle.Bold);
            unrelAlbums.ForeColor = Color.White;

            unrelAlbums.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            unrelAlbums.Controls.Add(new Label() { Text = "#", ForeColor = Color.Gray, AutoSize = true }, 0, 0);
            unrelAlbums.Controls.Add(new Label() { Text = "Обложка", ForeColor = Color.Gray, AutoSize = true }, 1, 0);
            unrelAlbums.Controls.Add(new Label() { Text = "Альбом", ForeColor = Color.Gray, AutoSize = true }, 2, 0);
            unrelAlbums.Controls.Add(new Label() { Text = "Исполнитель", ForeColor = Color.Gray, AutoSize = true }, 3, 0);
            unrelAlbums.Controls.Add(new Label() { Text = "Дата релиза", ForeColor = Color.Gray, AutoSize = true }, 4, 0);
            unrelAlbums.Controls.Add(new Label() { Text = "", ForeColor = Color.Gray, AutoSize = true }, 5, 0);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                unrelAlbums.RowCount += 1;
                unrelAlbums.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                row = table.Rows[i];

                byte[] bytes = (byte[])row["AlbumCover"];
                string outpath = folderPath + @"\tf" + this.counter.ToString() + ".png";
                this.counter += 1;
                System.IO.File.WriteAllBytes(outpath, bytes);

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand("SELECT u.UserName FROM Users u INNER JOIN Album_User au ON u.UserId = au.UserId WHERE au.AlbumId = @albId", db.getConnection());

                sqlCommand.Parameters.Add("@albId", SqlDbType.Int).Value = int.Parse(row["AlbumId"].ToString());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
                DataRow dataRow;

                string arts = string.Empty;

                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    dataRow = dataTable.Rows[j];
                    if (j == dataTable.Rows.Count - 1)
                        arts += dataRow["UserName"].ToString();
                    else
                        arts += dataRow["UserName"].ToString() + ", ";
                }

                unrelAlbums.Controls.Add(new Label() { Text = (i + 1).ToString(), ForeColor = Color.White, AutoSize = true }, 0, unrelAlbums.RowCount - 1);
                unrelAlbums.Controls.Add(new PictureBox() { ImageLocation = outpath, Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.StretchImage, Cursor = Cursors.Hand, Name = row["AlbumId"].ToString() }, 1, unrelAlbums.RowCount - 1);
                unrelAlbums.Controls.Add(new Label() { Text = row["AlbumName"].ToString(), ForeColor = Color.White, AutoSize = true }, 2, unrelAlbums.RowCount - 1);
                unrelAlbums.Controls.Add(new Label() { Text = arts, ForeColor = Color.White, AutoSize = true }, 3, unrelAlbums.RowCount - 1);
                unrelAlbums.Controls.Add(new Label() { Text = row["ReleaseDate"].ToString(), ForeColor = Color.White, AutoSize = true }, 4, unrelAlbums.RowCount - 1);
                unrelAlbums.Controls.Add(new Label() { Text = "X", ForeColor = Color.Red, AutoSize = true, Cursor = Cursors.Hand, Name = row["AlbumId"].ToString() }, 5, unrelAlbums.RowCount - 1);
            }

            for (int i = 0; i < unrelAlbums.Controls.Count; i++)
            {
                unrelAlbums.Controls[i].Anchor = AnchorStyles.None;
            }

            for (int i = 7; i < unrelAlbums.Controls.Count; i += 6)
            {
                unrelAlbums.Controls[i].MouseClick += new MouseEventHandler(pictureBoxClick);
            }

            for (int i = 11; i < unrelAlbums.Controls.Count; i += 6)
            {
                unrelAlbums.Controls[i].MouseClick += new MouseEventHandler(deleteAlbumClick);
            }
        }

        void pictureBoxClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            string albId = (string)parent.Name;

            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }

            this.Close();
            ViewAlbum viewAlbum = new ViewAlbum(this.userId, int.Parse(albId));
            viewAlbum.Show();
        }

        void deleteAlbumClick(object sender, MouseEventArgs e)
        {
            Control parent = ((Control)sender);
            int albId = int.Parse((string)parent.Name);

            DialogResult dialogResult = MessageBox.Show("Уверены, что хотите удалить альбом?", "Удаление альбома", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DB dB = new DB();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Songs WHERE SongId IN (SELECT s.SongId FROM Songs s INNER JOIN Album_Song aas ON s.SongId = aas.SongId WHERE aas.AlbumId = @aId); DELETE FROM Albums WHERE AlbumId = @aId", dB.getConnection());

                sqlCommand.Parameters.Add("@aId", SqlDbType.Int).Value = albId;

                dB.openConnetion();

                if (sqlCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Альбом удалён!");
                else
                    MessageBox.Show("Возникла ошибка, попробуйте позже");

                dB.closeConnetion();
            }
        }

        private void listeningHistoryBtn_Click(object sender, EventArgs e)
        {
            ListeningHistoryForm listeningHistoryForm = new ListeningHistoryForm(this.userId);
            listeningHistoryForm.Show();
        }

        private void listeningHistoryBtn_MouseEnter(object sender, EventArgs e)
        {
            listeningHistoryBtn.ForeColor = Color.White;
        }

        private void listeningHistoryBtn_MouseLeave(object sender, EventArgs e)
        {
            listeningHistoryBtn.ForeColor = Color.Gray;
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
