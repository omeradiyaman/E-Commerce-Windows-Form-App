using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class AdminPanelForm : DevExpress.XtraEditors.XtraForm
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        private void pictureBoxPersons_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox.Name == "pictureBoxPersons" || pictureBox.Name == "pictureBoxCategory" || pictureBox.Name == "pictureBoxProduct")
            {
                pictureBox.Size = new Size(250, 250);
            }
        }
        private void pictureBoxPersons_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox.Name == "pictureBoxPersons" || pictureBox.Name == "pictureBoxCategory" || pictureBox.Name == "pictureBoxProduct")
            {
                pictureBox.Size = new Size(225, 225);
            }
        }
        private void pictureBoxPersons_Click(object sender, EventArgs e)
        {
            OrdersPanelForm customers = new OrdersPanelForm();
            this.Hide();
            customers.ShowDialog();
        }
        private void pictureBoxCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.ShowDialog();
        }
        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.ShowDialog();
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            this.Hide();
            form.ShowDialog();
        }
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlack;
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
