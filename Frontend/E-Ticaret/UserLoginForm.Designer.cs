namespace E_Ticaret
{
    partial class UserLoginForm
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
            this.btn_CustomerLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblForgetPw = new System.Windows.Forms.Label();
            this.btn_Register = new DevExpress.XtraEditors.SimpleButton();
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.pictureBoxPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CustomerLogin
            // 
            this.btn_CustomerLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(145)))), ((int)(((byte)(63)))));
            this.btn_CustomerLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_CustomerLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_CustomerLogin.Appearance.Options.UseBackColor = true;
            this.btn_CustomerLogin.Appearance.Options.UseFont = true;
            this.btn_CustomerLogin.Appearance.Options.UseForeColor = true;
            this.btn_CustomerLogin.Location = new System.Drawing.Point(35, 437);
            this.btn_CustomerLogin.Margin = new System.Windows.Forms.Padding(8);
            this.btn_CustomerLogin.Name = "btn_CustomerLogin";
            this.btn_CustomerLogin.Size = new System.Drawing.Size(501, 40);
            this.btn_CustomerLogin.TabIndex = 2;
            this.btn_CustomerLogin.Text = "Giriş Yap";
            this.btn_CustomerLogin.Click += new System.EventHandler(this.btn_CustomerLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(32, 348);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(451, 40);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPw.ForeColor = System.Drawing.Color.White;
            this.lblPw.Location = new System.Drawing.Point(32, 308);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(58, 18);
            this.lblPw.TabIndex = 100;
            this.lblPw.Text = "Şifreniz:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtMail.Location = new System.Drawing.Point(32, 246);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(504, 40);
            this.txtMail.TabIndex = 0;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(32, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 18);
            this.lblEmail.TabIndex = 100;
            this.lblEmail.Text = "Mail Adresiniz:";
            // 
            // lblForgetPw
            // 
            this.lblForgetPw.AutoSize = true;
            this.lblForgetPw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(168)))));
            this.lblForgetPw.Location = new System.Drawing.Point(429, 401);
            this.lblForgetPw.Name = "lblForgetPw";
            this.lblForgetPw.Size = new System.Drawing.Size(100, 16);
            this.lblForgetPw.TabIndex = 5;
            this.lblForgetPw.Text = "Şifremi Unuttum";
            this.lblForgetPw.Click += new System.EventHandler(this.lblForgetPw_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(168)))));
            this.btn_Register.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_Register.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.Appearance.Options.UseBackColor = true;
            this.btn_Register.Appearance.Options.UseFont = true;
            this.btn_Register.Appearance.Options.UseForeColor = true;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Location = new System.Drawing.Point(35, 497);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(501, 40);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Kayıt Ol";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAdminLogin.ForeColor = System.Drawing.Color.Orange;
            this.labelAdminLogin.Location = new System.Drawing.Point(204, 557);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(163, 16);
            this.labelAdminLogin.TabIndex = 4;
            this.labelAdminLogin.Text = "Yönetici Girişi İçin Tıklayınız";
            this.labelAdminLogin.Click += new System.EventHandler(this.labelAdminLogin_Click);
            // 
            // pictureBoxPasswordHideShow
            // 
            this.pictureBoxPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide1;
            this.pictureBoxPasswordHideShow.Location = new System.Drawing.Point(499, 353);
            this.pictureBoxPasswordHideShow.Name = "pictureBoxPasswordHideShow";
            this.pictureBoxPasswordHideShow.Size = new System.Drawing.Size(37, 30);
            this.pictureBoxPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordHideShow.TabIndex = 6;
            this.pictureBoxPasswordHideShow.TabStop = false;
            this.pictureBoxPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseLeave);
            this.pictureBoxPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseHover);
            // 
            // pbLogin
            // 
            this.pbLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbLogin.Image = global::E_Ticaret.Properties.Resources.security1;
            this.pbLogin.Location = new System.Drawing.Point(196, 28);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(176, 149);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 4;
            this.pbLogin.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 593);
            this.Controls.Add(this.pictureBoxPasswordHideShow);
            this.Controls.Add(this.labelAdminLogin);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblForgetPw);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_CustomerLogin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.login1;
            this.MaximizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserLoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_CustomerLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblForgetPw;
        private DevExpress.XtraEditors.SimpleButton btn_Register;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.PictureBox pictureBoxPasswordHideShow;
    }
}