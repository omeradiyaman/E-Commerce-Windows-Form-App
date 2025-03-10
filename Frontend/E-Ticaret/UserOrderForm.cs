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
using System.Xml.Linq;
using static E_Ticaret.UserCartForm;

namespace E_Ticaret
{
    public partial class UserOrderForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        public decimal TotalPrice { get; set; }
        public UserOrderForm(int userId, decimal totalPrice)
        {
            InitializeComponent();
            UserId = userId;
            TotalPrice = totalPrice;
        }

        private void pbSheezyDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
        }
        private void UserOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
        private void DisplayOrderDetails()
        {
        }
        private async void ConfirmOrder(List<(int productId, int quantity, decimal unitPrice)> products, string shippingAddress)
        {
            decimal totalPrice = products.Sum(p => p.quantity * p.unitPrice);
            string orderQuery = @"
                                INSERT INTO Orders (UserId, OrderDate, OrderStatus, ShippingAddress, Amount)
                                VALUES (@UserId, @OrderDate, @OrderStatus, @ShippingAddress, @Amount);
                                SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(orderQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserId", UserId);
                    command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    command.Parameters.AddWithValue("@OrderStatus", "Pending");
                    command.Parameters.AddWithValue("@ShippingAddress", shippingAddress);
                    command.Parameters.AddWithValue("@Amount", totalPrice);

                    var orderId = await command.ExecuteScalarAsync();

                    foreach (var product in products)
                    {
                        string stockQuery = "SELECT Quantity FROM Products WHERE ProductId = @ProductId";
                        using (SqlCommand stockCommand = new SqlCommand(stockQuery, connection))
                        {
                            stockCommand.Parameters.AddWithValue("@ProductId", product.productId);
                            var currentStock = (int)await stockCommand.ExecuteScalarAsync();
                            if (product.quantity > currentStock)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show($"Ürün ID: {product.productId} için yeterli stok yok. Mevcut stok: {currentStock}, İstenen miktar: {product.quantity}.");
                                return;
                            }
                        }
                        string detailQuery = @"
                                                INSERT INTO OrderItems (OrderId, ProductId, Quantity, UnitPrice)
                                                VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)";

                        using (SqlCommand detailCommand = new SqlCommand(detailQuery, connection))
                        {
                            detailCommand.Parameters.AddWithValue("@OrderId", orderId);
                            detailCommand.Parameters.AddWithValue("@ProductId", product.productId);
                            detailCommand.Parameters.AddWithValue("@Quantity", product.quantity);
                            detailCommand.Parameters.AddWithValue("@UnitPrice", product.unitPrice);

                            await detailCommand.ExecuteNonQueryAsync();
                        }
                        string updateStockQuery = @"
                                                    UPDATE Products
                                                    SET Quantity = Quantity - @Quantity
                                                    WHERE ProductId = @ProductId";

                        using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection))
                        {
                            updateStockCommand.Parameters.AddWithValue("@Quantity", product.quantity);
                            updateStockCommand.Parameters.AddWithValue("@ProductId", product.productId);

                            await updateStockCommand.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            DevExpress.XtraEditors.XtraMessageBox.Show("Siparişiniz başarıyla onaylandı!");
        }
    }
}