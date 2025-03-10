namespace E_Ticaret
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.panelCategoryBackground = new System.Windows.Forms.Panel();
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.panelCategoryTopBar = new System.Windows.Forms.Panel();
            this.pictureDeleteCategory = new DevExpress.XtraEditors.PictureEdit();
            this.pictureUpdateCategory = new DevExpress.XtraEditors.PictureEdit();
            this.pictureAddCategory = new DevExpress.XtraEditors.PictureEdit();
            this.pictureCategoryList = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panelCategoryBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.panelCategoryTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategoryList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCategoryBackground
            // 
            this.panelCategoryBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelCategoryBackground.Controls.Add(this.dataGridCategory);
            this.panelCategoryBackground.Controls.Add(this.panelCategoryTopBar);
            this.panelCategoryBackground.Location = new System.Drawing.Point(99, 99);
            this.panelCategoryBackground.Name = "panelCategoryBackground";
            this.panelCategoryBackground.Size = new System.Drawing.Size(1652, 846);
            this.panelCategoryBackground.TabIndex = 0;
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.AllowUserToAddRows = false;
            this.dataGridCategory.AllowUserToDeleteRows = false;
            this.dataGridCategory.AllowUserToOrderColumns = true;
            this.dataGridCategory.AllowUserToResizeColumns = false;
            this.dataGridCategory.AllowUserToResizeRows = false;
            this.dataGridCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCategory.ColumnHeadersHeight = 50;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCategory.Location = new System.Drawing.Point(33, 126);
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.ReadOnly = true;
            this.dataGridCategory.RowHeadersWidth = 51;
            this.dataGridCategory.RowTemplate.Height = 50;
            this.dataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategory.Size = new System.Drawing.Size(1583, 687);
            this.dataGridCategory.TabIndex = 1;
            // 
            // panelCategoryTopBar
            // 
            this.panelCategoryTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategoryTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCategoryTopBar.Controls.Add(this.pictureDeleteCategory);
            this.panelCategoryTopBar.Controls.Add(this.pictureUpdateCategory);
            this.panelCategoryTopBar.Controls.Add(this.pictureAddCategory);
            this.panelCategoryTopBar.Controls.Add(this.pictureCategoryList);
            this.panelCategoryTopBar.Location = new System.Drawing.Point(34, 37);
            this.panelCategoryTopBar.Name = "panelCategoryTopBar";
            this.panelCategoryTopBar.Size = new System.Drawing.Size(1583, 263);
            this.panelCategoryTopBar.TabIndex = 0;
            // 
            // pictureDeleteCategory
            // 
            this.pictureDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeleteCategory.EditValue = ((object)(resources.GetObject("pictureDeleteCategory.EditValue")));
            this.pictureDeleteCategory.Location = new System.Drawing.Point(1275, -79);
            this.pictureDeleteCategory.Margin = new System.Windows.Forms.Padding(8);
            this.pictureDeleteCategory.Name = "pictureDeleteCategory";
            this.pictureDeleteCategory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureDeleteCategory.Properties.Appearance.Options.UseBackColor = true;
            this.pictureDeleteCategory.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureDeleteCategory.Properties.ZoomPercent = 175D;
            this.pictureDeleteCategory.Size = new System.Drawing.Size(306, 238);
            this.pictureDeleteCategory.TabIndex = 1;
            this.pictureDeleteCategory.Click += new System.EventHandler(this.pictureDeleteCategory_Click);
            // 
            // pictureUpdateCategory
            // 
            this.pictureUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUpdateCategory.EditValue = ((object)(resources.GetObject("pictureUpdateCategory.EditValue")));
            this.pictureUpdateCategory.Location = new System.Drawing.Point(895, -79);
            this.pictureUpdateCategory.Margin = new System.Windows.Forms.Padding(6);
            this.pictureUpdateCategory.Name = "pictureUpdateCategory";
            this.pictureUpdateCategory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureUpdateCategory.Properties.Appearance.Options.UseBackColor = true;
            this.pictureUpdateCategory.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureUpdateCategory.Properties.ZoomPercent = 175D;
            this.pictureUpdateCategory.Size = new System.Drawing.Size(306, 238);
            this.pictureUpdateCategory.TabIndex = 1;
            this.pictureUpdateCategory.Click += new System.EventHandler(this.pictureUpdateCategory_Click);
            // 
            // pictureAddCategory
            // 
            this.pictureAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAddCategory.EditValue = ((object)(resources.GetObject("pictureAddCategory.EditValue")));
            this.pictureAddCategory.Location = new System.Drawing.Point(379, -79);
            this.pictureAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.pictureAddCategory.Name = "pictureAddCategory";
            this.pictureAddCategory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureAddCategory.Properties.Appearance.Options.UseBackColor = true;
            this.pictureAddCategory.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureAddCategory.Properties.ZoomPercent = 175D;
            this.pictureAddCategory.Size = new System.Drawing.Size(306, 238);
            this.pictureAddCategory.TabIndex = 1;
            this.pictureAddCategory.Click += new System.EventHandler(this.pictureAddCategory_Click);
            // 
            // pictureCategoryList
            // 
            this.pictureCategoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCategoryList.EditValue = ((object)(resources.GetObject("pictureCategoryList.EditValue")));
            this.pictureCategoryList.Location = new System.Drawing.Point(2, -79);
            this.pictureCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.pictureCategoryList.Name = "pictureCategoryList";
            this.pictureCategoryList.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureCategoryList.Properties.Appearance.Options.UseBackColor = true;
            this.pictureCategoryList.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureCategoryList.Properties.ZoomPercent = 175D;
            this.pictureCategoryList.Size = new System.Drawing.Size(306, 238);
            this.pictureCategoryList.TabIndex = 1;
            this.pictureCategoryList.Click += new System.EventHandler(this.pictureCategoryList_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(2, 3);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 19;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // CategoryForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panelCategoryBackground);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.category__1_;
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori CRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panelCategoryBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.panelCategoryTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategoryList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategoryBackground;
        private System.Windows.Forms.Panel panelCategoryTopBar;
        private System.Windows.Forms.DataGridView dataGridCategory;
        private DevExpress.XtraEditors.PictureEdit pictureDeleteCategory;
        private DevExpress.XtraEditors.PictureEdit pictureUpdateCategory;
        private DevExpress.XtraEditors.PictureEdit pictureAddCategory;
        private DevExpress.XtraEditors.PictureEdit pictureCategoryList;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}