
namespace MediaService
{
    partial class AuthorizationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toRegFormBtn = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
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
            this.headerPanel.TabIndex = 0;
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
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.toRegFormBtn);
            this.mainPanel.Controls.Add(this.authBtn);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(360, 600);
            this.mainPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите ваш пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите ваш логин";
            // 
            // toRegFormBtn
            // 
            this.toRegFormBtn.AutoSize = true;
            this.toRegFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toRegFormBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRegFormBtn.ForeColor = System.Drawing.Color.Gray;
            this.toRegFormBtn.Location = new System.Drawing.Point(86, 500);
            this.toRegFormBtn.Name = "toRegFormBtn";
            this.toRegFormBtn.Size = new System.Drawing.Size(187, 22);
            this.toRegFormBtn.TabIndex = 5;
            this.toRegFormBtn.Text = "Ещё нет аккаунта?";
            this.toRegFormBtn.Click += new System.EventHandler(this.toRegFormBtn_Click);
            this.toRegFormBtn.MouseEnter += new System.EventHandler(this.toRegFormBtn_MouseEnter);
            this.toRegFormBtn.MouseLeave += new System.EventHandler(this.toRegFormBtn_MouseLeave);
            // 
            // authBtn
            // 
            this.authBtn.AutoSize = true;
            this.authBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(10)))));
            this.authBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBtn.FlatAppearance.BorderSize = 0;
            this.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBtn.ForeColor = System.Drawing.Color.White;
            this.authBtn.Location = new System.Drawing.Point(140, 459);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(79, 32);
            this.authBtn.TabIndex = 4;
            this.authBtn.Text = "Войти";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(50, 333);
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
            this.loginField.Location = new System.Drawing.Point(50, 275);
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
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label toRegFormBtn;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}