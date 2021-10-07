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
    public partial class ListeningHistoryForm : Form
    {
        public int userId;
        
        public ListeningHistoryForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataRow row;

            SqlCommand command = new SqlCommand("WITH aa AS (SELECT TOP 50 * FROM ListeningHistory l WHERE UserId = @uId ORDER BY l.Date DESC) SELECT s.SongId, a.AlbumId, s.SongName, a.AlbumName, FORMAT(aa.Date, 'dd/MM/yyyy hh:mm', 'de-de') AS Date FROM aa INNER JOIN Songs s ON aa.SongId = s.SongId INNER JOIN Album_Song aas ON s.SongId = aas.SongId INNER JOIN Albums a ON aas.AlbumId = a.AlbumId", db.getConnection());

            command.Parameters.Add("@uId", SqlDbType.Int).Value = this.userId;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            songs.AutoSize = true;
            songs.Font = new Font("Arial", 12, FontStyle.Bold);
            songs.ForeColor = Color.White;

            songs.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            songs.Controls.Add(new Label() { Text = "#", ForeColor = Color.Gray, AutoSize = true }, 0, 0);
            songs.Controls.Add(new Label() { Text = "Название", ForeColor = Color.Gray, AutoSize = true }, 1, 0);
            songs.Controls.Add(new Label() { Text = "Испольнитель", ForeColor = Color.Gray, AutoSize = true }, 2, 0);
            songs.Controls.Add(new Label() { Text = "Альбом", ForeColor = Color.Gray, AutoSize = true }, 3, 0);
            songs.Controls.Add(new Label() { Text = "Дата", ForeColor = Color.Gray, AutoSize = true }, 4, 0);

            for (int i = 0; i < table.Rows.Count; i++)
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

                songs.Controls.Add(new Label() { Text = (i + 1).ToString(), ForeColor = Color.White, AutoSize = true }, 0, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = row["SongName"].ToString(), ForeColor = Color.White, AutoSize = true }, 1, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = arts, ForeColor = Color.White, AutoSize = true }, 2, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = row["AlbumName"].ToString(), ForeColor = Color.White, AutoSize = true }, 3, songs.RowCount - 1);
                songs.Controls.Add(new Label() { Text = row["Date"].ToString(), ForeColor = Color.White, AutoSize = true }, 4, songs.RowCount - 1);
            }

            for (int i = 0; i < songs.Controls.Count; i++)
            {
                songs.Controls[i].Anchor = AnchorStyles.None;
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
