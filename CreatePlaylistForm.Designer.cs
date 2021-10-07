
namespace MediaService
{
    partial class CreatePlaylistForm
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
            this.playlistCoverImg = new System.Windows.Forms.PictureBox();
            this.addPlaylistCoverBtn = new System.Windows.Forms.Button();
            this.playlistCover = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.crtPlstBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.playlistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(700, 40);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::MediaService.Properties.Resources.minimizeBtn;
            this.minimizeBtn.Location = new System.Drawing.Point(639, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(668, 12);
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
            this.mainPanel.Controls.Add(this.playlistCoverImg);
            this.mainPanel.Controls.Add(this.addPlaylistCoverBtn);
            this.mainPanel.Controls.Add(this.playlistCover);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.crtPlstBtn);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.playlistName);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 367);
            this.mainPanel.TabIndex = 3;
            // 
            // playlistCoverImg
            // 
            this.playlistCoverImg.Location = new System.Drawing.Point(463, 161);
            this.playlistCoverImg.Name = "playlistCoverImg";
            this.playlistCoverImg.Size = new System.Drawing.Size(182, 183);
            this.playlistCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playlistCoverImg.TabIndex = 28;
            this.playlistCoverImg.TabStop = false;
            // 
            // addPlaylistCoverBtn
            // 
            this.addPlaylistCoverBtn.AutoSize = true;
            this.addPlaylistCoverBtn.BackColor = System.Drawing.Color.Gray;
            this.addPlaylistCoverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlaylistCoverBtn.FlatAppearance.BorderSize = 0;
            this.addPlaylistCoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlaylistCoverBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addPlaylistCoverBtn.ForeColor = System.Drawing.Color.White;
            this.addPlaylistCoverBtn.Location = new System.Drawing.Point(544, 112);
            this.addPlaylistCoverBtn.Name = "addPlaylistCoverBtn";
            this.addPlaylistCoverBtn.Size = new System.Drawing.Size(123, 26);
            this.addPlaylistCoverBtn.TabIndex = 25;
            this.addPlaylistCoverBtn.Text = "Выбрать файл";
            this.addPlaylistCoverBtn.UseVisualStyleBackColor = false;
            this.addPlaylistCoverBtn.Click += new System.EventHandler(this.addPlaylistCoverBtn_Click);
            // 
            // playlistCover
            // 
            this.playlistCover.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.playlistCover.Location = new System.Drawing.Point(211, 114);
            this.playlistCover.MaxLength = 32000;
            this.playlistCover.Name = "playlistCover";
            this.playlistCover.ReadOnly = true;
            this.playlistCover.Size = new System.Drawing.Size(316, 23);
            this.playlistCover.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Обложка альбома";
            // 
            // crtPlstBtn
            // 
            this.crtPlstBtn.AutoSize = true;
            this.crtPlstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.crtPlstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crtPlstBtn.FlatAppearance.BorderSize = 0;
            this.crtPlstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crtPlstBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crtPlstBtn.ForeColor = System.Drawing.Color.White;
            this.crtPlstBtn.Location = new System.Drawing.Point(36, 318);
            this.crtPlstBtn.Name = "crtPlstBtn";
            this.crtPlstBtn.Size = new System.Drawing.Size(147, 26);
            this.crtPlstBtn.TabIndex = 24;
            this.crtPlstBtn.Text = "Создать плейлист";
            this.crtPlstBtn.UseVisualStyleBackColor = false;
            this.crtPlstBtn.Click += new System.EventHandler(this.crtPlstBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Название плейлиста";
            // 
            // playlistName
            // 
            this.playlistName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistName.Location = new System.Drawing.Point(211, 71);
            this.playlistName.MaxLength = 50;
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(456, 23);
            this.playlistName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создайте новый плейлист";
            // 
            // CreatePlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 407);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlaylistForm";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistCoverImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button crtPlstBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox playlistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlaylistCoverBtn;
        private System.Windows.Forms.TextBox playlistCover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox playlistCoverImg;
    }
}