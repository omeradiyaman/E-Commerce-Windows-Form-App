using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class OrdersPanelForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public OrdersPanelForm()
        {
            InitializeComponent();
        }
        private async void OrdersPanelForm_Load(object sender, EventArgs e)
        {
            dataGridCustomers.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 99, 71);
            dataGridCustomers.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 228, 225);
            dataGridCustomers.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 228, 225);
            dataGridCustomers.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridCustomers.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 160, 122);
            dataGridCustomers.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridCustomers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridCustomers.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 189);
            dataGridCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 99, 71);
            dataGridCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridCustomers.GridColor = Color.FromArgb(255, 99, 71);
            dataGridCustomers.EnableHeadersVisualStyles = false;

            await LoadOrders();
        }
        //USERID - Sipariş Id - NAME - SURNAME - ADRES - PRODUCTID - PRODUCTNAME  - QUANTITY - PRİCEPER - TOTALAMOUNT - ORDERDATE - ORDERSTATUS
        public async Task LoadOrders(string filter = "")
        {
            string query = @"
                            SELECT
                                u.UserId as 'Kullanıcı ID',
                                o.OrderId as 'Sipariş Id',
                                u.Name AS 'Ad', 
                                u.Surname AS 'Soyad', 
                                u.Address AS 'Adres', 
                                oi.ProductId AS 'Ürün Id',
                                p.Name as 'Ürün Adı',
                                oi.Quantity as 'Adet',
                                oi.UnitPrice as 'Adet Fiyatı',
                                o.Amount as 'Toplam',
                                o.OrderDate AS 'Sipariş Tarihi',
                                o.OrderStatus AS 'Sipariş Durumu'
                            FROM Users u INNER JOIN Orders o ON o.UserId = u.UserId
                            INNER JOIN OrderItems oi ON o.OrderId = oi.OrderId
                            INNER JOIN Products p ON oi.ProductId = p.ProductId";
            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE (u.Name LIKE @Filter OR u.Surname LIKE @Filter OR p.Name LIKE @Filter)";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%");

                    DataTable dataTable = new DataTable();
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Veri çekme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataGridCustomers.DataSource = dataTable;
                    dataGridCustomers.Columns[0].Visible = false;
                    dataGridCustomers.RowHeadersVisible = false;
                }
                catch (SqlException sqlEx)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Veritabanı hatası: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException invOpEx)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bağlantı hatası: " + invOpEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bilinmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void dataGridCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCustomers.SelectedCells.Count > 0)
            {
                var selectedCell = dataGridCustomers.SelectedCells[0];
                var selectedRow = selectedCell.OwningRow;

                int userId = Convert.ToInt32(selectedRow.Cells[0].Value);
                int orderId = Convert.ToInt32(selectedRow.Cells[1].Value);
                string orderStatus = Convert.ToString(selectedRow.Cells["Sipariş Durumu"].Value);

                OrderStatusUpdateForm order = new OrderStatusUpdateForm(userId, orderId, orderStatus);
                order.ShowDialog();
                await LoadOrders();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            await LoadOrders(txtFilter.Text);
        }

        private void OrdersPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}