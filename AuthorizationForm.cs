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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
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
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void toRegFormBtn_MouseEnter(object sender, EventArgs e)
        {
            toRegFormBtn.ForeColor = Color.White;
        }

        private void toRegFormBtn_MouseLeave(object sender, EventArgs e)
        {
            toRegFormBtn.ForeColor = Color.Gray;
        }

        private void toRegFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text.Replace(" ", "");
            HashPass userPass = new HashPass(passField.Text);

            if (userLogin == string.Empty)
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Users u WHERE u.UserLogin = @uL", db.getConnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = userLogin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row;

            if (table.Rows.Count > 0)
            {
                row = table.Rows[0];
                if (row["UserPass"].ToString() == userPass.hash)
                {
                    this.Hide();
                    UserMainForm userMainForm = new UserMainForm(int.Parse(row["UserId"].ToString()));
                    userMainForm.Show();
                }
                else
                    MessageBox.Show("Пароль неверный!");
            }
            else
                MessageBox.Show("Пользователя с таким логином не найдено!");
        }
    }
}