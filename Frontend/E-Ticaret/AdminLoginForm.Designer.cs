namespace E_Ticaret
{
    partial class AdminLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AdminLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mail Adresiniz:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(42, 310);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 18);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Şifreniz:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtMail.Location = new System.Drawing.Point(45, 257);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(472, 40);
            this.txtMail.TabIndex = 1;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMail_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(45, 342);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(472, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(686, 1189);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(15);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(0, 0);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Giriş Yap";
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(139)))), ((int)(((byte)(2)))));
            this.btn_AdminLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_AdminLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_AdminLogin.Appearance.Options.UseBackColor = true;
            this.btn_AdminLogin.Appearance.Options.UseFont = true;
            this.btn_AdminLogin.Appearance.Options.UseForeColor = true;
            this.btn_AdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdminLogin.Location = new System.Drawing.Point(45, 426);
            this.btn_AdminLogin.Margin = new System.Windows.Forms.Padding(12);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(472, 40);
            this.btn_AdminLogin.TabIndex = 3;
            this.btn_AdminLogin.Text = "Giriş Yap";
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(168)))));
            this.lblResetPassword.Location = new System.Drawing.Point(444, 396);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(100, 16);
            this.lblResetPassword.TabIndex = 5;
            this.lblResetPassword.Text = "Şifremi Unuttum";
            this.lblResetPassword.Click += new System.EventHandler(this.lblResetPassword_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(45, 484);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(472, 40);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 18;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // pictureBoxPasswordHideShow
            // 
            this.pictureBoxPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide;
            this.pictureBoxPasswordHideShow.Location = new System.Drawing.Point(526, 347);
            this.pictureBoxPasswordHideShow.Name = "pictureBoxPasswordHideShow";
            this.pictureBoxPasswordHideShow.Size = new System.Drawing.Size(34, 30);
            this.pictureBoxPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordHideShow.TabIndex = 17;
            this.pictureBoxPasswordHideShow.TabStop = false;
            this.pictureBoxPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseLeave);
            this.pictureBoxPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseHover);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::E_Ticaret.Properties.Resources.user__1_1;
            this.pbUser.Location = new System.Drawing.Point(193, 50);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(176, 149);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 15;
            this.pbUser.TabStop = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 555);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxPasswordHideShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.pbUser);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.user1;
            this.MaximizeBox = false;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLoginForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPasswordHideShow;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_AdminLogin;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label lblResetPassword;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
    }
}