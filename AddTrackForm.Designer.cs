
namespace MediaService
{
    partial class AddTrackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addSongBtn = new System.Windows.Forms.Button();
            this.albums = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.artists = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseSongBtn = new System.Windows.Forms.Button();
            this.song = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 40);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::MediaService.Properties.Resources.minimizeBtn;
            this.minimizeBtn.Location = new System.Drawing.Point(942, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.minimizeBtn_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::MediaService.Properties.Resources.closeButton;
            this.closeBtn.Location = new System.Drawing.Point(968, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.addSongBtn);
            this.mainPanel.Controls.Add(this.albums);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.genres);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.artists);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.chooseSongBtn);
            this.mainPanel.Controls.Add(this.song);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.songName);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 311);
            this.mainPanel.TabIndex = 2;
            // 
            // addSongBtn
            // 
            this.addSongBtn.AutoSize = true;
            this.addSongBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.addSongBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongBtn.FlatAppearance.BorderSize = 0;
            this.addSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSongBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSongBtn.ForeColor = System.Drawing.Color.White;
            this.addSongBtn.Location = new System.Drawing.Point(438, 263);
            this.addSongBtn.Name = "addSongBtn";
            this.addSongBtn.Size = new System.Drawing.Size(123, 26);
            this.addSongBtn.TabIndex = 24;
            this.addSongBtn.Text = "Добавить трек";
            this.addSongBtn.UseVisualStyleBackColor = false;
            this.addSongBtn.Click += new System.EventHandler(this.addSongBtn_Click);
            // 
            // albums
            // 
            this.albums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albums.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albums.FormattingEnabled = true;
            this.albums.Location = new System.Drawing.Point(500, 64);
            this.albums.Name = "albums";
            this.albums.Size = new System.Drawing.Size(400, 24);
            this.albums.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(100, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Альбом";
            // 
            // genres
            // 
            this.genres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genres.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genres.FormattingEnabled = true;
            this.genres.Location = new System.Drawing.Point(500, 172);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(400, 24);
            this.genres.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Жанр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(100, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Введите их логины через запятую";
            // 
            // artists
            // 
            this.artists.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.artists.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artists.Location = new System.Drawing.Point(500, 208);
            this.artists.MaxLength = 1000;
            this.artists.Name = "artists";
            this.artists.Size = new System.Drawing.Size(400, 23);
            this.artists.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Другие артисты, работавшие над альбомом";
            // 
            // chooseSongBtn
            // 
            this.chooseSongBtn.AutoSize = true;
            this.chooseSongBtn.BackColor = System.Drawing.Color.Gray;
            this.chooseSongBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseSongBtn.FlatAppearance.BorderSize = 0;
            this.chooseSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseSongBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseSongBtn.ForeColor = System.Drawing.Color.White;
            this.chooseSongBtn.Location = new System.Drawing.Point(777, 134);
            this.chooseSongBtn.Name = "chooseSongBtn";
            this.chooseSongBtn.Size = new System.Drawing.Size(123, 26);
            this.chooseSongBtn.TabIndex = 4;
            this.chooseSongBtn.Text = "Выбрать файл";
            this.chooseSongBtn.UseVisualStyleBackColor = false;
            this.chooseSongBtn.Click += new System.EventHandler(this.chooseSongBtn_Click);
            // 
            // song
            // 
            this.song.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song.Location = new System.Drawing.Point(500, 136);
            this.song.MaxLength = 32000;
            this.song.Name = "song";
            this.song.ReadOnly = true;
            this.song.Size = new System.Drawing.Size(271, 23);
            this.song.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Трек";
            // 
            // songName
            // 
            this.songName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songName.Location = new System.Drawing.Point(500, 100);
            this.songName.MaxLength = 100;
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(400, 23);
            this.songName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название трека";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавьте свой трек в альбом";
            // 
            // AddTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 351);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrackForm";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chooseSongBtn;
        private System.Windows.Forms.TextBox song;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSongBtn;
        private System.Windows.Forms.ComboBox albums;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox artists;
        private System.Windows.Forms.Label label5;
    }
}