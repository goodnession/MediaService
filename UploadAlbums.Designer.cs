
namespace MediaService
{
    partial class UploadAlbums
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.artists = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.albumCoverImg = new System.Windows.Forms.PictureBox();
            this.addAlbumCoverBtn = new System.Windows.Forms.Button();
            this.addSongBtn = new System.Windows.Forms.Button();
            this.addAlbumBtn = new System.Windows.Forms.Button();
            this.albumCover = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
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
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1280, 40);
            this.headerPanel.TabIndex = 3;
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
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Black;
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
            this.menuPanel.TabIndex = 4;
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.artists);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.dateRelease);
            this.mainPanel.Controls.Add(this.albumCoverImg);
            this.mainPanel.Controls.Add(this.addAlbumCoverBtn);
            this.mainPanel.Controls.Add(this.addSongBtn);
            this.mainPanel.Controls.Add(this.addAlbumBtn);
            this.mainPanel.Controls.Add(this.albumCover);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.albumName);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1030, 680);
            this.mainPanel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(100, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите их логины через запятую";
            // 
            // artists
            // 
            this.artists.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.artists.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artists.Location = new System.Drawing.Point(493, 433);
            this.artists.MaxLength = 1000;
            this.artists.Name = "artists";
            this.artists.Size = new System.Drawing.Size(436, 26);
            this.artists.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Другие артисты, работавшие над альбомом";
            // 
            // dateRelease
            // 
            this.dateRelease.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dateRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateRelease.CustomFormat = "MM.dd.yyyy";
            this.dateRelease.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRelease.Location = new System.Drawing.Point(493, 213);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(222, 26);
            this.dateRelease.TabIndex = 3;
            // 
            // albumCoverImg
            // 
            this.albumCoverImg.Image = global::MediaService.Properties.Resources.defaultImg;
            this.albumCoverImg.Location = new System.Drawing.Point(730, 213);
            this.albumCoverImg.Name = "albumCoverImg";
            this.albumCoverImg.Size = new System.Drawing.Size(200, 200);
            this.albumCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumCoverImg.TabIndex = 12;
            this.albumCoverImg.TabStop = false;
            // 
            // addAlbumCoverBtn
            // 
            this.addAlbumCoverBtn.AutoSize = true;
            this.addAlbumCoverBtn.BackColor = System.Drawing.Color.Gray;
            this.addAlbumCoverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAlbumCoverBtn.FlatAppearance.BorderSize = 0;
            this.addAlbumCoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlbumCoverBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAlbumCoverBtn.ForeColor = System.Drawing.Color.White;
            this.addAlbumCoverBtn.Location = new System.Drawing.Point(791, 165);
            this.addAlbumCoverBtn.Name = "addAlbumCoverBtn";
            this.addAlbumCoverBtn.Size = new System.Drawing.Size(139, 29);
            this.addAlbumCoverBtn.TabIndex = 2;
            this.addAlbumCoverBtn.Text = "Выбрать файл";
            this.addAlbumCoverBtn.UseVisualStyleBackColor = false;
            this.addAlbumCoverBtn.Click += new System.EventHandler(this.addAlbumCoverBtn_Click);
            // 
            // addSongBtn
            // 
            this.addSongBtn.AutoSize = true;
            this.addSongBtn.BackColor = System.Drawing.Color.Gray;
            this.addSongBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongBtn.FlatAppearance.BorderSize = 0;
            this.addSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSongBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSongBtn.ForeColor = System.Drawing.Color.White;
            this.addSongBtn.Location = new System.Drawing.Point(783, 529);
            this.addSongBtn.Name = "addSongBtn";
            this.addSongBtn.Size = new System.Drawing.Size(146, 32);
            this.addSongBtn.TabIndex = 10;
            this.addSongBtn.Text = "Добавить треки";
            this.addSongBtn.UseVisualStyleBackColor = false;
            this.addSongBtn.Click += new System.EventHandler(this.addSongBtn_Click);
            // 
            // addAlbumBtn
            // 
            this.addAlbumBtn.AutoSize = true;
            this.addAlbumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.addAlbumBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAlbumBtn.FlatAppearance.BorderSize = 0;
            this.addAlbumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlbumBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAlbumBtn.ForeColor = System.Drawing.Color.White;
            this.addAlbumBtn.Location = new System.Drawing.Point(104, 529);
            this.addAlbumBtn.Name = "addAlbumBtn";
            this.addAlbumBtn.Size = new System.Drawing.Size(161, 32);
            this.addAlbumBtn.TabIndex = 5;
            this.addAlbumBtn.Text = "Добавить альбом";
            this.addAlbumBtn.UseVisualStyleBackColor = false;
            this.addAlbumBtn.Click += new System.EventHandler(this.addAlbumBtn_Click);
            // 
            // albumCover
            // 
            this.albumCover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumCover.Location = new System.Drawing.Point(493, 167);
            this.albumCover.MaxLength = 32000;
            this.albumCover.Name = "albumCover";
            this.albumCover.ReadOnly = true;
            this.albumCover.Size = new System.Drawing.Size(284, 26);
            this.albumCover.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата релиза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Обложка альбома";
            // 
            // albumName
            // 
            this.albumName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumName.Location = new System.Drawing.Point(493, 121);
            this.albumName.MaxLength = 100;
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(437, 26);
            this.albumName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название альбома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавьте свой альбом или трек";
            // 
            // UploadAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadAlbums";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
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
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCoverImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox albumName;
        private System.Windows.Forms.TextBox albumCover;
        private System.Windows.Forms.Button addSongBtn;
        private System.Windows.Forms.Button addAlbumBtn;
        private System.Windows.Forms.Button addAlbumCoverBtn;
        private System.Windows.Forms.PictureBox albumCoverImg;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox artists;
        private System.Windows.Forms.Label label5;
    }
}