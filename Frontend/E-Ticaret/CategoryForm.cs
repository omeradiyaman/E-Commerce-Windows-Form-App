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
    public partial class CategoryForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public CategoryForm()
        {
            InitializeComponent();
        }
        private async Task LoadCategoriesAsync()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = @"
                            SELECT 
                                c.CategoryId AS 'Kategori Id', 
                                c.CategoryName AS 'Kategori Adı', 
                                COUNT(p.ProductId) AS 'Toplam Ürün Sayısı', 
                                SUM(p.Stock) AS 'Toplam Stok Miktarı'  
                            FROM Categories c
                            LEFT JOIN Products p ON c.CategoryId = p.CategoryId
                            GROUP BY c.CategoryId, c.CategoryName
                            ORDER BY c.CategoryId;";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                await Task.Run(() => dataAdapter.Fill(dataTable));
                dataGridCategory.DataSource = dataTable;
                dataGridCategory.Columns[0].Visible = false;
                dataGridCategory.RowHeadersVisible = false;

            }
        }
        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridCategory.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180);
            dataGridCategory.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(173, 216, 230);
            dataGridCategory.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(173, 216, 230); 
            dataGridCategory.RowHeadersDefaultCellStyle.ForeColor = Color.Black; 
            dataGridCategory.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 206, 235);
            dataGridCategory.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black; 
            dataGridCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridCategory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridCategory.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; 
            dataGridCategory.DefaultCellStyle.BackColor = Color.FromArgb(135, 206, 250); 
            dataGridCategory.DefaultCellStyle.ForeColor = Color.Black;  
            dataGridCategory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180); 
            dataGridCategory.DefaultCellStyle.SelectionForeColor = Color.White;  
            dataGridCategory.GridColor = Color.FromArgb(100, 149, 237);
            dataGridCategory.EnableHeadersVisualStyles = false;
            await LoadCategoriesAsync();
        }
        //CRUD
        private async void pictureCategoryList_Click(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
        private async void pictureAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAddForm categoryAddForm = new CategoryAddForm();
            categoryAddForm.ShowDialog();
            await LoadCategoriesAsync();
        }
        private async void pictureUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dataGridCategory.SelectedCells.Count > 0)
            {
                var selectedCell = dataGridCategory.SelectedCells[0];
                var selectedRow = selectedCell.OwningRow;
                int categoryId = Convert.ToInt32(selectedRow.Cells["Kategori Id"].Value);
                string categoryName = Convert.ToString(selectedRow.Cells["Kategori Adı"].Value);

                var updateForm = new CategoryUpdateForm(categoryId, categoryName);
                updateForm.ShowDialog();

                await LoadCategoriesAsync();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen güncellemek için bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private async void pictureDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCategory.SelectedRows.Count > 0)
                {
                    int categoryId = Convert.ToInt32(dataGridCategory.SelectedRows[0].Cells["Kategori Id"].Value);
                    string categoryName = Convert.ToString(dataGridCategory.SelectedRows[0].Cells["Kategori Adı"].Value);
                    categoryName = categoryName.Trim();
                    categoryName = Regex.Replace(categoryName, @"\s{2,}", " ");
                    DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show($"{categoryName} ürününü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteCategoryFromDatabase(categoryId);

                        await LoadCategoriesAsync();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen bir kategori seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteCategoryFromDatabase(int categoryId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    string query = "DELETE FROM Categories WHERE CategoryId = @CategoryId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Kategori başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Belirtilen kategori bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Kategor silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            AdminPanelForm form = new AdminPanelForm();
            this.Hide();
            form.ShowDialog();
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlack;
        }
        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}