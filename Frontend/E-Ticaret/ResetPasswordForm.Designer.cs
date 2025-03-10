namespace E_Ticaret
{
    partial class ResetPasswordForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtResetCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new DevExpress.XtraEditors.SimpleButton();
            this.lblActivationCode = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnAcceptResetCode = new DevExpress.XtraEditors.SimpleButton();
            this.pbResetPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfirmPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(80, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtEmail.Location = new System.Drawing.Point(80, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 34);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSendCode.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSendCode.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Appearance.Options.UseBackColor = true;
            this.btnSendCode.Appearance.Options.UseFont = true;
            this.btnSendCode.Appearance.Options.UseForeColor = true;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Location = new System.Drawing.Point(80, 229);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(380, 45);
            this.btnSendCode.TabIndex = 1;
            this.btnSendCode.Text = "Kod Gönder";
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtResetCode
            // 
            this.txtResetCode.BackColor = System.Drawing.Color.White;
            this.txtResetCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtResetCode.Location = new System.Drawing.Point(80, 337);
            this.txtResetCode.Name = "txtResetCode";
            this.txtResetCode.Size = new System.Drawing.Size(380, 34);
            this.txtResetCode.TabIndex = 2;
            this.txtResetCode.Visible = false;
            this.txtResetCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResetCode_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtPassword.Location = new System.Drawing.Point(80, 499);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 34);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Visible = false;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(80, 596);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 34);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Visible = false;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnUpdatePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnUpdatePassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Appearance.Options.UseBackColor = true;
            this.btnUpdatePassword.Appearance.Options.UseFont = true;
            this.btnUpdatePassword.Appearance.Options.UseForeColor = true;
            this.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePassword.Location = new System.Drawing.Point(80, 650);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(380, 45);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.Text = "Şifre Değiştir";
            this.btnUpdatePassword.Visible = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblActivationCode
            // 
            this.lblActivationCode.AutoSize = true;
            this.lblActivationCode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblActivationCode.ForeColor = System.Drawing.Color.White;
            this.lblActivationCode.Location = new System.Drawing.Point(80, 294);
            this.lblActivationCode.Name = "lblActivationCode";
            this.lblActivationCode.Size = new System.Drawing.Size(146, 23);
            this.lblActivationCode.TabIndex = 6;
            this.lblActivationCode.Text = "Aktivasyon Kodu";
            this.lblActivationCode.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(80, 456);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Yeni Şifre";
            this.lblPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(80, 553);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(124, 23);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Şifreyi Onayla";
            this.lblConfirmPassword.Visible = false;
            // 
            // btnAcceptResetCode
            // 
            this.btnAcceptResetCode.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnAcceptResetCode.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAcceptResetCode.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAcceptResetCode.Appearance.Options.UseBackColor = true;
            this.btnAcceptResetCode.Appearance.Options.UseFont = true;
            this.btnAcceptResetCode.Appearance.Options.UseForeColor = true;
            this.btnAcceptResetCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptResetCode.Location = new System.Drawing.Point(80, 391);
            this.btnAcceptResetCode.Name = "btnAcceptResetCode";
            this.btnAcceptResetCode.Size = new System.Drawing.Size(380, 45);
            this.btnAcceptResetCode.TabIndex = 9;
            this.btnAcceptResetCode.Text = "Doğrula";
            this.btnAcceptResetCode.Visible = false;
            this.btnAcceptResetCode.Click += new System.EventHandler(this.btnAcceptResetCode_Click);
            // 
            // pbResetPassword
            // 
            this.pbResetPassword.Image = global::E_Ticaret.Properties.Resources.reset_password__1_;
            this.pbResetPassword.Location = new System.Drawing.Point(179, 29);
            this.pbResetPassword.Name = "pbResetPassword";
            this.pbResetPassword.Size = new System.Drawing.Size(182, 96);
            this.pbResetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResetPassword.TabIndex = 27;
            this.pbResetPassword.TabStop = false;
            // 
            // pictureBoxConfirmPasswordHideShow
            // 
            this.pictureBoxConfirmPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxConfirmPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConfirmPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide2;
            this.pictureBoxConfirmPasswordHideShow.Location = new System.Drawing.Point(476, 598);
            this.pictureBoxConfirmPasswordHideShow.Name = "pictureBoxConfirmPasswordHideShow";
            this.pictureBoxConfirmPasswordHideShow.Size = new System.Drawing.Size(37, 30);
            this.pictureBoxConfirmPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfirmPasswordHideShow.TabIndex = 26;
            this.pictureBoxConfirmPasswordHideShow.TabStop = false;
            this.pictureBoxConfirmPasswordHideShow.Visible = false;
            this.pictureBoxConfirmPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxConfirmPasswordHideShow_MouseLeave);
            this.pictureBoxConfirmPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxConfirmPasswordHideShow_MouseHover);
            // 
            // pictureBoxPasswordHideShow
            // 
            this.pictureBoxPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide2;
            this.pictureBoxPasswordHideShow.Location = new System.Drawing.Point(476, 501);
            this.pictureBoxPasswordHideShow.Name = "pictureBoxPasswordHideShow";
            this.pictureBoxPasswordHideShow.Size = new System.Drawing.Size(37, 30);
            this.pictureBoxPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordHideShow.TabIndex = 24;
            this.pictureBoxPasswordHideShow.TabStop = false;
            this.pictureBoxPasswordHideShow.Visible = false;
            this.pictureBoxPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseLeave);
            this.pictureBoxPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseHover);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 28;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // ResetPasswordForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.ForeColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 721);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pbResetPassword);
            this.Controls.Add(this.pictureBoxConfirmPasswordHideShow);
            this.Controls.Add(this.pictureBoxPasswordHideShow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAcceptResetCode);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.lblActivationCode);
            this.Controls.Add(this.txtResetCode);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.reset_password;
            this.MaximizeBox = false;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordResetForm";
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnSendCode;
        private System.Windows.Forms.TextBox txtResetCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnUpdatePassword;
        private System.Windows.Forms.Label lblActivationCode;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnAcceptResetCode;
        private System.Windows.Forms.PictureBox pictureBoxPasswordHideShow;
        private System.Windows.Forms.PictureBox pictureBoxConfirmPasswordHideShow;
        private System.Windows.Forms.PictureBox pbResetPassword;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}