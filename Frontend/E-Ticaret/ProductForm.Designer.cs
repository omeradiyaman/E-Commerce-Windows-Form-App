namespace E_Ticaret
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panelCategoryBackground = new System.Windows.Forms.Panel();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.panelCategoryTopBar = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureDeleteProduct = new DevExpress.XtraEditors.PictureEdit();
            this.pictureUpdateProduct = new DevExpress.XtraEditors.PictureEdit();
            this.pictureAddProduct = new DevExpress.XtraEditors.PictureEdit();
            this.productList = new DevExpress.XtraEditors.PictureEdit();
            this.panelCategoryBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panelCategoryTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCategoryBackground
            // 
            this.panelCategoryBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategoryBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelCategoryBackground.Controls.Add(this.dataGridProduct);
            this.panelCategoryBackground.Controls.Add(this.panelCategoryTopBar);
            this.panelCategoryBackground.Location = new System.Drawing.Point(130, 104);
            this.panelCategoryBackground.Name = "panelCategoryBackground";
            this.panelCategoryBackground.Size = new System.Drawing.Size(1652, 851);
            this.panelCategoryBackground.TabIndex = 1;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToOrderColumns = true;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.ColumnHeadersHeight = 50;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduct.Location = new System.Drawing.Point(35, 126);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProduct.RowTemplate.Height = 50;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(1583, 683);
            this.dataGridProduct.TabIndex = 1;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // panelCategoryTopBar
            // 
            this.panelCategoryTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategoryTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCategoryTopBar.Controls.Add(this.pictureDeleteProduct);
            this.panelCategoryTopBar.Controls.Add(this.pictureUpdateProduct);
            this.panelCategoryTopBar.Controls.Add(this.pictureAddProduct);
            this.panelCategoryTopBar.Controls.Add(this.productList);
            this.panelCategoryTopBar.Location = new System.Drawing.Point(35, 37);
            this.panelCategoryTopBar.Name = "panelCategoryTopBar";
            this.panelCategoryTopBar.Size = new System.Drawing.Size(1583, 268);
            this.panelCategoryTopBar.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.LightGray;
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilter.Location = new System.Drawing.Point(572, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(769, 38);
            this.txtFilter.TabIndex = 102;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.LightGray;
            this.filterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("filterBox.ErrorImage")));
            this.filterBox.Image = global::E_Ticaret.Properties.Resources.search;
            this.filterBox.Location = new System.Drawing.Point(1300, 34);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(31, 33);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterBox.TabIndex = 101;
            this.filterBox.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 20;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // pictureDeleteProduct
            // 
            this.pictureDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeleteProduct.EditValue = ((object)(resources.GetObject("pictureDeleteProduct.EditValue")));
            this.pictureDeleteProduct.Location = new System.Drawing.Point(1183, -79);
            this.pictureDeleteProduct.Margin = new System.Windows.Forms.Padding(8);
            this.pictureDeleteProduct.Name = "pictureDeleteProduct";
            this.pictureDeleteProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureDeleteProduct.Properties.Appearance.Options.UseBackColor = true;
            this.pictureDeleteProduct.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureDeleteProduct.Properties.ZoomPercent = 175D;
            this.pictureDeleteProduct.Size = new System.Drawing.Size(306, 238);
            this.pictureDeleteProduct.TabIndex = 1;
            this.pictureDeleteProduct.Click += new System.EventHandler(this.pictureDeleteProduct_Click);
            // 
            // pictureUpdateProduct
            // 
            this.pictureUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUpdateProduct.EditValue = ((object)(resources.GetObject("pictureUpdateProduct.EditValue")));
            this.pictureUpdateProduct.Location = new System.Drawing.Point(817, -79);
            this.pictureUpdateProduct.Margin = new System.Windows.Forms.Padding(6);
            this.pictureUpdateProduct.Name = "pictureUpdateProduct";
            this.pictureUpdateProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureUpdateProduct.Properties.Appearance.Options.UseBackColor = true;
            this.pictureUpdateProduct.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureUpdateProduct.Properties.ZoomPercent = 175D;
            this.pictureUpdateProduct.Size = new System.Drawing.Size(306, 238);
            this.pictureUpdateProduct.TabIndex = 1;
            this.pictureUpdateProduct.Click += new System.EventHandler(this.pictureUpdateProduct_Click);
            // 
            // pictureAddProduct
            // 
            this.pictureAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAddProduct.EditValue = ((object)(resources.GetObject("pictureAddProduct.EditValue")));
            this.pictureAddProduct.Location = new System.Drawing.Point(460, -79);
            this.pictureAddProduct.Margin = new System.Windows.Forms.Padding(5);
            this.pictureAddProduct.Name = "pictureAddProduct";
            this.pictureAddProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureAddProduct.Properties.Appearance.Options.UseBackColor = true;
            this.pictureAddProduct.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureAddProduct.Properties.ZoomPercent = 175D;
            this.pictureAddProduct.Size = new System.Drawing.Size(306, 238);
            this.pictureAddProduct.TabIndex = 1;
            this.pictureAddProduct.Click += new System.EventHandler(this.pictureAddProduct_Click);
            // 
            // productList
            // 
            this.productList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productList.EditValue = ((object)(resources.GetObject("productList.EditValue")));
            this.productList.Location = new System.Drawing.Point(101, -79);
            this.productList.Margin = new System.Windows.Forms.Padding(4);
            this.productList.Name = "productList";
            this.productList.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productList.Properties.Appearance.Options.UseBackColor = true;
            this.productList.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.productList.Properties.ZoomPercent = 175D;
            this.productList.Size = new System.Drawing.Size(306, 238);
            this.productList.TabIndex = 1;
            this.productList.Click += new System.EventHandler(this.productList_Click);
            // 
            // ProductForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panelCategoryBackground);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.delivery_box;
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün CRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panelCategoryBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panelCategoryTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCategoryBackground;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Panel panelCategoryTopBar;
        private DevExpress.XtraEditors.PictureEdit pictureDeleteProduct;
        private DevExpress.XtraEditors.PictureEdit pictureUpdateProduct;
        private DevExpress.XtraEditors.PictureEdit pictureAddProduct;
        private DevExpress.XtraEditors.PictureEdit productList;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox txtFilter;
    }
}