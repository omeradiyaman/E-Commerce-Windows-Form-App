using DevExpress.XtraEditors;
using E_Commerce.Domain.Enums;
using MailKit.Net.Smtp;
using MimeKit;
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
    public partial class UserProfileForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string PhoneNumber { get; set; }
        private string Address { get; set; }
        public UserProfileForm(int userId, string name, string surname)
        {
            InitializeComponent();
            UserId = userId;
            Name = name;
            Surname = surname;
        }

        private async Task BringUserInformation(int userId)
        {
            string query = "SELECT Name, Surname, PhoneNumber, Address FROM Users WHERE UserId = @UserId";
            string cardQuery = "SELECT CardNumber, CardDate, CVV FROM CreditCards WHERE UserId = @UserId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                txtName.Text = reader["Name"].ToString();
                                txtSurname.Text = reader["Surname"].ToString();
                                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                txtName.Clear();
                                txtSurname.Clear();
                                txtPhoneNumber.Clear();
                                txtAddress.Clear();
                            }
                        }
                    }

                    using (SqlCommand cardCmd = new SqlCommand(cardQuery, conn))
                    {
                        cardCmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader cardReader = await cardCmd.ExecuteReaderAsync())
                        {
                            if (await cardReader.ReadAsync())
                            {
                                string cardNumber = cardReader["CardNumber"].ToString();
                                string cardDate = cardReader["CardDate"].ToString();
                                string cvv = cardReader["CVV"].ToString();

                                txtCardNumber.Text = string.IsNullOrEmpty(cardNumber) ? "" : FormatCardNumber(cardNumber);
                                txtCardDate.Text = string.IsNullOrEmpty(cardDate) ? "" : FormatCardDate(cardDate);
                                txtCvv.Text = cvv;
                            }
                            else
                            {
                                txtCardNumber.Clear();
                                txtCardDate.Clear();
                                txtCvv.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string FormatCardNumber(string cardNumber)
        {
            return string.Join("-", cardNumber.Where(char.IsDigit)
                                              .Select((c, i) => (c, i))
                                              .GroupBy(ci => ci.i / 4, ci => ci.c)
                                              .Select(group => new string(group.ToArray())));
        }
        private string FormatCardDate(string cardDate)
        {
            return cardDate.Length == 4
                ? $"{cardDate.Substring(0, 2)}/{cardDate.Substring(2, 2)}"
                : cardDate;
        }
        private async void UserProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtSurname.Text = Surname;
            InitializePlaceholder();
            await BringUserInformation(UserId);
            await LoadOrdersAsync(UserId);
        }
        private async Task LoadOrdersAsync(int userId, string filter = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = @"
                                SELECT p.ProductId, p.Name, p.Description, p.Price, p.ImageUrl, 
                                       o.OrderDate, o.OrderStatus, o.ShippingAddress, 
                                       oi.Quantity, 
                                       o.OrderId, 
                                       (p.Price * oi.Quantity) AS Amount
                                FROM Products p
                                INNER JOIN OrderItems oi ON p.ProductId = oi.ProductId
                                INNER JOIN Orders o ON oi.OrderId = o.OrderId
                                WHERE o.UserId = @UserId AND 1 = 1";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " AND (p.Name LIKE @Filter OR p.Description LIKE @Filter)";
                }
                query += " ORDER BY OrderDate DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                if (!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                }

                SqlDataReader reader = await command.ExecuteReaderAsync();

                flpOrders.Controls.Clear();

                while (await reader.ReadAsync())
                {
                    int productId = (int)reader["ProductId"];
                    int orderId = (int)reader["OrderId"];
                    string productName = reader["Name"].ToString();
                    string imagePath = reader["ImageUrl"].ToString();
                    decimal price = (decimal)reader["Price"];
                    string description = reader["Description"].ToString();
                    DateTime orderDate = (DateTime)reader["OrderDate"];
                    string orderStatus = reader["OrderStatus"].ToString();
                    string orderAddress = reader["ShippingAddress"].ToString();
                    string orderQuantity = reader["Quantity"].ToString();
                    string orderTotalAmount = reader["Amount"].ToString();

                    Panel productPanel = new Panel
                    {
                        Size = new Size(500, 220),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        BackColor = Color.White,
                        Padding = new Padding(5)
                    };

                    PictureBox productImage = new PictureBox
                    {
                        Size = new Size(180, 220),
                        Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : E_Ticaret.Properties.Resources.noImage,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Right,
                        Margin = new Padding(5)
                    };

                    FlowLayoutPanel contentPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        AutoSize = true,
                        WrapContents = false,
                        Location = new Point(10, 10),
                        Size = new Size(480, 180)
                    };

                    Label orderAddressLabel = new Label
                    {
                        Text = "Sipariş Adresi: " + (orderAddress.Length > 30 ? orderAddress.Substring(0, 15) + "..." : orderAddress),
                        Font = new Font("Tahoma", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = true,
                        MaximumSize = new Size(460, 0)
                    };

                    Label orderProductName = new Label
                    {
                        Text = "Ürün Adı: " + (productName.Length > 30 ? productName.Substring(0, 15) + "..." : productName),
                        Font = new Font("Tahoma", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = true
                    };

                    Label orderDateLabel = new Label
                    {
                        Text = "Satın Alınma Tarihi: " + orderDate.ToString("yyyy-MM-dd"),
                        Font = new Font("Tahoma", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = true
                    };

                    Label orderQuantityLabel = new Label
                    {
                        Text = "Adet: " + orderQuantity,
                        Font = new Font("Tahoma", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = true
                    };

                    Label orderTotalAmountLabel = new Label
                    {
                        Text = "Toplam Tutar: " + orderTotalAmount,
                        Font = new Font("Tahoma", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = true
                    };

                    Label orderStatusLabel = new Label
                    {
                        Text = "Durum: " + ChangeOrderStatusToTurkish(orderStatus),
                        Font = new Font("Tahoma", 12, FontStyle.Bold),
                        ForeColor = Color.Green,
                        AutoSize = true
                    };

                    Button cancelOrderButton = new Button
                    {
                        Text = "Siparişi İptal Et",
                        Font = new Font("Tahoma", 10, FontStyle.Regular),
                        ForeColor = Color.White,
                        BackColor = Color.Red,
                        Size = new Size(130, 50),
                        Margin = new Padding(5),
                        Anchor = AnchorStyles.Bottom,
                        Dock = DockStyle.Bottom
                    };

                    cancelOrderButton.Click += async (sender, e) =>
                    {
                        DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show(
                                        $"{productName} ürününü iptal etmek istediğinizden emin misiniz?",
                                        "Sipariş İptali",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await CancelOrderAsync(orderId, productId);
                        }
                    };

                    productPanel.Controls.Add(cancelOrderButton);
                    productPanel.Controls.Add(productImage);
                    productPanel.Controls.Add(contentPanel);
                    contentPanel.Controls.Add(orderAddressLabel);
                    contentPanel.Controls.Add(orderProductName);
                    contentPanel.Controls.Add(orderDateLabel);
                    contentPanel.Controls.Add(orderStatusLabel);
                    contentPanel.Controls.Add(orderQuantityLabel);
                    contentPanel.Controls.Add(orderTotalAmountLabel);
                    flpOrders.Controls.Add(productPanel);
                }

                reader.Close();
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInformation(txtName.Text, txtSurname.Text, txtPhoneNumber.Text, txtAddress.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen tüm kişisel bilgilerinizi doğru şekilde girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool userUpdated = await UpdateUserInformation(UserId, txtName.Text, txtSurname.Text, txtPhoneNumber.Text, txtAddress.Text);

                if (userUpdated)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Kişisel Bilgiler başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtCardDate.Visible = txtCardNumber.Visible = txtCvv.Visible = true;
                    //if (string.IsNullOrEmpty(txtCardNumber.Text) || string.IsNullOrEmpty(txtCardDate.Text) || string.IsNullOrEmpty(txtCvv.Text))
                    //{
                    //    bool cardUpdated = await UpdateCardInformation(UserId, txtCardNumber.Text, txtCardDate.Text, txtCvv.Text);

                    //    if (cardUpdated)
                    //    {
                    //        DevExpress.XtraEditors.XtraMessageBox.Show("Kart bilgileri başarıyla güncellendi. Kart aktivasyonu için yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        CreditCardActivateForm form = new CreditCardActivateForm(UserId, txtCardNumber.Text, txtCardDate.Text, txtCvv.Text, txtName.Text, txtSurname.Text);
                    //        this.Hide();
                    //        form.ShowDialog();
                    //    }
                    //    else
                    //    {
                    //        DevExpress.XtraEditors.XtraMessageBox.Show("Kart bilgileri güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    DevExpress.XtraEditors.XtraMessageBox.Show("Kart bilgileri zaten güncel.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Güncelleme yapılacak veri yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> UpdateUserInformation(int userId, string name, string surname, string phoneNumber, string address)
        {
            string query = "SELECT Name, Surname, PhoneNumber, Address FROM Users WHERE UserId = @UserId";
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            string existingName = reader["Name"].ToString();
                            string existingSurname = reader["Surname"].ToString();
                            string existingPhoneNumber = reader["PhoneNumber"].ToString();
                            string existingAddress = reader["Address"].ToString();
                            if (existingName != name || existingSurname != surname || existingPhoneNumber != phoneNumber || existingAddress != address)
                            {
                                isUpdated = true;
                            }
                        }
                    }
                }
            }

            if (isUpdated)
            {
                string updateQuery = "UPDATE Users SET Name = @Name, Surname = @Surname, PhoneNumber = @PhoneNumber, Address = @Address WHERE UserId = @UserId";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = surname;
                        cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }
        private async Task<bool> UpdateCardInformation(int userId, string cardNumber, string cardDate, string cvv)
        {
            string checkCardQuery = "SELECT CardNumber, CardDate, CVV FROM CreditCards WHERE UserId = @UserId";
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(checkCardQuery, conn))
                {
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            string existingCardNumber = reader["CardNumber"].ToString();
                            string existingCardDate = reader["CardDate"].ToString();
                            string existingCVV = reader["CVV"].ToString();
                            if (existingCardNumber != cardNumber.Replace("-", "") || existingCardDate != cardDate.Replace("/", "").Replace(".", "") || existingCVV != cvv)
                            {
                                isUpdated = true;
                            }
                        }
                    }
                }
            }

            if (isUpdated)
            {
                string cardQuery = @"
                                    IF EXISTS (SELECT 1 FROM CreditCards WHERE UserId = @UserId) 
                                        UPDATE CreditCards 
                                        SET CardNumber = @CardNumber, CardDate = @CardDate, CVV = @CVV 
                                        WHERE UserId = @UserId
                                    ELSE
                                        INSERT INTO CreditCards (UserId, CardNumber, CardDate, CVV) 
                                        VALUES (@UserId, @CardNumber, @CardDate, @CVV);";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    using (SqlCommand cmd = new SqlCommand(cardQuery, conn, transaction))
                    {
                        try
                        {
                            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                            cmd.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber.Replace("-", "");
                            cmd.Parameters.Add("@CardDate", SqlDbType.NVarChar).Value = cardDate.Replace("/", "").Replace(".", "");
                            cmd.Parameters.Add("@CVV", SqlDbType.NVarChar).Value = cvv;

                            await cmd.ExecuteNonQueryAsync();
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            return false;
        }
        //private async Task<bool> SaveCodeToDatabaseAsync(int userId, string resetCode)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            await connection.OpenAsync();
        //            string query = "UPDATE Users SET CreditCardActivationCode = @ResetCode, IsActivated = 0 WHERE UserId = @UserId";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@ResetCode", resetCode);
        //                command.Parameters.AddWithValue("@UserId", userId);

        //                int rowsAffected = await command.ExecuteNonQueryAsync();
        //                return rowsAffected > 0;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }
        //}
        private async Task<string> GetUserEmailAsync(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "SELECT Email FROM Users WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        object result = await command.ExecuteScalarAsync();
                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("E-posta adresi alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        private async Task SendEmailAsync(string email, string resetCode)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sheezy", email));
                message.To.Add(new MailboxAddress(email, email));
                message.Subject = "Kart Onaylama Kodu";
                message.Body = new TextPart("plain")
                {
                    Text = $"Merhaba,\n\nOnaylama kodunuz: {resetCode}\n\nBu kodu kullanarak kartınızı kaydedebilirsiniz.\n\nTeşekkürler."
                };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("omeradiyaman1169@gmail.com", "wzws oljy wxvo pads");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                DevExpress.XtraEditors.XtraMessageBox.Show("Onay kodu başarıyla e-posta adresinize gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"E-posta gönderiminde bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private bool ValidateUserInformation(string name, string surname, string phoneNumber, string address)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-ZçÇşŞğĞüÜöÖıİ\s]+$"))
                {
                    throw new Exception("Ad sadece harflerden oluşmalı");
                }

                if (!Regex.IsMatch(surname, @"^[a-zA-ZçÇşŞğĞüÜöÖıİ\s]+$"))
                {
                    throw new Exception("Soyad sadece harflerden oluşmalı");
                }

                if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
                {
                    throw new Exception("Telefon numarası 10 haneli ve rakamlardan oluşmalı!");
                }

                if (!Regex.IsMatch(address, @"^[A-Za-zÇçĞğÖöŞşÜüİı0-9\s,.'\-:/\\]+$"))
                {
                    throw new Exception("Adres boş olamaz!");
                }

                return true;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static string ChangeOrderStatusToTurkish(string orderStatus)
        {
            switch (orderStatus)
            {
                case "Pending":
                    return "Hazırlanıyor";
                case "Shipped":
                    return "Kargoda";
                case "InTransit":
                    return "Taşımada";
                case "OutForDelivery":
                    return "Teslimata Çıktı";
                case "Delivered":
                    return "Teslim Edildi";
                case "Returned":
                    return "İade Edildi";
                default:
                    return orderStatus;
            }
        }
        //ENUM İLE GELECEK
        //private Image GetStatusIcon(string status)
        //{
        //    switch (status.ToLower())
        //    {
        //        case "shipped":
        //            return Properties.Resources.ShippedIcon; 
        //        case "pending":
        //            return Properties.Resources.PendingIcon;
        //        case "delivered":
        //            return Properties.Resources.DeliveredIcon;
        //        default:
        //            return Properties.Resources.DefaultIcon; 
        //    }
        //}
        private async Task CancelOrderAsync(int orderId, int productId)
        {
            try
            {
                DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show(
                    "Bu işlemi geri alamazsınız. Ürünü siparişinizden silmek istediğinizden emin misiniz?",
                    "Ürünü Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string getQuantityQuery = "SELECT Quantity FROM OrderItems WHERE OrderId = @OrderId AND ProductId = @ProductId";
                    int quantity = 0;

                    using (SqlCommand getQuantityCommand = new SqlCommand(getQuantityQuery, connection))
                    {
                        getQuantityCommand.Parameters.AddWithValue("@OrderId", orderId);
                        getQuantityCommand.Parameters.AddWithValue("@ProductId", productId);

                        object resultQuantity = await getQuantityCommand.ExecuteScalarAsync();
                        if (resultQuantity != null)
                        {
                            quantity = Convert.ToInt32(resultQuantity);
                        }
                    }
                    string deleteQuery = "DELETE FROM OrderItems WHERE OrderId = @OrderId AND ProductId = @ProductId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@OrderId", orderId);
                        deleteCommand.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = await deleteCommand.ExecuteNonQueryAsync();
                        if (rowsAffected > 0)
                        {
                            string updateStockQuery = "UPDATE Products SET Stock = Stock + @Quantity WHERE ProductId = @ProductId";

                            using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection))
                            {
                                updateStockCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateStockCommand.Parameters.AddWithValue("@ProductId", productId);

                                await updateStockCommand.ExecuteNonQueryAsync();
                            }
                            string checkOrderItemsQuery = "SELECT COUNT(*) FROM OrderItems WHERE OrderId = @OrderId";

                            using (SqlCommand checkOrderItemsCommand = new SqlCommand(checkOrderItemsQuery, connection))
                            {
                                checkOrderItemsCommand.Parameters.AddWithValue("@OrderId", orderId);

                                int remainingItems = (int)await checkOrderItemsCommand.ExecuteScalarAsync();

                                if (remainingItems == 0)
                                {
                                    string deleteOrderQuery = "DELETE FROM Orders WHERE OrderId = @OrderId";

                                    using (SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection))
                                    {
                                        deleteOrderCommand.Parameters.AddWithValue("@OrderId", orderId);
                                        await deleteOrderCommand.ExecuteNonQueryAsync();
                                    }
                                }
                            }
                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün siparişten başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadOrdersAsync(UserId);
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumu
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(UserId, Name, Surname);
            this.Hide();
            dashboardForm.ShowDialog();
        }
        private void pbHome_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(UserId, Name, Surname);
            this.Hide();
            dashboardForm.ShowDialog();
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            UserCartForm form = new UserCartForm(UserId, Name, Surname);
            this.Hide();
            form.ShowDialog();
        }
        private void pbCart_Click(object sender, EventArgs e)
        {
            UserCartForm form = new UserCartForm(UserId, Name, Surname);
            this.Hide();
            form.ShowDialog();
        }
        private void btnFavourites_Click(object sender, EventArgs e)
        {
            UserWishlistForm wishlistForm = new UserWishlistForm(UserId, Name, Surname);
            this.Hide();
            wishlistForm.ShowDialog();
        }
        private void pbFavourites_Click(object sender, EventArgs e)
        {
            UserWishlistForm wishlistForm = new UserWishlistForm(UserId, Name, Surname);
            this.Hide();
            wishlistForm.ShowDialog();
        }
        private void ChangeHomeColorToOrange()
        {
            btnHome.ForeColor = Color.Orange;
            pbHome.Image = E_Ticaret.Properties.Resources.homeIconOrange;
        }
        private void ChangeHomeColorToBlack()
        {
            btnHome.ForeColor = Color.Black;
            pbHome.Image = E_Ticaret.Properties.Resources.homeIconWhite;
        }
        private void ChangeFavouriteColorToOrange()
        {
            btnFavourites.ForeColor = Color.Orange;
            pbFavourites.Image = E_Ticaret.Properties.Resources.heartOrange;
        }
        private void ChangeFavouriteColorToBlack()
        {
            btnFavourites.ForeColor = Color.Black;
            pbFavourites.Image = E_Ticaret.Properties.Resources.heartBlack;
        }
        private void ChangeCartColorToOrange()
        {
            btnCart.ForeColor = Color.Orange;
            pbCart.Image = E_Ticaret.Properties.Resources.cartOrange;
        }
        private void ChangeCartColorToBlack()
        {
            btnCart.ForeColor = Color.Black;
            pbCart.Image = E_Ticaret.Properties.Resources.cartBlack;

        }
        private void pbHome_MouseEnter(object sender, EventArgs e)
        {
            ChangeHomeColorToOrange();
        }
        private void pbHome_MouseLeave(object sender, EventArgs e)
        {
            ChangeHomeColorToBlack();
        }
        private void pbFavourites_MouseEnter(object sender, EventArgs e)
        {
            ChangeFavouriteColorToOrange();
        }
        private void pbFavourites_MouseLeave(object sender, EventArgs e)
        {
            ChangeFavouriteColorToBlack();
        }
        private void pbCart_MouseEnter(object sender, EventArgs e)
        {
            ChangeCartColorToOrange();
        }
        private void pbCart_MouseLeave(object sender, EventArgs e)
        {
            ChangeCartColorToBlack();
        }
        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = E_Ticaret.Properties.Resources.logoutBlack;
        }
        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.Image = E_Ticaret.Properties.Resources.logoutOrange;
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            UserLoginForm form = new UserLoginForm();
            this.Hide();
            form.ShowDialog();
        }
        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await LoadOrdersAsync(UserId, txtFilter.Text);
        }
        private void InitializePlaceholder()
        {
            txtFilter.Text = "Profilimde ara";
            txtFilter.ForeColor = Color.Gray;

            txtFilter.Enter += txtFilter_Enter;
            txtFilter.Leave += txtFilter_Leave;
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Profilimde ara")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Profilimde ara";
                txtFilter.ForeColor = Color.Gray;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}