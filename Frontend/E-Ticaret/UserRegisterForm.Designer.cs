namespace E_Ticaret
{
    partial class UserRegisterForm
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_Register = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxConfirmPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordHideShow = new System.Windows.Forms.PictureBox();
            this.pbRegister = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(62, 428);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(98, 18);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail Adresiniz:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(62, 514);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 18);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Şifreniz:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtMail.Location = new System.Drawing.Point(62, 460);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(468, 40);
            this.txtMail.TabIndex = 3;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(62, 546);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(468, 40);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(62, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 18);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Adınız :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtName.Location = new System.Drawing.Point(62, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(468, 40);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(62, 256);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(77, 18);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Soyadınız :";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtSurname.Location = new System.Drawing.Point(62, 288);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(468, 40);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(62, 342);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(279, 18);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Telefon Numaranız(Başında 0 Olmadan) :";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(62, 600);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(86, 18);
            this.lblConfirmPassword.TabIndex = 22;
            this.lblConfirmPassword.Text = "Şifre Onayla";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(62, 632);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(468, 40);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // btn_Register
            // 
            this.btn_Register.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(168)))));
            this.btn_Register.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Register.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.Appearance.Options.UseBackColor = true;
            this.btn_Register.Appearance.Options.UseFont = true;
            this.btn_Register.Appearance.Options.UseForeColor = true;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Location = new System.Drawing.Point(62, 705);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(468, 40);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Kayıt Ol";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 19.8F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(62, 374);
            this.txtPhoneNumber.Mask = "(000) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(468, 40);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // pictureBoxConfirmPasswordHideShow
            // 
            this.pictureBoxConfirmPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxConfirmPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConfirmPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide;
            this.pictureBoxConfirmPasswordHideShow.Location = new System.Drawing.Point(542, 636);
            this.pictureBoxConfirmPasswordHideShow.Name = "pictureBoxConfirmPasswordHideShow";
            this.pictureBoxConfirmPasswordHideShow.Size = new System.Drawing.Size(37, 30);
            this.pictureBoxConfirmPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfirmPasswordHideShow.TabIndex = 23;
            this.pictureBoxConfirmPasswordHideShow.TabStop = false;
            this.pictureBoxConfirmPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxConfirmPasswordHideShow_MouseLeave);
            this.pictureBoxConfirmPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxConfirmPasswordHideShow_MouseHover);
            // 
            // pictureBoxPasswordHideShow
            // 
            this.pictureBoxPasswordHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordHideShow.Image = global::E_Ticaret.Properties.Resources.hide2;
            this.pictureBoxPasswordHideShow.Location = new System.Drawing.Point(542, 551);
            this.pictureBoxPasswordHideShow.Name = "pictureBoxPasswordHideShow";
            this.pictureBoxPasswordHideShow.Size = new System.Drawing.Size(37, 30);
            this.pictureBoxPasswordHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordHideShow.TabIndex = 12;
            this.pictureBoxPasswordHideShow.TabStop = false;
            this.pictureBoxPasswordHideShow.MouseLeave += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseLeave);
            this.pictureBoxPasswordHideShow.MouseHover += new System.EventHandler(this.pictureBoxPasswordHideShow_MouseHover);
            // 
            // pbRegister
            // 
            this.pbRegister.Image = global::E_Ticaret.Properties.Resources.registera71;
            this.pbRegister.Location = new System.Drawing.Point(212, 12);
            this.pbRegister.Name = "pbRegister";
            this.pbRegister.Size = new System.Drawing.Size(169, 128);
            this.pbRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegister.TabIndex = 5;
            this.pbRegister.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogin.Image = global::E_Ticaret.Properties.Resources.arrowRightBlack;
            this.pictureBoxLogin.Location = new System.Drawing.Point(485, 12);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(96, 64);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 25;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            this.pictureBoxLogin.MouseEnter += new System.EventHandler(this.pictureBoxLogin_MouseEnter);
            this.pictureBoxLogin.MouseLeave += new System.EventHandler(this.pictureBoxLogin_MouseLeave);
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 782);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.pictureBoxConfirmPasswordHideShow);
            this.Controls.Add(this.pictureBoxPasswordHideShow);
            this.Controls.Add(this.pbRegister);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBoxLogin);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.registera7;
            this.MaximizeBox = false;
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserRegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserRegisterForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRegister;
        private System.Windows.Forms.PictureBox pictureBoxPasswordHideShow;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxConfirmPasswordHideShow;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btn_Register;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
    }
}