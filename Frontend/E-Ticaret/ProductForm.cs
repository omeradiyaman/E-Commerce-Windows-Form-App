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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class ProductForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public ProductForm()
        {
            InitializeComponent();
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            dataGridProduct.RowTemplate.Height = 60;
            dataGridProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.White; dataGridProduct.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridProduct.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridProduct.DefaultCellStyle.BackColor = Color.FromArgb(255, 228, 181);
            dataGridProduct.DefaultCellStyle.ForeColor = Color.Black;
            dataGridProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 140, 0);
            dataGridProduct.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridProduct.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
            dataGridProduct.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 140, 0);
            dataGridProduct.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            dataGridProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 239, 179);

            dataGridProduct.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 223, 186);
            dataGridProduct.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridProduct.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 140, 0);
            dataGridProduct.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridProduct.GridColor = Color.FromArgb(255, 165, 0);

            await LoadProducts();
        }
        private async Task LoadProducts(string filter = "")
        {
            string query = @"
                SELECT 
                    p.ProductId as 'Ürün ID',
                    p.Name AS 'Ürün Adı', 
                    p.Description AS 'Açıklama', 
                    p.Price AS 'Fiyat',
                    p.ImageUrl AS 'Resim URL', 
                    p.Stock AS 'Stok',       
                    c.CategoryId as 'Kategori Id',
                    c.CategoryName AS 'Kategori Adı'
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId";

            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE p.Name LIKE @Filter OR c.CategoryName LIKE @Filter OR p.Description LIKE @Filter";
            }
            query += " ORDER BY p.ProductId DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'i temizle ve sütunları yeniden oluştur
                    dataGridProduct.DataSource = null;
                    dataGridProduct.Columns.Clear();

                    // Önce normal sütunları ekle
                    dataGridProduct.DataSource = dataTable;

                    // Resim sütununu ekle
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "Resim";
                    imageColumn.HeaderText = "Resim";
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageColumn.DefaultCellStyle.NullValue = Properties.Resources.default_product_image;

                    // Resim sütununu en başa ekle
                    dataGridProduct.Columns.Insert(0, imageColumn);

                    // Diğer sütun ayarları
                    dataGridProduct.Columns["Ürün ID"].Visible = false;
                    dataGridProduct.Columns["Kategori Id"].Visible = false;
                    dataGridProduct.Columns["Resim URL"].Visible = false;
                    dataGridProduct.RowHeadersVisible = false;

                    // Resimleri yükle
                    foreach (DataGridViewRow row in dataGridProduct.Rows)
                    {
                        string imageUrl = row.Cells["Resim URL"].Value?.ToString();
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            try
                            {
                                string imagePath = Path.Combine(Application.StartupPath, "images", imageUrl);
                                if (File.Exists(imagePath))
                                {
                                    using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                                    {
                                        Image img = Image.FromStream(stream);
                                        row.Cells["Resim"].Value = img;
                                    }
                                }
                            }
                            catch
                            {
                                row.Cells["Resim"].Value = Properties.Resources.default_product_image;
                            }
                        }
                        else
                        {
                            row.Cells["Resim"].Value = Properties.Resources.default_product_image;
                        }
                    }

                    // Sütun sıralamasını ayarla (Resim en başta olacak şekilde)
                    dataGridProduct.Columns["Resim"].DisplayIndex = 0;
                    dataGridProduct.Columns["Ürün Adı"].DisplayIndex = 1;
                    dataGridProduct.Columns["Açıklama"].DisplayIndex = 2;
                    dataGridProduct.Columns["Fiyat"].DisplayIndex = 3;
                    dataGridProduct.Columns["Stok"].DisplayIndex = 4;
                    dataGridProduct.Columns["Kategori Adı"].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //public async Task LoadProducts(string filter = "")
        //{
        //    string query = @"
        //                    SELECT 
        //                        p.ProductId as 'Ürün ID',
        //                        p.Name AS 'Ürün Adı', 
        //                        p.Description AS 'Açıklama', 
        //                        p.Price AS 'Fiyat',
        //                        p.ImageUrl AS 'Resim URL', 
        //                        p.Stock AS 'Stok',       
        //                        c.CategoryId as 'Kategori Id',
        //                        c.CategoryName AS 'Kategori Adı'
        //                    FROM Products p
        //                    INNER JOIN Categories c ON p.CategoryId = c.CategoryId";
        //    if (!string.IsNullOrEmpty(filter))
        //    {
        //        query += " WHERE p.Name LIKE @Filter OR c.CategoryName LIKE @Filter OR p.Description LIKE @Filter";
        //    }

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            await connection.OpenAsync();

        //            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //            adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%");

        //            DataTable dataTable = new DataTable();
        //            try
        //            {
        //                adapter.Fill(dataTable);
        //            }
        //            catch (Exception ex)
        //            {
        //                DevExpress.XtraEditors.XtraMessageBox.Show("Veri çekme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            dataGridProduct.DataSource = dataTable;
        //            dataGridProduct.Columns[0].Visible = false;
        //            dataGridProduct.Columns[6].Visible = false;
        //            dataGridProduct.RowHeadersVisible = false;
        //        }
        //        catch (SqlException sqlEx)
        //        {
        //            DevExpress.XtraEditors.XtraMessageBox.Show("Veritabanı hatası: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (InvalidOperationException invOpEx)
        //        {
        //            DevExpress.XtraEditors.XtraMessageBox.Show("Bağlantı hatası: " + invOpEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            DevExpress.XtraEditors.XtraMessageBox.Show("Bilinmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //CRUD
        private async void productList_Click(object sender, EventArgs e)
        {
            await LoadProducts();
        }
        private async void pictureAddProduct_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
            await LoadProducts();
        }

        private async void pictureUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProduct.SelectedCells.Count > 0)
            {
                var selectedCell = dataGridProduct.SelectedCells[0];
                var selectedRow = selectedCell.OwningRow;

                int productId = Convert.ToInt32(selectedRow.Cells["Ürün Id"].Value);
                string productName = selectedRow.Cells["Ürün Adı"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["Fiyat"].Value);
                string description = selectedRow.Cells["Açıklama"].Value.ToString();
                int stock = Convert.ToInt32(selectedRow.Cells["Stok"].Value);
                string imageUrl = selectedRow.Cells["Resim URL"].Value.ToString();
                int categoryId = Convert.ToInt32(selectedRow.Cells["Kategori Id"].Value);
                string categoryName = Convert.ToString(selectedRow.Cells["Kategori Adı"].Value);

                var updateForm = new ProductUpdateForm(productId, productName, description, price, imageUrl, stock, categoryName, categoryId);
                updateForm.ShowDialog();
                await LoadProducts();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void pictureDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProduct.SelectedRows.Count > 0)
                {
                    int productId = Convert.ToInt32(dataGridProduct.SelectedRows[0].Cells["Ürün Id"].Value);
                    string productName = Convert.ToString(dataGridProduct.SelectedRows[0].Cells["Ürün Adı"].Value);
                    DialogResult result = MessageBox.Show($"{productName} ürününü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteProductFromDatabase(productId);

                        await LoadProducts();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeleteProductFromDatabase(int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    string deleteWishlistItemsQuery = "DELETE FROM WishlistItems WHERE ProductId = @ProductId";
                    using (SqlCommand deleteWishlistCmd = new SqlCommand(deleteWishlistItemsQuery, conn))
                    {
                        deleteWishlistCmd.Parameters.AddWithValue("@ProductId", productId);
                        deleteWishlistCmd.ExecuteNonQuery();
                    }
                    string deleteProductQuery = "DELETE FROM Products WHERE ProductId = @ProductId";
                    using (SqlCommand deleteProductCmd = new SqlCommand(deleteProductQuery, conn))
                    {
                        deleteProductCmd.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = deleteProductCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Belirtilen ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Ürün silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            AdminPanelForm form = new AdminPanelForm();
            this.Hide();
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
        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await LoadProducts(txtFilter.Text);
        }
        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        ////RESMI GÖSTERME İLERİDE
        //private void DisplayProductImage(string imageUrl)
        //{
        //    string imagePath = Path.Combine("images", imageUrl); // Resmin tam yolunu oluşturuyoruz
        //    if (File.Exists(imagePath))
        //    {
        //        pictureBox.Image = Image.FromFile(imagePath); // Resmi PictureBox'ta gösteriyoruz
        //    }
        //    else
        //    {
        //        pictureBox.Image = null; // Resim yoksa, boş göster
        //    }
        //}

    }
}