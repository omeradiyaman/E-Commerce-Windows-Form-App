namespace E_Ticaret
{
    partial class ProductUpdateForm
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
            this.panelCategoryAdd = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.panelCategoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCategoryAdd
            // 
            this.panelCategoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelCategoryAdd.Controls.Add(this.pictureBoxBack);
            this.panelCategoryAdd.Controls.Add(this.btnImage);
            this.panelCategoryAdd.Controls.Add(this.cmbCategoryName);
            this.panelCategoryAdd.Controls.Add(this.pictureBoxBanner);
            this.panelCategoryAdd.Controls.Add(this.label6);
            this.panelCategoryAdd.Controls.Add(this.label5);
            this.panelCategoryAdd.Controls.Add(this.label4);
            this.panelCategoryAdd.Controls.Add(this.label3);
            this.panelCategoryAdd.Controls.Add(this.label1);
            this.panelCategoryAdd.Controls.Add(this.txtProductName);
            this.panelCategoryAdd.Controls.Add(this.txtPrice);
            this.panelCategoryAdd.Controls.Add(this.txtStock);
            this.panelCategoryAdd.Controls.Add(this.txtDescription);
            this.panelCategoryAdd.Controls.Add(this.btnProductUpdate);
            this.panelCategoryAdd.Location = new System.Drawing.Point(33, 30);
            this.panelCategoryAdd.Name = "panelCategoryAdd";
            this.panelCategoryAdd.Size = new System.Drawing.Size(603, 855);
            this.panelCategoryAdd.TabIndex = 2;
            this.panelCategoryAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCategoryAdd_Paint);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(17, 15);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 21;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // btnImage
            // 
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(96, 724);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(392, 35);
            this.btnImage.TabIndex = 6;
            this.btnImage.Text = "RESİM EKLE";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(96, 463);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(392, 36);
            this.cmbCategoryName.TabIndex = 4;
            this.cmbCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Location = new System.Drawing.Point(180, 43);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(225, 142);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 3;
            this.pictureBoxBanner.TabStop = false;
            this.pictureBoxBanner.Click += new System.EventHandler(this.pictureBoxBanner_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(96, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ürün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(96, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(96, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Stok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(96, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(96, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtProductName.Location = new System.Drawing.Point(96, 223);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(392, 36);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPrice.Location = new System.Drawing.Point(96, 303);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(392, 36);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtStock.Location = new System.Drawing.Point(96, 383);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(392, 36);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDescription.Location = new System.Drawing.Point(96, 543);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(392, 146);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnProductUpdate.Appearance.Options.UseFont = true;
            this.btnProductUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductUpdate.Location = new System.Drawing.Point(96, 780);
            this.btnProductUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(392, 35);
            this.btnProductUpdate.TabIndex = 7;
            this.btnProductUpdate.Text = "ÜRÜN GÜNCELLE";
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // ProductUpdateForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 914);
            this.Controls.Add(this.panelCategoryAdd);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.product;
            this.MaximizeBox = false;
            this.Name = "ProductUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelleme";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Click);
            this.Click += new System.EventHandler(this.ProductUpdateForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            this.panelCategoryAdd.ResumeLayout(false);
            this.panelCategoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategoryAdd;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnProductUpdate;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}