using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaService
{
    public partial class RegistrationForm : Form
    {
        
        public RegistrationForm()
        {
            InitializeComponent();
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

        private void toAuthFormBtn_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Close();
        }

        private void toAuthFormBtn_MouseEnter(object sender, EventArgs e)
        {
            toAuthFormBtn.ForeColor = Color.White;
        }

        private void toAuthFormBtn_MouseLeave(object sender, EventArgs e)
        {
            toAuthFormBtn.ForeColor = Color.Gray;
        }

        private void regArtBtn_Click(object sender, EventArgs e)
        {
            string loginChars = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string passChars = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%^&*()_+-=?";
            
            string userLogin = loginField.Text.Replace(" ", "");
            string userName = nameField.Text.Trim();
            string userPass = passField.Text.Replace(" ", "");

            if (userLogin.Length < 3)
            {
                MessageBox.Show("Логин должен быть не короче 3-х символов!");
                return;
            }

            for (int i = 0; i < userLogin.Length; i++)
            {
                if (!loginChars.Contains(userLogin[i]))
                {
                    MessageBox.Show("Логин может состоять только из символов латинского алфавита и цифр!");
                    return;
                }
            }

            if (userPass.Length < 5)
            {
                MessageBox.Show("Для лучшей безопасности, длина пароля должна быть от 5 до 18 символов!");
                return;
            }

            for (int i = 0; i < userPass.Length; i++)
            {
                if (!passChars.Contains(userPass[i]))
                {
                    MessageBox.Show("Пароль может состоять только из символов латинского алфавита, цифр а также специальных символов (!@#$%^&*()_+-=?).");
                    return;
                }
            }

            if (userName.Length == 0)
            {
                userName = SetUserName();
            }

            if (CheckUser(userLogin))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                return;
            }    

            HashPass pass = new HashPass(userPass);

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Users VALUES(@userName, @userLogin, @userPass, @userRole)", db.getConnection());

            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@userLogin", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", SqlDbType.VarChar).Value = pass.hash;
            if (loginField.Text == "admin")
                command.Parameters.Add("@userRole", SqlDbType.SmallInt).Value = 2;
            else
                command.Parameters.Add("@userRole", SqlDbType.SmallInt).Value = 1;

            db.openConnetion();

            if (command.ExecuteNonQuery() == 1)
            {
                string strMsg = string.Format("Аккаунт был создан! Ваш логин: {0}", userLogin);
                MessageBox.Show(strMsg);
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Аккаунт не был создан! Повторите попытку.");

            db.closeConnetion();
        }

        private void regUsrBtn_Click(object sender, EventArgs e)
        {
            string loginChars = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string passChars = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%^&*()_+-=?";

            string userLogin = loginField.Text.Replace(" ", "");
            string userName = nameField.Text.Trim();
            string userPass = passField.Text.Replace(" ", "");

            if (userLogin.Length < 3)
            {
                MessageBox.Show("Логин должен быть не короче 3-х символов!");
                return;
            }

            if (userPass.Length < 5)
            {
                MessageBox.Show("Для лучшей безопасности, длина пароля должна быть от 5 до 18 символов!");
                return;
            }

            for (int i = 0; i < userLogin.Length; i++)
            {
                if (!loginChars.Contains(userLogin[i]))
                {
                    MessageBox.Show("Логин может состоять только из символов латинского алфавита и цифр!");
                    return;
                }
            }

            for (int i = 0; i < userPass.Length; i++)
            {
                if (!passChars.Contains(userPass[i]))
                {
                    MessageBox.Show("Пароль может состоять только из символов латинского алфавита, цифр а также специальных символов (!@#$%^&*()_+-=?).");
                    return;
                }
            }

            if (userName.Length == 0)
            {
                userName = SetUserName();
            }

            if (CheckUser(userLogin))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                return;
            }

            HashPass pass = new HashPass(userPass);

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Users VALUES(@userName, @userLogin, @userPass, @userRole)", db.getConnection());

            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@userLogin", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", SqlDbType.VarChar).Value = pass.hash;
            command.Parameters.Add("@userRole", SqlDbType.SmallInt).Value = 0;

            db.openConnetion();

            if (command.ExecuteNonQuery() == 1)
            {
                string strMsg = string.Format("Аккаунт был создан! Ваш логин: {0}", userLogin);
                MessageBox.Show(strMsg);
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Аккаунт не был создан! Повторите попытку.");

            db.closeConnetion();
        }

        private bool CheckUser(string login)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users u WHERE u.UserLogin = @uL", db.getConnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private string SetUserName()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT dbo.cntUsers()", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row;
            row = table.Rows[0];

            return "user" + row[0];
        }
    }
}