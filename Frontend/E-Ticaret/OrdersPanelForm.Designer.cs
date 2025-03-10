namespace E_Ticaret
{
    partial class OrdersPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersPanelForm));
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.panelCustomerBackground = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panelCustomerBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToOrderColumns = true;
            this.dataGridCustomers.AllowUserToResizeColumns = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomers.ColumnHeadersHeight = 50;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCustomers.Location = new System.Drawing.Point(24, 32);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.RowTemplate.Height = 50;
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(1625, 789);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellDoubleClick);
            // 
            // panelCustomerBackground
            // 
            this.panelCustomerBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCustomerBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelCustomerBackground.Controls.Add(this.dataGridCustomers);
            this.panelCustomerBackground.Location = new System.Drawing.Point(127, 106);
            this.panelCustomerBackground.Name = "panelCustomerBackground";
            this.panelCustomerBackground.Size = new System.Drawing.Size(1680, 846);
            this.panelCustomerBackground.TabIndex = 1;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::E_Ticaret.Properties.Resources.arrowBackBlack;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 21;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.LightGray;
            this.filterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("filterBox.ErrorImage")));
            this.filterBox.Image = global::E_Ticaret.Properties.Resources.search;
            this.filterBox.Location = new System.Drawing.Point(1291, 34);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(31, 33);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterBox.TabIndex = 103;
            this.filterBox.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.LightGray;
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilter.Location = new System.Drawing.Point(569, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(769, 38);
            this.txtFilter.TabIndex = 104;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // OrdersPanelForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1062);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panelCustomerBackground);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::E_Ticaret.Properties.Resources.delivery_box1;
            this.MaximizeBox = false;
            this.Name = "OrdersPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş CRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.panelCustomerBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.Panel panelCustomerBackground;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox filterBox;
        private System.Windows.Forms.TextBox txtFilter;
    }
}