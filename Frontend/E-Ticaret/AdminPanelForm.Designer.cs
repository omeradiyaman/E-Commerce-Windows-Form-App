namespace E_Ticaret
{
    partial class AdminPanelForm
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
            this.labelPerson = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxCategory = new System.Windows.Forms.PictureBox();
            this.pictureBoxPersons = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerson.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPerson.Location = new System.Drawing.Point(165, 385);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(167, 38);
            this.labelPerson.TabIndex = 1;
            this.labelPerson.Text = "SİPARİŞLER";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCategory.Location = new System.Drawing.Point(438, 385);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(199, 38);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "KATEGORİLER";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProduct.ForeColor = System.Drawing.Color.DarkGray;
            this.labelProduct.Location = new System.Drawing.Point(767, 385);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(144, 38);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "ÜRÜNLER";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProduct.Image = global::E_Ticaret.Properties.Resources.best_product;
            this.pictureBoxProduct.Location = new System.Drawing.Point(722, 113);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            this.pictureBoxProduct.Click += new System.EventHandler(this.pictureBoxProduct_Click);
            this.pictureBoxProduct.MouseLeave += new System.EventHandler(this.pictureBoxPersons_MouseLeave);
            this.pictureBoxProduct.MouseHover += new System.EventHandler(this.pictureBoxPersons_MouseHover);
            // 
            // pictureBoxCategory
            // 
            this.pictureBoxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCategory.Image = global::E_Ticaret.Properties.Resources.app;
            this.pictureBoxCategory.Location = new System.Drawing.Point(427, 113);
            this.pictureBoxCategory.Name = "pictureBoxCategory";
            this.pictureBoxCategory.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategory.TabIndex = 0;
            this.pictureBoxCategory.TabStop = false;
            this.pictureBoxCategory.Click += new System.EventHandler(this.pictureBoxCategory_Click);
            this.pictureBoxCategory.MouseLeave += new System.EventHandler(this.pictureBoxPersons_MouseLeave);
            this.pictureBoxCategory.MouseHover += new System.EventHandler(this.pictureBoxPersons_MouseHover);
            // 
            // pictureBoxPersons
            // 
            this.pictureBoxPersons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPersons.Image = global::E_Ticaret.Properties.Resources.delivery;
            this.pictureBoxPersons.Location = new System.Drawing.Point(137, 113);
            this.pictureBoxPersons.Name = "pictureBoxPersons";
            this.pictureBoxPersons.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxPersons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersons.TabIndex = 0;
            this.pictureBoxPersons.TabStop = false;
            this.pictureBoxPersons.Click += new System.EventHandler(this.pictureBoxPersons_Click);
            this.pictureBoxPersons.MouseLeave += new System.EventHandler(this.pictureBoxPersons_MouseLeave);
            this.pictureBoxPersons.MouseHover += new System.EventHandler(this.pictureBoxPersons_MouseHover);
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
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 514);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.pictureBoxCategory);
            this.Controls.Add(this.pictureBoxPersons);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.security;
            this.LookAndFeel.SkinName = "Office 2019 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersons;
        private System.Windows.Forms.PictureBox pictureBoxCategory;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}

