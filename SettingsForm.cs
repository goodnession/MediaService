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
    public partial class SettingsForm : Form
    {
        public int userId;
        
        public SettingsForm(int userId)
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

            curUserName.Text = row["UserName"].ToString();

            table.Reset();
            command.Parameters.RemoveAt("@uId");
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string uName = userName.Text.Trim();
            string uPass = userPass.Text.Replace(" ", "");

            DB dB = new DB();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            HashPass pass = new HashPass(uPass);

            string passChars = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%^&*()_+-=?";

            if (uPass != string.Empty)
            {
                if (uPass.Length < 5)
                {
                    MessageBox.Show("Для лучшей безопасности, длина пароля должна быть от 5 до 18 символов!");
                    return;
                }

                for (int i = 0; i < uPass.Length; i++)
                {
                    if (!passChars.Contains(uPass[i]))
                    {
                        MessageBox.Show("Пароль может состоять только из символов латинского алфавита, цифр а также специальных символов (!@#$%^&*()_+-=?).");
                        return;
                    }
                }

                pass = new HashPass(uPass);
            }

            if (uPass != string.Empty && uName != string.Empty)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET UserName = @uN, UserPass = @uP WHERE UserId = @uId", dB.getConnection());

                sqlCommand.Parameters.Add("@uN", SqlDbType.VarChar).Value = uName;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass.hash;
                sqlCommand.Parameters.Add("@uId", SqlDbType.VarChar).Value = this.userId;

                dB.openConnetion();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Сведения обновлены");
                    userName.Text = string.Empty;
                    userPass.Text = string.Empty;
                }
                else
                    MessageBox.Show("Возникла ошибка, попробуйте позже");

                dB.closeConnetion();
            }

            if (uPass != string.Empty && uName == string.Empty)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET UserPass = @uP WHERE UserId = @uId", dB.getConnection());

                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass.hash;
                sqlCommand.Parameters.Add("@uId", SqlDbType.VarChar).Value = this.userId;

                dB.openConnetion();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Сведения обновлены");
                    userName.Text = string.Empty;
                    userPass.Text = string.Empty;
                }
                else
                    MessageBox.Show("Возникла ошибка, попробуйте позже");

                dB.closeConnetion();
            }

            if (uPass == string.Empty && uName != string.Empty)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET UserName = @uN WHERE UserId = @uId", dB.getConnection());

                sqlCommand.Parameters.Add("@uN", SqlDbType.VarChar).Value = uName;
                sqlCommand.Parameters.Add("@uId", SqlDbType.VarChar).Value = this.userId;

                dB.openConnetion();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Сведения обновлены");
                    userName.Text = string.Empty;
                    userPass.Text = string.Empty;
                }
                else
                    MessageBox.Show("Возникла ошибка, попробуйте позже");

                dB.closeConnetion();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }
    }
}
