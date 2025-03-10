namespace E_Ticaret
{
    partial class OrderStatusUpdateForm
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
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.btnUpdateOrderStatus = new DevExpress.XtraEditors.SimpleButton();
            this.pbOrder = new System.Windows.Forms.PictureBox();
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblOrderStatus.ForeColor = System.Drawing.Color.Transparent;
            this.lblOrderStatus.Location = new System.Drawing.Point(124, 265);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(105, 18);
            this.lblOrderStatus.TabIndex = 5;
            this.lblOrderStatus.Text = "Sipariş Durumu";
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdateOrderStatus.Appearance.Options.UseFont = true;
            this.btnUpdateOrderStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(124, 376);
            this.btnUpdateOrderStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(332, 45);
            this.btnUpdateOrderStatus.TabIndex = 1;
            this.btnUpdateOrderStatus.Text = "Sipariş Durumunu Güncelle";
            this.btnUpdateOrderStatus.Click += new System.EventHandler(this.btnUpdateOrderStatus_Click);
            // 
            // pbOrder
            // 
            this.pbOrder.Image = global::E_Ticaret.Properties.Resources.cargo;
            this.pbOrder.Location = new System.Drawing.Point(143, 52);
            this.pbOrder.Name = "pbOrder";
            this.pbOrder.Size = new System.Drawing.Size(288, 177);
            this.pbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrder.TabIndex = 8;
            this.pbOrder.TabStop = false;
            // 
            // cmbOrders
            // 
            this.cmbOrders.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(124, 312);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(332, 36);
            this.cmbOrders.TabIndex = 0;
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
            // OrderStatusUpdateForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 449);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.cmbOrders);
            this.Controls.Add(this.pbOrder);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.btnUpdateOrderStatus);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.orderStatus1;
            this.MaximizeBox = false;
            this.Name = "OrderStatusUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Durumu Güncelleme";
            this.Load += new System.EventHandler(this.OrderStatusUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderStatus;
        private DevExpress.XtraEditors.SimpleButton btnUpdateOrderStatus;
        private System.Windows.Forms.PictureBox pbOrder;
        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}