namespace E_Ticaret
{
    partial class ActivateEmailForm
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
            this.btnAcceptActivationCode = new DevExpress.XtraEditors.SimpleButton();
            this.lblActivationCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtActivateCode = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceptActivationCode
            // 
            this.btnAcceptActivationCode.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnAcceptActivationCode.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAcceptActivationCode.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAcceptActivationCode.Appearance.Options.UseBackColor = true;
            this.btnAcceptActivationCode.Appearance.Options.UseFont = true;
            this.btnAcceptActivationCode.Appearance.Options.UseForeColor = true;
            this.btnAcceptActivationCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptActivationCode.Location = new System.Drawing.Point(66, 372);
            this.btnAcceptActivationCode.Name = "btnAcceptActivationCode";
            this.btnAcceptActivationCode.Size = new System.Drawing.Size(380, 45);
            this.btnAcceptActivationCode.TabIndex = 1;
            this.btnAcceptActivationCode.Text = "Doğrula";
            this.btnAcceptActivationCode.Click += new System.EventHandler(this.btnAcceptActivationCode_Click);
            // 
            // lblActivationCode
            // 
            this.lblActivationCode.AutoSize = true;
            this.lblActivationCode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblActivationCode.ForeColor = System.Drawing.Color.White;
            this.lblActivationCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblActivationCode.Location = new System.Drawing.Point(66, 273);
            this.lblActivationCode.Name = "lblActivationCode";
            this.lblActivationCode.Size = new System.Drawing.Size(146, 23);
            this.lblActivationCode.TabIndex = 11;
            this.lblActivationCode.Text = "Aktivasyon Kodu";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(66, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 23);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtEmail.Location = new System.Drawing.Point(66, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(380, 34);
            this.txtEmail.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Ticaret.Properties.Resources.activateUser1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtActivateCode
            // 
            this.txtActivateCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtActivateCode.Location = new System.Drawing.Point(66, 317);
            this.txtActivateCode.Mask = "000000";
            this.txtActivateCode.Name = "txtActivateCode";
            this.txtActivateCode.Size = new System.Drawing.Size(380, 34);
            this.txtActivateCode.TabIndex = 0;
            this.txtActivateCode.ValidatingType = typeof(int);
            this.txtActivateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivateCode_KeyDown);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 19;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // ActivateEmailForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 453);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.txtActivateCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcceptActivationCode);
            this.Controls.Add(this.lblActivationCode);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.activateUser2;
            this.MaximizeBox = false;
            this.Name = "ActivateEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail Aktifleştirme";
            this.Load += new System.EventHandler(this.ActivateEmailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAcceptActivationCode;
        private System.Windows.Forms.Label lblActivationCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtActivateCode;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}