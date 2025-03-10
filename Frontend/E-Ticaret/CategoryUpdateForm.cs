using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class CategoryUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int categoryId;
        private string categoryName;
        public CategoryUpdateForm(int categoryId , string categoryName)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            txtCategoryName.Text = categoryName;
        }
        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {
            string updatedCategoryName = txtCategoryName.Text.Trim();

            updatedCategoryName = Regex.Replace(updatedCategoryName, @"\s{2,}", " ");

            if (string.IsNullOrEmpty(updatedCategoryName))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategori adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", updatedCategoryName);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Kategori başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private bool IsValidCategoryName(string categoryName)
        {
            string pattern = @"^[a-zA-ZçÇşŞğĞüÜöÖıİ\s]*$";
            if (Regex.IsMatch(categoryName, pattern))
            {
                return true;
            }
            return false;
        }
        private void panelCategoryAdd_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CategoryAdd_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            this.Close();
            form.ShowDialog();
        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlack;
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
    }
}