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
    public partial class CategoryAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public CategoryAddForm()
        {
            InitializeComponent();
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
        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategori adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidCategoryName(categoryName))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategori adı yalnızca harf ve 1 tane (kategorileri ayırmak amacıyla) '&' sembolünü içerebilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = categoryName;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        DevExpress.XtraEditors.XtraMessageBox.Show("Kategori başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCategoryName.Clear();
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Close();
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
        private void panelCategoryAdd_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CategoryAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}