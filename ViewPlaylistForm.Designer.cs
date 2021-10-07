
namespace MediaService
{
    partial class ViewPlaylistForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.uploadBtn = new System.Windows.Forms.Panel();
            this.uploadIcon = new System.Windows.Forms.PictureBox();
            this.uploadLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Panel();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryIcon = new System.Windows.Forms.PictureBox();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.mainBtn = new System.Windows.Forms.Panel();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.songName = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.songs = new System.Windows.Forms.TableLayoutPanel();
            this.userName = new System.Windows.Forms.Label();
            this.playlistName = new System.Windows.Forms.Label();
            this.playlistCover = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.uploadBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadIcon)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            this.profileBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.libraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryIcon)).BeginInit();
            this.searchBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.mainBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistCover)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.uploadBtn);
            this.menuPanel.Controls.Add(this.settingsPanel);
            this.menuPanel.Controls.Add(this.profileBtn);
            this.menuPanel.Controls.Add(this.libraryPanel);
            this.menuPanel.Controls.Add(this.searchBtn);
            this.menuPanel.Controls.Add(this.mainBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 40);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(250, 680);
            this.menuPanel.TabIndex = 8;
            // 
            // uploadBtn
            // 
            this.uploadBtn.AutoSize = true;
            this.uploadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadBtn.Controls.Add(this.uploadIcon);
            this.uploadBtn.Controls.Add(this.uploadLabel);
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadBtn.ForeColor = System.Drawing.Color.Gray;
            this.uploadBtn.Location = new System.Drawing.Point(30, 506);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(197, 38);
            this.uploadBtn.TabIndex = 6;
            this.uploadBtn.Visible = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            this.uploadBtn.MouseEnter += new System.EventHandler(this.uploadBtn_MouseEnter);
            this.uploadBtn.MouseLeave += new System.EventHandler(this.uploadBtn_MouseLeave);
            // 
            // uploadIcon
            // 
            this.uploadIcon.Image = global::MediaService.Properties.Resources.uploadIcon;
            this.uploadIcon.Location = new System.Drawing.Point(3, 3);
            this.uploadIcon.Name = "uploadIcon";
            this.uploadIcon.Size = new System.Drawing.Size(32, 32);
            this.uploadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadIcon.TabIndex = 0;
            this.uploadIcon.TabStop = false;
            this.uploadIcon.Click += new System.EventHandler(this.uploadIcon_Click);
            this.uploadIcon.MouseEnter += new System.EventHandler(this.uploadIcon_MouseEnter);
            this.uploadIcon.MouseLeave += new System.EventHandler(this.uploadIcon_MouseLeave);
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.Location = new System.Drawing.Point(40, 10);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(154, 19);
            this.uploadLabel.TabIndex = 1;
            this.uploadLabel.Text = "Загрузить альбом";
            this.uploadLabel.Click += new System.EventHandler(this.uploadLabel_Click);
            this.uploadLabel.MouseEnter += new System.EventHandler(this.uploadLabel_MouseEnter);
            this.uploadLabel.MouseLeave += new System.EventHandler(this.uploadLabel_MouseLeave);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsPanel.Controls.Add(this.settingsIcon);
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsPanel.ForeColor = System.Drawing.Color.Gray;
            this.settingsPanel.Location = new System.Drawing.Point(30, 622);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(138, 38);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.Click += new System.EventHandler(this.settingsPanel_Click);
            this.settingsPanel.MouseEnter += new System.EventHandler(this.settingsPanel_MouseEnter);
            this.settingsPanel.MouseLeave += new System.EventHandler(this.settingsPanel_MouseLeave);
            // 
            // settingsIcon
            // 
            this.settingsIcon.Image = global::MediaService.Properties.Resources.settingsIcon;
            this.settingsIcon.Location = new System.Drawing.Point(3, 3);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(32, 32);
            this.settingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsIcon.TabIndex = 0;
            this.settingsIcon.TabStop = false;
            this.settingsIcon.Click += new System.EventHandler(this.settingsIcon_Click);
            this.settingsIcon.MouseEnter += new System.EventHandler(this.settingsIcon_MouseEnter);
            this.settingsIcon.MouseLeave += new System.EventHandler(this.settingsIcon_MouseLeave);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(40, 10);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(95, 19);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Настройки";
            this.settingsLabel.Click += new System.EventHandler(this.settingsLabel_Click);
            this.settingsLabel.MouseEnter += new System.EventHandler(this.settingsLabel_MouseEnter);
            this.settingsLabel.MouseLeave += new System.EventHandler(this.settingsLabel_MouseLeave);
            // 
            // profileBtn
            // 
            this.profileBtn.AutoSize = true;
            this.profileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profileBtn.Controls.Add(this.profileIcon);
            this.profileBtn.Controls.Add(this.profileLabel);
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileBtn.ForeColor = System.Drawing.Color.Gray;
            this.profileBtn.Location = new System.Drawing.Point(30, 564);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(163, 38);
            this.profileBtn.TabIndex = 4;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            this.profileBtn.MouseEnter += new System.EventHandler(this.profileBtn_MouseEnter);
            this.profileBtn.MouseLeave += new System.EventHandler(this.profileBtn_MouseLeave);
            // 
            // profileIcon
            // 
            this.profileIcon.Image = global::MediaService.Properties.Resources.usrIcon1;
            this.profileIcon.Location = new System.Drawing.Point(3, 3);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(32, 32);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            this.profileIcon.Click += new System.EventHandler(this.profileIcon_Click);
            this.profileIcon.MouseEnter += new System.EventHandler(this.profileIcon_MouseEnter);
            this.profileIcon.MouseLeave += new System.EventHandler(this.profileIcon_MouseLeave);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(40, 10);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(120, 19);
            this.profileLabel.TabIndex = 1;
            this.profileLabel.Text = "Мой профиль";
            this.profileLabel.Click += new System.EventHandler(this.profileLabel_Click);
            this.profileLabel.MouseEnter += new System.EventHandler(this.profileLabel_MouseEnter);
            this.profileLabel.MouseLeave += new System.EventHandler(this.profileLabel_MouseLeave);
            // 
            // libraryPanel
            // 
            this.libraryPanel.AutoSize = true;
            this.libraryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.libraryPanel.Controls.Add(this.libraryIcon);
            this.libraryPanel.Controls.Add(this.libraryLabel);
            this.libraryPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.libraryPanel.ForeColor = System.Drawing.Color.Gray;
            this.libraryPanel.Location = new System.Drawing.Point(30, 146);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(171, 38);
            this.libraryPanel.TabIndex = 3;
            this.libraryPanel.Click += new System.EventHandler(this.libraryPanel_Click);
            this.libraryPanel.MouseEnter += new System.EventHandler(this.libraryPanel_MouseEnter);
            this.libraryPanel.MouseLeave += new System.EventHandler(this.libraryPanel_MouseLeave);
            // 
            // libraryIcon
            // 
            this.libraryIcon.Image = global::MediaService.Properties.Resources.mediaLibraryIcon;
            this.libraryIcon.Location = new System.Drawing.Point(3, 3);
            this.libraryIcon.Name = "libraryIcon";
            this.libraryIcon.Size = new System.Drawing.Size(32, 32);
            this.libraryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryIcon.TabIndex = 0;
            this.libraryIcon.TabStop = false;
            this.libraryIcon.Click += new System.EventHandler(this.libraryIcon_Click);
            this.libraryIcon.MouseEnter += new System.EventHandler(this.libraryIcon_MouseEnter);
            this.libraryIcon.MouseLeave += new System.EventHandler(this.libraryIcon_MouseLeave);
            // 
            // libraryLabel
            // 
            this.libraryLabel.AutoSize = true;
            this.libraryLabel.Location = new System.Drawing.Point(40, 10);
            this.libraryLabel.Name = "libraryLabel";
            this.libraryLabel.Size = new System.Drawing.Size(128, 19);
            this.libraryLabel.TabIndex = 1;
            this.libraryLabel.Text = "Моя медиатека";
            this.libraryLabel.Click += new System.EventHandler(this.libraryLabel_Click);
            this.libraryLabel.MouseEnter += new System.EventHandler(this.libraryLabel_MouseEnter);
            this.libraryLabel.MouseLeave += new System.EventHandler(this.libraryLabel_MouseLeave);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.Controls.Add(this.searchIcon);
            this.searchBtn.Controls.Add(this.searchLabel);
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.Gray;
            this.searchBtn.Location = new System.Drawing.Point(30, 88);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 38);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_MouseEnter);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            // 
            // searchIcon
            // 
            this.searchIcon.Image = global::MediaService.Properties.Resources.searchIcon;
            this.searchIcon.Location = new System.Drawing.Point(3, 3);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(32, 32);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon.TabIndex = 0;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            this.searchIcon.MouseEnter += new System.EventHandler(this.searchIcon_MouseEnter);
            this.searchIcon.MouseLeave += new System.EventHandler(this.searchIcon_MouseLeave);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(40, 10);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(58, 19);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Поиск";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            this.searchLabel.MouseEnter += new System.EventHandler(this.searchLabel_MouseEnter);
            this.searchLabel.MouseLeave += new System.EventHandler(this.searchLabel_MouseLeave);
            // 
            // mainBtn
            // 
            this.mainBtn.AutoSize = true;
            this.mainBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainBtn.Controls.Add(this.mainIcon);
            this.mainBtn.Controls.Add(this.mainLabel);
            this.mainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainBtn.ForeColor = System.Drawing.Color.Gray;
            this.mainBtn.Location = new System.Drawing.Point(30, 30);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(117, 38);
            this.mainBtn.TabIndex = 1;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            this.mainBtn.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.mainBtn.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
            // 
            // mainIcon
            // 
            this.mainIcon.Image = global::MediaService.Properties.Resources.homeIcon;
            this.mainIcon.Location = new System.Drawing.Point(3, 3);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(32, 32);
            this.mainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainIcon.TabIndex = 0;
            this.mainIcon.TabStop = false;
            this.mainIcon.Click += new System.EventHandler(this.mainIcon_Click);
            this.mainIcon.MouseEnter += new System.EventHandler(this.mainIcon_MouseEnter);
            this.mainIcon.MouseLeave += new System.EventHandler(this.mainIcon_MouseLeave);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(40, 10);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(74, 19);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Главная";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            this.mainLabel.MouseEnter += new System.EventHandler(this.mainLabel_MouseEnter);
            this.mainLabel.MouseLeave += new System.EventHandler(this.mainLabel_MouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1280, 40);
            this.headerPanel.TabIndex = 7;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::MediaService.Properties.Resources.minimizeBtn;
            this.minimizeBtn.Location = new System.Drawing.Point(1222, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(1248, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.songName);
            this.panel2.Controls.Add(this.pauseBtn);
            this.panel2.Controls.Add(this.playBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 50);
            this.panel2.TabIndex = 10;
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songName.ForeColor = System.Drawing.Color.White;
            this.songName.Location = new System.Drawing.Point(380, 14);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(0, 22);
            this.songName.TabIndex = 2;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Image = global::MediaService.Properties.Resources.pauseIcon;
            this.pauseBtn.Location = new System.Drawing.Point(340, 10);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(30, 30);
            this.pauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.TabStop = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.playBtn.Image = global::MediaService.Properties.Resources.playIcon;
            this.playBtn.Location = new System.Drawing.Point(300, 10);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(30, 30);
            this.playBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playBtn.TabIndex = 0;
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainPanel.Controls.Add(this.songs);
            this.mainPanel.Controls.Add(this.userName);
            this.mainPanel.Controls.Add(this.playlistName);
            this.mainPanel.Controls.Add(this.playlistCover);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(250, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1030, 630);
            this.mainPanel.TabIndex = 9;
            // 
            // songs
            // 
            this.songs.ColumnCount = 6;
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.songs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.songs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songs.ForeColor = System.Drawing.Color.White;
            this.songs.Location = new System.Drawing.Point(15, 290);
            this.songs.Name = "songs";
            this.songs.RowCount = 1;
            this.songs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.songs.Size = new System.Drawing.Size(1000, 71);
            this.songs.TabIndex = 5;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(292, 241);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(81, 29);
            this.userName.TabIndex = 2;
            this.userName.Text = "label1";
            // 
            // playlistName
            // 
            this.playlistName.AutoSize = true;
            this.playlistName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistName.ForeColor = System.Drawing.Color.White;
            this.playlistName.Location = new System.Drawing.Point(290, 184);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(110, 37);
            this.playlistName.TabIndex = 1;
            this.playlistName.Text = "label1";
            // 
            // playlistCover
            // 
            this.playlistCover.Location = new System.Drawing.Point(20, 20);
            this.playlistCover.Name = "playlistCover";
            this.playlistCover.Size = new System.Drawing.Size(250, 250);
            this.playlistCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playlistCover.TabIndex = 0;
            this.playlistCover.TabStop = false;
            // 
            // ViewPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPlaylistForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.uploadBtn.ResumeLayout(false);
            this.uploadBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadIcon)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            this.profileBtn.ResumeLayout(false);
            this.profileBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.libraryPanel.ResumeLayout(false);
            this.libraryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryIcon)).EndInit();
            this.searchBtn.ResumeLayout(false);
            this.searchBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.mainBtn.ResumeLayout(false);
            this.mainBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel uploadBtn;
        private System.Windows.Forms.PictureBox uploadIcon;
        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.PictureBox settingsIcon;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel profileBtn;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel libraryPanel;
        private System.Windows.Forms.PictureBox libraryIcon;
        private System.Windows.Forms.Label libraryLabel;
        private System.Windows.Forms.Panel searchBtn;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel mainBtn;
        private System.Windows.Forms.PictureBox mainIcon;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.PictureBox pauseBtn;
        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel songs;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label playlistName;
        private System.Windows.Forms.PictureBox playlistCover;
    }
}