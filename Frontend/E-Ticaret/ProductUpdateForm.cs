using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Ticaret
{
    public partial class ProductUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int _productId;
        private int _categoryId;
        private string _selectedImagePath;
        private string _resourcePath;
        public ProductUpdateForm(int productId, string productName, string description, decimal price, string imageUrl, int stock, string categoryName, int categoryId)
        {
            InitializeComponent();

            _productId = productId;
            _categoryId = categoryId;
            txtProductName.Text = productName;
            txtDescription.Text = description;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();
            cmbCategoryName.SelectedValue = categoryName;
            btnImage.Text = imageUrl;
        }

        private async Task UpdateProductInDatabase(string name, string description, decimal price, string imageUrl, int stock, int categoryId)
        {
            string relativeImagePath = Path.Combine("C:\\Users\\mahsu\\source\\repos\\E-Commerce\\Frontend\\E-Ticaret\\Resources", Path.GetFileName(imageUrl));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price, ImageUrl = @ImageUrl, Stock = @Stock, CategoryId = @CategoryId WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", _productId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@ImageUrl", relativeImagePath);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    openFileDialog.Title = "Bir resim seçin";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        _selectedImagePath = openFileDialog.FileName;

                        string resourcesPath = Path.Combine("C:\\Users\\mahsu\\source\\repos\\E-Commerce\\Frontend\\E-Ticaret\\Resources", Path.GetFileName(_selectedImagePath));
                        _resourcePath = resourcesPath;
                        btnImage.Text = resourcesPath;
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task LoadCategoriesToComboBoxAsync()
        {
            try
            {
                var categories = await GetCategoriesAsync();

                cmbCategoryName.DataSource = categories;
                cmbCategoryName.DisplayMember = "Name";
                cmbCategoryName.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategoriler ComboBox'a yüklenirken bir hata oluştu : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbCategoryName.SelectedValue = _categoryId;
        }
        private async Task<List<Category>> GetCategoriesAsync()
        {
            try
            {
                List<Category> categories = new List<Category>();
                string query = "SELECT CategoryId, CategoryName FROM Categories";

                using (SqlConnection connection = new SqlConnection("Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                categories.Add(new Category
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
                return categories;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategoriler alınırken bir hata oluştu :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Category>();
            }
        }
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private async void ProductUpdateForm_Click(object sender, EventArgs e)
        {
            await LoadCategoriesToComboBoxAsync();
        }
        private async void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || !Regex.IsMatch(txtProductName.Text, @"^[a-zA-Z0-9\sçÇğĞıİöÖşŞüÜ-]+$"))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün adı geçersiz! Sadece harf, rakam kullanılabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz fiyat! Fiyat pozitif sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz stok! Stok sıfırdan küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imageUrlToSave = string.IsNullOrEmpty(_resourcePath) ? btnImage.Text : _resourcePath;
            if (string.IsNullOrEmpty(imageUrlToSave) || !File.Exists(imageUrlToSave))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen geçerli ürün resmi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = txtDescription.Text;
            try
            {
                int categoryId = (int)cmbCategoryName.SelectedValue;
                await UpdateProductInDatabase(txtProductName.Text, description, price, imageUrlToSave, stock, categoryId);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProductUpdate_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Close();
            productForm.Show();
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
    }
}