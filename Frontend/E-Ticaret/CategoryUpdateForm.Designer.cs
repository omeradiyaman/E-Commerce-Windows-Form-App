namespace E_Ticaret
{
    partial class CategoryUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUpdateForm));
            this.panelCategoryAdd = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.btn_CategoryAdd = new DevExpress.XtraEditors.SimpleButton();
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
            this.panelCategoryAdd.Controls.Add(this.txtCategoryName);
            this.panelCategoryAdd.Controls.Add(this.pictureBoxBanner);
            this.panelCategoryAdd.Controls.Add(this.labelCategoryName);
            this.panelCategoryAdd.Controls.Add(this.btn_CategoryAdd);
            this.panelCategoryAdd.Location = new System.Drawing.Point(29, 32);
            this.panelCategoryAdd.Name = "panelCategoryAdd";
            this.panelCategoryAdd.Size = new System.Drawing.Size(436, 447);
            this.panelCategoryAdd.TabIndex = 1;
            this.panelCategoryAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCategoryAdd_Paint);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(16, 14);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 21;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCategoryName.Location = new System.Drawing.Point(60, 314);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(316, 35);
            this.txtCategoryName.TabIndex = 4;
            this.txtCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategoryName_KeyDown);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = global::E_Ticaret.Properties.Resources.app11;
            this.pictureBoxBanner.Location = new System.Drawing.Point(122, 42);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner.TabIndex = 3;
            this.pictureBoxBanner.TabStop = false;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelCategoryName.Location = new System.Drawing.Point(57, 276);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(90, 18);
            this.labelCategoryName.TabIndex = 2;
            this.labelCategoryName.Text = "Kategori Adı:";
            // 
            // btn_CategoryAdd
            // 
            this.btn_CategoryAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_CategoryAdd.Appearance.Options.UseFont = true;
            this.btn_CategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CategoryAdd.Location = new System.Drawing.Point(57, 371);
            this.btn_CategoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CategoryAdd.Name = "btn_CategoryAdd";
            this.btn_CategoryAdd.Size = new System.Drawing.Size(320, 35);
            this.btn_CategoryAdd.TabIndex = 2;
            this.btn_CategoryAdd.Text = "KATEGORİ GÜNCELLE";
            this.btn_CategoryAdd.Click += new System.EventHandler(this.btn_CategoryAdd_Click);
            // 
            // CategoryUpdateForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 510);
            this.Controls.Add(this.panelCategoryAdd);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CategoryUpdateForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "CategoryUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Güncelle";
            this.Load += new System.EventHandler(this.CategoryUpdateForm_Load);
            this.panelCategoryAdd.ResumeLayout(false);
            this.panelCategoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Panel panelCategoryAdd;
        private System.Windows.Forms.Label labelCategoryName;
        private DevExpress.XtraEditors.SimpleButton btn_CategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}