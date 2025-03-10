namespace E_Ticaret
{
    partial class CategoryAddForm
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
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
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
            this.panelCategoryAdd.Controls.Add(this.pictureBoxBanner);
            this.panelCategoryAdd.Controls.Add(this.labelCategoryName);
            this.panelCategoryAdd.Controls.Add(this.txtCategoryName);
            this.panelCategoryAdd.Controls.Add(this.btn_CategoryAdd);
            this.panelCategoryAdd.Location = new System.Drawing.Point(30, 30);
            this.panelCategoryAdd.Name = "panelCategoryAdd";
            this.panelCategoryAdd.Size = new System.Drawing.Size(437, 447);
            this.panelCategoryAdd.TabIndex = 0;
            this.panelCategoryAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCategoryAdd_Paint);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(14, 16);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 21;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = global::E_Ticaret.Properties.Resources.add_cateogry1;
            this.pictureBoxBanner.Location = new System.Drawing.Point(124, 42);
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
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCategoryName.Location = new System.Drawing.Point(57, 311);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(325, 36);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategoryName_KeyDown);
            // 
            // btn_CategoryAdd
            // 
            this.btn_CategoryAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CategoryAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_CategoryAdd.Appearance.Options.UseFont = true;
            this.btn_CategoryAdd.Appearance.Options.UseForeColor = true;
            this.btn_CategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CategoryAdd.Location = new System.Drawing.Point(57, 371);
            this.btn_CategoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CategoryAdd.Name = "btn_CategoryAdd";
            this.btn_CategoryAdd.Size = new System.Drawing.Size(325, 35);
            this.btn_CategoryAdd.TabIndex = 2;
            this.btn_CategoryAdd.Text = "KATEGORİ EKLE";
            this.btn_CategoryAdd.Click += new System.EventHandler(this.btn_CategoryAdd_Click);
            // 
            // CategoryAddForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 510);
            this.Controls.Add(this.panelCategoryAdd);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.add_cateogry;
            this.MaximizeBox = false;
            this.Name = "CategoryAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            this.Load += new System.EventHandler(this.CategoryAddForm_Load);
            this.panelCategoryAdd.ResumeLayout(false);
            this.panelCategoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategoryAdd;
        private DevExpress.XtraEditors.SimpleButton btn_CategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}