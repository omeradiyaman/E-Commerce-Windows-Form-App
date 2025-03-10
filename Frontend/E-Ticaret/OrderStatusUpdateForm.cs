using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using E_Commerce.Domain.Enums;
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
    public partial class OrderStatusUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int UserId { get; set; }
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public OrderStatusUpdateForm(int userId, int orderId, string orderStatus)
        {
            InitializeComponent();
            UserId = userId;
            OrderId = orderId;
            OrderStatus = orderStatus;
        }
        private void OrderStatusUpdateForm_Load(object sender, EventArgs e)
        {
            cmbOrders.DataSource = Enum.GetValues(typeof(OrderStatus));

            if (Enum.TryParse<OrderStatus>(OrderStatus, out var selectedStatus))
            {
                cmbOrders.SelectedItem = selectedStatus;
            }
        }
        private async void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            OrderStatus newStatus = (OrderStatus)cmbOrders.SelectedItem;

            bool success = await UpdateOrderStatus(UserId, OrderId, newStatus);

            if (success)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Sipariş durumu başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Güncelleme sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> UpdateOrderStatus(int userId, int orderId, OrderStatus newStatus)
        {
            string query = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE UserId = @UserId AND OrderId = @OrderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderStatus", newStatus.ToString());
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    return rowsAffected > 0;
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            OrdersPanelForm form = new OrdersPanelForm();
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