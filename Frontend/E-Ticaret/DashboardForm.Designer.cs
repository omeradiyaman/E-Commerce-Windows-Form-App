namespace E_Ticaret
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbCategories = new DevExpress.XtraEditors.ListBoxControl();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbSheezyDashboard = new System.Windows.Forms.PictureBox();
            this.pbFavourites = new System.Windows.Forms.PictureBox();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheezyDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilter.Location = new System.Drawing.Point(419, 35);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(769, 38);
            this.txtFilter.TabIndex = 100;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // lbCategories
            // 
            this.lbCategories.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCategories.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCategories.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbCategories.Appearance.Options.UseBackColor = true;
            this.lbCategories.Appearance.Options.UseFont = true;
            this.lbCategories.Appearance.Options.UseForeColor = true;
            this.lbCategories.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCategories.HorizontalScrollbar = true;
            this.lbCategories.Location = new System.Drawing.Point(1, 249);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(326, 749);
            this.lbCategories.TabIndex = 14;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(379, 225);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1484, 773);
            this.flpProducts.TabIndex = 15;
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(1687, 33);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(152, 42);
            this.btnCart.TabIndex = 20;
            this.btnCart.Text = "Sepetim";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            this.btnCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(1307, 33);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(152, 42);
            this.btnAccount.TabIndex = 16;
            this.btnAccount.Text = "Hesabım";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.pbAccount_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.pbAccount_MouseLeave);
            // 
            // btnFavourites
            // 
            this.btnFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavourites.FlatAppearance.BorderSize = 0;
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFavourites.ForeColor = System.Drawing.Color.Black;
            this.btnFavourites.Location = new System.Drawing.Point(1484, 33);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(176, 42);
            this.btnFavourites.TabIndex = 22;
            this.btnFavourites.Text = "Favorilerim";
            this.btnFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavourites.UseVisualStyleBackColor = true;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            this.btnFavourites.MouseEnter += new System.EventHandler(this.pbFavourites_MouseEnter);
            this.btnFavourites.MouseLeave += new System.EventHandler(this.pbFavourites_MouseLeave);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategories.ForeColor = System.Drawing.Color.Black;
            this.lblCategories.Location = new System.Drawing.Point(58, 212);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(193, 34);
            this.lblCategories.TabIndex = 26;
            this.lblCategories.Text = "KATEGORİLER";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1715, 1011);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 24);
            this.labelControl1.TabIndex = 101;
            this.labelControl1.Text = "Developed by Sheezy";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 1011);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(255, 24);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "© 2024 Tüm Hakları Saklıdır";
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::E_Ticaret.Properties.Resources.logoutBlack;
            this.pbExit.Location = new System.Drawing.Point(1858, 33);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(43, 43);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 103;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // pbCart
            // 
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::E_Ticaret.Properties.Resources.cartBlack;
            this.pbCart.Location = new System.Drawing.Point(1687, 33);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(43, 43);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 24;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            this.pbCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.pbCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // pbSheezyDashboard
            // 
            this.pbSheezyDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSheezyDashboard.Image = global::E_Ticaret.Properties.Resources.sheezy3;
            this.pbSheezyDashboard.Location = new System.Drawing.Point(1, 1);
            this.pbSheezyDashboard.Name = "pbSheezyDashboard";
            this.pbSheezyDashboard.Size = new System.Drawing.Size(326, 192);
            this.pbSheezyDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheezyDashboard.TabIndex = 27;
            this.pbSheezyDashboard.TabStop = false;
            this.pbSheezyDashboard.Click += new System.EventHandler(this.pbSheezyDashboard_Click);
            // 
            // pbFavourites
            // 
            this.pbFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFavourites.Image = global::E_Ticaret.Properties.Resources.heartBlack;
            this.pbFavourites.Location = new System.Drawing.Point(1484, 33);
            this.pbFavourites.Name = "pbFavourites";
            this.pbFavourites.Size = new System.Drawing.Size(43, 43);
            this.pbFavourites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFavourites.TabIndex = 23;
            this.pbFavourites.TabStop = false;
            this.pbFavourites.Click += new System.EventHandler(this.pbFavourites_Click);
            this.pbFavourites.MouseEnter += new System.EventHandler(this.pbFavourites_MouseEnter);
            this.pbFavourites.MouseLeave += new System.EventHandler(this.pbFavourites_MouseLeave);
            // 
            // pbAccount
            // 
            this.pbAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAccount.Image = global::E_Ticaret.Properties.Resources.userBlack;
            this.pbAccount.Location = new System.Drawing.Point(1307, 33);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(43, 43);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccount.TabIndex = 22;
            this.pbAccount.TabStop = false;
            this.pbAccount.Click += new System.EventHandler(this.pbAccount_Click);
            this.pbAccount.MouseEnter += new System.EventHandler(this.pbAccount_MouseEnter);
            this.pbAccount.MouseLeave += new System.EventHandler(this.pbAccount_MouseLeave);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.SystemColors.Window;
            this.filterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("filterBox.ErrorImage")));
            this.filterBox.Image = global::E_Ticaret.Properties.Resources.search;
            this.filterBox.Location = new System.Drawing.Point(1138, 38);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(31, 33);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterBox.TabIndex = 13;
            this.filterBox.TabStop = false;
            // 
            // DashboardForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pbSheezyDashboard);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.pbFavourites);
            this.Controls.Add(this.pbAccount);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFavourites);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnCart);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DashboardForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheezyDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.PictureBox filterBox;
        private DevExpress.XtraEditors.ListBoxControl lbCategories;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.PictureBox pbFavourites;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.PictureBox pbSheezyDashboard;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pbExit;
    }
}