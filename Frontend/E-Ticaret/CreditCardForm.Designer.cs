namespace E_Ticaret
{
    partial class CreditCardForm
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
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblCardDate = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCreditCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtCardDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCvv = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCreditCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(74, 179);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(111, 18);
            this.lblCreditCardNumber.TabIndex = 0;
            this.lblCreditCardNumber.Text = "Kart Numarası :";
            // 
            // lblCardDate
            // 
            this.lblCardDate.AutoSize = true;
            this.lblCardDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCardDate.ForeColor = System.Drawing.Color.White;
            this.lblCardDate.Location = new System.Drawing.Point(74, 281);
            this.lblCardDate.Name = "lblCardDate";
            this.lblCardDate.Size = new System.Drawing.Size(80, 18);
            this.lblCardDate.TabIndex = 2;
            this.lblCardDate.Text = "Kart Tarihi:";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCvv.ForeColor = System.Drawing.Color.White;
            this.lblCvv.Location = new System.Drawing.Point(74, 383);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(35, 18);
            this.lblCvv.TabIndex = 4;
            this.lblCvv.Text = "CVV";
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.Appearance.Options.UseBackColor = true;
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Location = new System.Drawing.Point(73, 485);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(325, 44);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Kaydet";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Ticaret.Properties.Resources.securePayment2;
            this.pictureBox1.Location = new System.Drawing.Point(115, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCreditCardNumber.Location = new System.Drawing.Point(74, 220);
            this.txtCreditCardNumber.Mask = "0000-0000-0000-0000";
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(324, 38);
            this.txtCreditCardNumber.TabIndex = 1;
            this.txtCreditCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditCardNumber_KeyDown);
            // 
            // txtCardDate
            // 
            this.txtCardDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCardDate.Location = new System.Drawing.Point(74, 322);
            this.txtCardDate.Mask = "00/00";
            this.txtCardDate.Name = "txtCardDate";
            this.txtCardDate.Size = new System.Drawing.Size(324, 38);
            this.txtCardDate.TabIndex = 2;
            this.txtCardDate.ValidatingType = typeof(System.DateTime);
            this.txtCardDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditCardNumber_KeyDown);
            // 
            // txtCvv
            // 
            this.txtCvv.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCvv.Location = new System.Drawing.Point(74, 424);
            this.txtCvv.Mask = "000";
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(324, 38);
            this.txtCvv.TabIndex = 3;
            this.txtCvv.ValidatingType = typeof(System.DateTime);
            this.txtCvv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditCardNumber_KeyDown);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 22;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 562);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtCardDate);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblCardDate);
            this.Controls.Add(this.lblCreditCardNumber);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.securePayment3;
            this.MaximizeBox = false;
            this.Name = "CreditCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditCartForm";
            this.Load += new System.EventHandler(this.CreditCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblCardDate;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private System.Windows.Forms.MaskedTextBox txtCreditCardNumber;
        private System.Windows.Forms.MaskedTextBox txtCardDate;
        private System.Windows.Forms.MaskedTextBox txtCvv;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}