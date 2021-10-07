
namespace MediaService
{
    partial class RegistrationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regArtBtn = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.toAuthFormBtn = new System.Windows.Forms.Label();
            this.regUsrBtn = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
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
            this.headerPanel.Size = new System.Drawing.Size(360, 40);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::MediaService.Properties.Resources.minimizeBtn;
            this.minimizeBtn.Location = new System.Drawing.Point(302, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(328, 12);
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
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.regArtBtn);
            this.mainPanel.Controls.Add(this.nameField);
            this.mainPanel.Controls.Add(this.toAuthFormBtn);
            this.mainPanel.Controls.Add(this.regUsrBtn);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(360, 680);
            this.mainPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Придумайте пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Придумайте логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите ваше имя";
            // 
            // regArtBtn
            // 
            this.regArtBtn.AutoSize = true;
            this.regArtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.regArtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regArtBtn.FlatAppearance.BorderSize = 0;
            this.regArtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regArtBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regArtBtn.ForeColor = System.Drawing.Color.White;
            this.regArtBtn.Location = new System.Drawing.Point(17, 559);
            this.regArtBtn.Name = "regArtBtn";
            this.regArtBtn.Size = new System.Drawing.Size(325, 32);
            this.regArtBtn.TabIndex = 7;
            this.regArtBtn.Text = "Зарегистрироваться как артист";
            this.regArtBtn.UseVisualStyleBackColor = false;
            this.regArtBtn.Click += new System.EventHandler(this.regArtBtn_Click);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(50, 224);
            this.nameField.MaxLength = 50;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(260, 29);
            this.nameField.TabIndex = 1;
            // 
            // toAuthFormBtn
            // 
            this.toAuthFormBtn.AutoSize = true;
            this.toAuthFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toAuthFormBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toAuthFormBtn.ForeColor = System.Drawing.Color.Gray;
            this.toAuthFormBtn.Location = new System.Drawing.Point(88, 600);
            this.toAuthFormBtn.Name = "toAuthFormBtn";
            this.toAuthFormBtn.Size = new System.Drawing.Size(184, 22);
            this.toAuthFormBtn.TabIndex = 5;
            this.toAuthFormBtn.Text = "Уже есть аккаунт?";
            this.toAuthFormBtn.Click += new System.EventHandler(this.toAuthFormBtn_Click);
            this.toAuthFormBtn.MouseEnter += new System.EventHandler(this.toAuthFormBtn_MouseEnter);
            this.toAuthFormBtn.MouseLeave += new System.EventHandler(this.toAuthFormBtn_MouseLeave);
            // 
            // regUsrBtn
            // 
            this.regUsrBtn.AutoSize = true;
            this.regUsrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.regUsrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regUsrBtn.FlatAppearance.BorderSize = 0;
            this.regUsrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regUsrBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regUsrBtn.ForeColor = System.Drawing.Color.White;
            this.regUsrBtn.Location = new System.Drawing.Point(70, 508);
            this.regUsrBtn.Name = "regUsrBtn";
            this.regUsrBtn.Size = new System.Drawing.Size(220, 32);
            this.regUsrBtn.TabIndex = 4;
            this.regUsrBtn.Text = "Зарегистрироваться";
            this.regUsrBtn.UseVisualStyleBackColor = false;
            this.regUsrBtn.Click += new System.EventHandler(this.regUsrBtn_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(50, 340);
            this.passField.MaxLength = 18;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(260, 29);
            this.passField.TabIndex = 3;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.loginField.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(50, 282);
            this.loginField.MaxLength = 50;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(260, 29);
            this.loginField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
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
        private System.Windows.Forms.Label toAuthFormBtn;
        private System.Windows.Forms.Button regUsrBtn;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button regArtBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}