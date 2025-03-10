namespace E_Ticaret
{
    partial class CreditCardActivateForm
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
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.txtActivationCode = new System.Windows.Forms.MaskedTextBox();
            this.lblActivationCode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.Appearance.Options.UseBackColor = true;
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Location = new System.Drawing.Point(86, 314);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(339, 44);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Onayla";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtActivationCode
            // 
            this.txtActivationCode.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtActivationCode.Location = new System.Drawing.Point(86, 249);
            this.txtActivationCode.Mask = "000000";
            this.txtActivationCode.Name = "txtActivationCode";
            this.txtActivationCode.Size = new System.Drawing.Size(339, 38);
            this.txtActivationCode.TabIndex = 10;
            this.txtActivationCode.ValidatingType = typeof(int);
            this.txtActivationCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivationCode_KeyDown);
            // 
            // lblActivationCode
            // 
            this.lblActivationCode.AutoSize = true;
            this.lblActivationCode.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblActivationCode.ForeColor = System.Drawing.Color.White;
            this.lblActivationCode.Location = new System.Drawing.Point(86, 204);
            this.lblActivationCode.Name = "lblActivationCode";
            this.lblActivationCode.Size = new System.Drawing.Size(126, 18);
            this.lblActivationCode.TabIndex = 9;
            this.lblActivationCode.Text = "Aktivasyon Kodu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Ticaret.Properties.Resources.creditCardIcon;
            this.pictureBox1.Location = new System.Drawing.Point(161, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 23;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // CreditCardActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 389);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtActivationCode);
            this.Controls.Add(this.lblActivationCode);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.creditCardTopIcon;
            this.Name = "CreditCardActivateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditCartActivateForm";
            this.Load += new System.EventHandler(this.CreditCardActivateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private System.Windows.Forms.MaskedTextBox txtActivationCode;
        private System.Windows.Forms.Label lblActivationCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}