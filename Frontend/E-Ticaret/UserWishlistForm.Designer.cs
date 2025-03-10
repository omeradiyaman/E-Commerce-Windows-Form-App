namespace E_Ticaret
{
    partial class UserWishlistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWishlistForm));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.flpWishlist = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbSheezyDashboard = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheezyDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilter.Location = new System.Drawing.Point(414, 36);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(769, 38);
            this.txtFilter.TabIndex = 100;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // flpWishlist
            // 
            this.flpWishlist.AutoScroll = true;
            this.flpWishlist.Location = new System.Drawing.Point(125, 215);
            this.flpWishlist.Name = "flpWishlist";
            this.flpWishlist.Size = new System.Drawing.Size(1715, 730);
            this.flpWishlist.TabIndex = 16;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(1321, 35);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(152, 42);
            this.btnAccount.TabIndex = 25;
            this.btnAccount.Text = "Hesabım";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.pbAccount_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.pbAccount_MouseLeave);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(1501, 35);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(152, 42);
            this.btnCart.TabIndex = 26;
            this.btnCart.Text = "Sepetim";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            this.btnCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1666, 35);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 42);
            this.btnHome.TabIndex = 49;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // pbHome
            // 
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = global::E_Ticaret.Properties.Resources.homeIconWhite1;
            this.pbHome.Location = new System.Drawing.Point(1666, 35);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(43, 43);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 48;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // pbSheezyDashboard
            // 
            this.pbSheezyDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSheezyDashboard.Image = global::E_Ticaret.Properties.Resources.sheezy3;
            this.pbSheezyDashboard.Location = new System.Drawing.Point(0, -1);
            this.pbSheezyDashboard.Name = "pbSheezyDashboard";
            this.pbSheezyDashboard.Size = new System.Drawing.Size(326, 192);
            this.pbSheezyDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheezyDashboard.TabIndex = 31;
            this.pbSheezyDashboard.TabStop = false;
            this.pbSheezyDashboard.Click += new System.EventHandler(this.pbSheezyDashboard_Click);
            // 
            // pbCart
            // 
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::E_Ticaret.Properties.Resources.cartBlack;
            this.pbCart.Location = new System.Drawing.Point(1501, 35);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(43, 43);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 30;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            this.pbCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.pbCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // pbAccount
            // 
            this.pbAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAccount.Image = global::E_Ticaret.Properties.Resources.userBlack;
            this.pbAccount.Location = new System.Drawing.Point(1319, 35);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(43, 43);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccount.TabIndex = 27;
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
            this.filterBox.Location = new System.Drawing.Point(1132, 39);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(31, 33);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterBox.TabIndex = 15;
            this.filterBox.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 1008);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(255, 24);
            this.labelControl2.TabIndex = 104;
            this.labelControl2.Text = "© 2024 Tüm Hakları Saklıdır";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1715, 1008);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 24);
            this.labelControl1.TabIndex = 103;
            this.labelControl1.Text = "Developed by Sheezy";
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::E_Ticaret.Properties.Resources.logoutBlack;
            this.pbExit.Location = new System.Drawing.Point(1862, 35);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(43, 43);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 120;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // UserWishlistForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pbSheezyDashboard);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pbAccount);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.flpWishlist);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtFilter);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.wishlist;
            this.MaximizeBox = false;
            this.Name = "UserWishlistForm";
            this.Text = "Favorilerim";
            this.Load += new System.EventHandler(this.UserWishlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheezyDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.FlowLayoutPanel flpWishlist;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.PictureBox pbSheezyDashboard;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnHome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pbExit;
    }
}