namespace E_Ticaret
{
    partial class UserProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbFavourites = new System.Windows.Forms.PictureBox();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderDetails = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.MaskedTextBox();
            this.txtCardDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCart
            // 
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::E_Ticaret.Properties.Resources.cartBlack;
            this.pbCart.Location = new System.Drawing.Point(1679, 31);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(43, 43);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 28;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            this.pbCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.pbCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // pbFavourites
            // 
            this.pbFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFavourites.Image = global::E_Ticaret.Properties.Resources.heartBlack;
            this.pbFavourites.Location = new System.Drawing.Point(1476, 31);
            this.pbFavourites.Name = "pbFavourites";
            this.pbFavourites.Size = new System.Drawing.Size(43, 43);
            this.pbFavourites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFavourites.TabIndex = 27;
            this.pbFavourites.TabStop = false;
            this.pbFavourites.Click += new System.EventHandler(this.pbFavourites_Click);
            this.pbFavourites.MouseEnter += new System.EventHandler(this.pbFavourites_MouseEnter);
            this.pbFavourites.MouseLeave += new System.EventHandler(this.pbFavourites_MouseLeave);
            // 
            // btnFavourites
            // 
            this.btnFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavourites.FlatAppearance.BorderSize = 0;
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFavourites.ForeColor = System.Drawing.Color.Black;
            this.btnFavourites.Location = new System.Drawing.Point(1476, 31);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(176, 42);
            this.btnFavourites.TabIndex = 26;
            this.btnFavourites.Text = "Favorilerim";
            this.btnFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavourites.UseVisualStyleBackColor = true;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            this.btnFavourites.MouseEnter += new System.EventHandler(this.pbFavourites_MouseEnter);
            this.btnFavourites.MouseLeave += new System.EventHandler(this.pbFavourites_MouseLeave);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(1679, 31);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(152, 42);
            this.btnCart.TabIndex = 25;
            this.btnCart.Text = "Sepetim";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            this.btnCart.MouseEnter += new System.EventHandler(this.pbCart_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.pbCart_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::E_Ticaret.Properties.Resources.sheezy3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = global::E_Ticaret.Properties.Resources.homeIconWhite1;
            this.pbHome.Location = new System.Drawing.Point(1272, 32);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(43, 43);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 50;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1271, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 42);
            this.btnHome.TabIndex = 51;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 1012);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(255, 24);
            this.labelControl2.TabIndex = 106;
            this.labelControl2.Text = "© 2025 Tüm Hakları Saklıdır";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1715, 1012);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 24);
            this.labelControl1.TabIndex = 105;
            this.labelControl1.Text = "Developed by Sheezy";
            // 
            // flpOrders
            // 
            this.flpOrders.AutoScroll = true;
            this.flpOrders.Location = new System.Drawing.Point(55, 275);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Size = new System.Drawing.Size(1260, 669);
            this.flpOrders.TabIndex = 107;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblOrderDetails.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrderDetails.Appearance.Options.UseFont = true;
            this.lblOrderDetails.Appearance.Options.UseForeColor = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(68, 236);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(162, 28);
            this.lblOrderDetails.TabIndex = 108;
            this.lblOrderDetails.Text = "Sipariş Detayları";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(1430, 249);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 24);
            this.lblName.TabIndex = 109;
            this.lblName.Text = "Ad";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtName.Location = new System.Drawing.Point(1430, 287);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 38);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSurname.Location = new System.Drawing.Point(1430, 393);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(385, 38);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(1430, 355);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 24);
            this.lblSurname.TabIndex = 111;
            this.lblSurname.Text = "Soyad";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(1433, 495);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(385, 38);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(1433, 457);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(167, 24);
            this.lblPhoneNumber.TabIndex = 113;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtAddress.Location = new System.Drawing.Point(1430, 594);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(385, 141);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAdress.ForeColor = System.Drawing.Color.Black;
            this.lblAdress.Location = new System.Drawing.Point(1430, 556);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(60, 24);
            this.lblAdress.TabIndex = 115;
            this.lblAdress.Text = "Adres";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAccount.Location = new System.Drawing.Point(1518, 149);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(222, 41);
            this.lblAccount.TabIndex = 117;
            this.lblAccount.Text = "Kişisel Bilgiler";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1427, 947);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(388, 48);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::E_Ticaret.Properties.Resources.logoutBlack;
            this.pbExit.Location = new System.Drawing.Point(1855, 30);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(43, 43);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 119;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreditCard.ForeColor = System.Drawing.Color.Black;
            this.lblCreditCard.Location = new System.Drawing.Point(1430, 754);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(137, 24);
            this.lblCreditCard.TabIndex = 120;
            this.lblCreditCard.Text = "Kart Numarası";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1430, 850);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 24);
            this.lblDate.TabIndex = 122;
            this.lblDate.Text = "Kart Tarih";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCvv.ForeColor = System.Drawing.Color.Black;
            this.lblCvv.Location = new System.Drawing.Point(1642, 850);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(42, 24);
            this.lblCvv.TabIndex = 124;
            this.lblCvv.Text = "Cvv";
            // 
            // txtCvv
            // 
            this.txtCvv.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCvv.Location = new System.Drawing.Point(1642, 888);
            this.txtCvv.Mask = "000";
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.ReadOnly = true;
            this.txtCvv.Size = new System.Drawing.Size(170, 38);
            this.txtCvv.TabIndex = 7;
            this.txtCvv.ValidatingType = typeof(System.DateTime);
            // 
            // txtCardDate
            // 
            this.txtCardDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCardDate.Location = new System.Drawing.Point(1430, 888);
            this.txtCardDate.Mask = "00/00";
            this.txtCardDate.Name = "txtCardDate";
            this.txtCardDate.ReadOnly = true;
            this.txtCardDate.Size = new System.Drawing.Size(170, 38);
            this.txtCardDate.TabIndex = 6;
            this.txtCardDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtCardNumber.Location = new System.Drawing.Point(1430, 794);
            this.txtCardNumber.Mask = "0000-0000-0000-0000";
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.ReadOnly = true;
            this.txtCardNumber.Size = new System.Drawing.Size(382, 38);
            this.txtCardNumber.TabIndex = 5;
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.SystemColors.Window;
            this.filterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("filterBox.ErrorImage")));
            this.filterBox.Image = global::E_Ticaret.Properties.Resources.search;
            this.filterBox.Location = new System.Drawing.Point(1141, 40);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(31, 33);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterBox.TabIndex = 129;
            this.filterBox.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilter.Location = new System.Drawing.Point(421, 37);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(769, 38);
            this.txtFilter.TabIndex = 130;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // UserProfileForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtCardDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.flpOrders);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbFavourites);
            this.Controls.Add(this.btnFavourites);
            this.Controls.Add(this.btnCart);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.userProfileBlack;
            this.MaximizeBox = false;
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesabım";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pbFavourites;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnHome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private DevExpress.XtraEditors.LabelControl lblOrderDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.MaskedTextBox txtCvv;
        private System.Windows.Forms.MaskedTextBox txtCardDate;
        private System.Windows.Forms.MaskedTextBox txtCardNumber;
        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox txtFilter;
    }
}