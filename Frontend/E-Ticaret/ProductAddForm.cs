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

namespace E_Ticaret
{
    public partial class ProductAddForm : DevExpress.XtraEditors.XtraForm
    {
        private string _resourcePath;
        public ProductAddForm()
        {
            InitializeComponent();
        }
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
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
                                    Id = reader.GetInt32(0), // Id
                                    Name = reader.GetString(1) // CategoryName
                                });
                            }
                        }
                    }
                }
                return categories;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategoriler alınırken bir hata oluştu : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Category>();
            }
        }
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public async Task LoadCategoriesToComboBoxAsync()
        {
            try
            {
                var defaultCategory = new Category { Id = 0, Name = "Kategoriyi Seçiniz" };

                var categories = await GetCategoriesAsync();

                categories.Insert(0, defaultCategory);
                cmbCategories.DataSource = categories;
                cmbCategories.DisplayMember = "Name";
                cmbCategories.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kategoriler ComboBox'a yüklenirken bir hata oluştu : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ProductAddForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesToComboBoxAsync();
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
                        string selectedImagePath = openFileDialog.FileName;
                        string resourcesPath = Path.Combine("C:\\Users\\mahsu\\source\\repos\\E-Commerce\\Frontend\\E-Ticaret\\Resources", Path.GetFileName(selectedImagePath));
                        _resourcePath = resourcesPath;
                        btnImage.Text = _resourcePath;
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || !Regex.IsMatch(txtProductName.Text, @"^[a-zA-Z0-9\sçÇğĞıİöÖşŞüÜ\-\&\+,]+$"))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün adı geçersiz! Sadece harf, rakam kullanılabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtProductPrice.Text, out decimal price) || price <= 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz fiyat! Fiyat pozitif sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtProductStock.Text, out int stock) || stock < 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz stok! Stok sıfırdan küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategories.SelectedIndex == 0) 
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen geçerli kategori seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = txtDescription.Text;
            string imageUrlToSave = string.IsNullOrEmpty(_resourcePath) ? btnImage.Text : _resourcePath;
            if (string.IsNullOrEmpty(imageUrlToSave) || !File.Exists(imageUrlToSave))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen resim seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int categoryId = Convert.ToInt32(cmbCategories.SelectedValue);
            AddProductToDatabase(txtProductName.Text, description, price, imageUrlToSave, stock, categoryId);

        }
        private async void AddProductToDatabase(string name, string description, decimal price, string imageUrl, int stock, int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CategoryId) VALUES (@Name, @Description, @Price, @ImageUrl, @Stock, @CategoryId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@ImageUrl", imageUrl);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            ProductForm productForm = new ProductForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddProduct_Click(this, EventArgs.Empty);
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
