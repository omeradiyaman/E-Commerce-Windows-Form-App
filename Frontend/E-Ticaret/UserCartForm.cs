using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Xpo.DB.Helpers;
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
    public partial class UserCartForm : DevExpress.XtraEditors.XtraForm
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public UserCartForm(int userId, string name, string surname)
        {
            UserId = userId;
            InitializeComponent();
            InitializePlaceholder();
            Name = name;
            Surname = surname;
        }
        private async void UserCartForm_Load(object sender, EventArgs e)
        {
            await LoadProductsWithQuantityAsync(UserId);
        }
        private async Task LoadProductsWithQuantityAsync(int userId, string filter = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = @"
                                SELECT 
                                    p.ProductId, p.Name, p.Description, p.Price, p.ImageUrl, 
                                    ci.Quantity
                                FROM 
                                    Products p
                                INNER JOIN 
                                    CartItems ci ON p.ProductId = ci.ProductId
                                INNER JOIN 
                                    Carts c ON ci.CartId = c.CartId
                                WHERE 
                                    c.UserId = @UserId AND 1 = 1 
                                ";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " AND (p.Name LIKE @Filter OR p.Description LIKE @Filter)";
                }
                query += " ORDER BY ci.CartItemId DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                if (!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                }
                SqlDataReader reader = await command.ExecuteReaderAsync();
                flpCart.Controls.Clear();
                while (await reader.ReadAsync())
                {
                    int productId = (int)reader["ProductId"];
                    string productName = reader["Name"].ToString();
                    string imagePath = reader["ImageUrl"].ToString();
                    decimal price = (decimal)reader["Price"];
                    string description = reader["Description"].ToString();
                    int quantity = (int)reader["Quantity"];

                    Panel productPanel = new Panel
                    {
                        Size = new Size(500, 200),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        BackColor = Color.White,
                        Padding = new Padding(5),
                        Tag = Tuple.Create(productId, quantity, price, quantity * price)
                    };

                    PictureBox productImage = new PictureBox
                    {
                        Size = new Size(150, 150),
                        Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : E_Ticaret.Properties.Resources.noImage,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Left,
                        Margin = new Padding(5)
                    };

                    PictureBox removePictureBox = new PictureBox
                    {
                        Image = Properties.Resources.removeIcon,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 30,
                        Height = 30,
                        Cursor = Cursors.Hand
                    };
                    removePictureBox.Location = new Point(productPanel.Width - removePictureBox.Width - 5, 5);

                    removePictureBox.Click += async (sender, e) => await RemoveCartItemAsync(userId, productId, productPanel);
                    productPanel.Controls.Add(removePictureBox);
                    Label nameLabel = new Label
                    {
                        Text = productName,
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Dock = DockStyle.Top,
                        Height = 30
                    };

                    Label descriptionLabel = new Label
                    {
                        Text = description,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        Dock = DockStyle.Top,
                        Height = 50,
                        Padding = new Padding(5)
                    };

                    Label priceLabel = new Label
                    {
                        Text = $"₺ {price}",
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Red,
                        Dock = DockStyle.Top,
                        Height = 30,
                        Margin = new Padding(0, 0, 0, 10)
                    };

                    Label quantityLabel = new Label
                    {
                        BackColor = Color.White,
                        Text = quantity.ToString(),
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Dock = DockStyle.Bottom,
                        Size = new Size(50, 30),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(0, 10, 0, 0)
                    };

                    Button increaseButton = new Button
                    {
                        Text = "+",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Size = new Size(30, 30),
                        BackColor = Color.LightGreen,
                        FlatStyle = FlatStyle.Flat,
                        Dock = DockStyle.Bottom,
                        Cursor = Cursors.Hand
                    };

                    Button decreaseButton = new Button
                    {
                        Text = "-",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Size = new Size(30, 30),
                        BackColor = Color.LightCoral,
                        FlatStyle = FlatStyle.Flat,
                        Dock = DockStyle.Bottom,
                        Cursor = Cursors.Hand
                    };

                    Label totalLabel = new Label
                    {
                        Text = $"Toplam: ₺ {price * quantity}",
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.DarkBlue,
                        Dock = DockStyle.Bottom,
                        Width = 150,
                        TextAlign = ContentAlignment.MiddleRight
                    };
                    CheckBox chkOrder = new CheckBox
                    {
                        Text = "",
                        Location = new Point(removePictureBox.Right - 23, removePictureBox.Bottom + 100),
                        Cursor = Cursors.Hand
                    };
                    chkOrder.CheckedChanged += (sender, e) =>
                    {
                        // productPanel.Tag'i Tuple olarak alırken null kontrolü yapalım
                        var panelData = productPanel.Tag as Tuple<int, int, decimal, decimal>;

                        if (chkOrder.Checked)
                        {
                            // Eğer panelData null değilse, aynı veriyi tekrar atayabiliriz
                            if (panelData != null)
                            {
                                productPanel.Tag = Tuple.Create(panelData.Item1, panelData.Item2, panelData.Item3, panelData.Item4);
                            }
                            else
                            {
                                // Eğer panelData null ise, yeni bir Tuple oluşturabilirsinizq
                                productPanel.Tag = Tuple.Create(0, 0, 0m, 0m); // Örnek değerler
                            }
                        }
                        else
                        {
                            // Kapatıldığında Tag'i null yapıyoruz
                            productPanel.Tag = null;
                        }
                    };


                    increaseButton.Click += async (sender, e) =>
                    {
                        if (quantity < 10)
                        {
                            await IncreaseCartItemQuantityAsync(userId, productId);
                            quantity++;
                            quantityLabel.Text = quantity.ToString();
                            totalLabel.Text = $"Toplam: ₺ {price * quantity}";
                        }
                    };

                    decreaseButton.Click += async (sender, e) =>
                    {
                        if (quantity > 1)
                        {
                            await DecreaseCartItemQuantityAsync(userId, productId);
                            quantity--;
                            quantityLabel.Text = quantity.ToString();
                            totalLabel.Text = $"Toplam: ₺ {price * quantity}";
                        }
                    };

                    FlowLayoutPanel quantityPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Dock = DockStyle.Top,
                        Height = 40
                    };

                    quantityPanel.Controls.Add(decreaseButton);
                    quantityPanel.Controls.Add(quantityLabel);
                    quantityPanel.Controls.Add(increaseButton);

                    productPanel.Controls.Add(chkOrder);
                    productPanel.Controls.Add(totalLabel);
                    productPanel.Controls.Add(quantityPanel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(descriptionLabel);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(productImage);

                    flpCart.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }
        //Database
        private async Task IncreaseCartItemQuantityAsync(int userId, int productId)
        {
            string query = @"
                            UPDATE CartItems
                            SET Quantity = Quantity + 1
                            WHERE CartId = (
                                SELECT CartId
                                FROM Carts
                                WHERE UserId = @UserId
                            ) AND ProductId = @ProductId";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@ProductId", productId);

                        await connection.OpenAsync();
                        int rowsAffected = await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private async Task DecreaseCartItemQuantityAsync(int userId, int productId)
        {
            string query = @"
                        UPDATE CartItems
                        SET Quantity = Quantity - 1
                        WHERE CartId = (
                            SELECT CartId
                            FROM Carts
                            WHERE UserId = @UserId
                        ) AND ProductId = @ProductId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@ProductId", productId);

                        await connection.OpenAsync();
                        int rowsAffected = await command.ExecuteNonQueryAsync();


                        if (rowsAffected == 0)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private async Task RemoveCartItemAsync(int userId, int productId, Panel productPanel)
        {
            DialogResult dialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Sepetten silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                string query = @"
                                DELETE FROM CartItems
                                WHERE CartId = (
                                    SELECT CartId
                                    FROM Carts
                                    WHERE UserId = @UserId
                                ) AND ProductId = @ProductId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@ProductId", productId);

                            await connection.OpenAsync();
                            await command.ExecuteNonQueryAsync();
                        }
                    }

                    productPanel.Controls.Clear();
                    productPanel.Dispose();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}");
                }
            }
            else
            {
                return;
            }
        }
        private decimal CalculateTotalProductsPrice()
        {
            decimal totalProductsPrice = 0;
            foreach (Control control in flpCart.Controls)
            {
                if (control is Panel panel)
                {
                    CheckBox chkOrder = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (chkOrder != null && chkOrder.Checked && panel.Tag is Tuple<int, int, decimal, decimal> panelData)
                    {
                        totalProductsPrice += panelData.Item4;
                    }
                }
            }

            return totalProductsPrice;
        }
        private void btnAcceptCart_Click(object sender, EventArgs e)
        {
            decimal totalProductsPrice = CalculateTotalProductsPrice();
            lblProductsPrice.Text = $"{totalProductsPrice} TL";

            decimal cargoPrice = (totalProductsPrice == 0 || totalProductsPrice >= 500) ? 0 : 39.99m;
            lblCargoPrice.Text = cargoPrice == 0 ? "0 TL" : $"{cargoPrice} TL";

            decimal totalCartPrice = totalProductsPrice + cargoPrice;
            lblTotalPrice.Text = $"{totalCartPrice} TL";

            if (totalProductsPrice > 500)
            {
                lblCargoUnder200.Text = "500 TL ve Üzeri Kargo Bedava";
                lblCargoUnder200.Visible = true;
            }
            else if (totalProductsPrice < 500 && totalProductsPrice > 0)
            {
                lblCargoUnder200.Text = $"Sepetinize {500 - totalProductsPrice} TL Ekleyerek kargo Ücreti Ödemeyin";
                lblCargoUnder200.Visible = true;
            }
            else
            {
                lblCargoUnder200.Visible = false;
            }
        }
        private async Task<bool> CheckCreditCardActivationAsync(int userId)
        {
            bool isActivated = false;
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT IsCreditCardActivated FROM Users WHERE UserId = @UserId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    var result = await command.ExecuteScalarAsync();
                    if (result != null)
                    {
                        isActivated = Convert.ToBoolean(result);
                    }
                }
            }
            return isActivated;
        }
        private async void btnOrder_Click(object sender, EventArgs e)
        {
            decimal totalOrderPrice = CalculateTotalProductsPrice();
            if (totalOrderPrice == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(
                    "Sepetinizde şu an herhangi bir ürün bulunmamaktadır.\nLütfen alışveriş yaparak ürün ekleyin!",
                    "Sepetiniz Boş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ); return;
            }
            decimal cargoPrice = (totalOrderPrice == 0 || totalOrderPrice >= 500) ? 0 : 39.99m;
            totalOrderPrice += cargoPrice;
            List<CartItem> selectedItems = new List<CartItem>();
            foreach (Control control in flpCart.Controls)
            {
                if (control is Panel panel && panel.Tag is Tuple<int, int, decimal, decimal> panelData)
                {
                    CheckBox chkOrder = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (chkOrder != null && chkOrder.Checked)
                    {
                        selectedItems.Add(new CartItem
                        {
                            ProductId = panelData.Item1,
                            Quantity = panelData.Item2,
                            Price = panelData.Item3
                        });
                    }
                }
            }
            if (selectedItems.Count == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(
                "Sepetinizde sipariş edilecek ürün yok.\nLütfen alışveriş yaparak ürün ekleyin.",
                "Sepet Durumu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                 );
                return;
            }
            string address = await GetUserAddressAsync(UserId);
            if (string.IsNullOrWhiteSpace(address))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(
                "Adres bilgisi bulunamadı. Lütfen profil bilgilerinizi güncelleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserProfileForm userProfileForm = new UserProfileForm(UserId, Name, Surname);
                this.Hide();
                userProfileForm.ShowDialog();
                return;
            }
            bool isCreditCardActivated = await CheckCreditCardActivationAsync(UserId);
            if (!isCreditCardActivated)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kredi kartınız aktif değil. Lütfen kredi kartı bilgilerinizi güncelleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CreditCardForm creditCardForm = new CreditCardForm(UserId, Name, Surname);
                this.Hide();
                creditCardForm.ShowDialog();
                return;
            }
            int orderId = await CreateOrderAsync(totalOrderPrice, selectedItems);
            if (orderId > 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Siparişiniz başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information
                    ); UserProfileForm userProfileForm = new UserProfileForm(UserId, Name, Surname);
                this.Hide();
                userProfileForm.ShowDialog();
            }
        }
        private async Task<string> GetUserAddressAsync(int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    await con.OpenAsync();
                    string query = "SELECT Address FROM Users WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        object result = await cmd.ExecuteScalarAsync();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private async Task<bool> CheckCreditCardStatusAsync(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "SELECT IsCreditCardActivated FROM Users WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        object result = await command.ExecuteScalarAsync();
                        if (result == DBNull.Value || result == null)
                        {
                            return false;
                        }
                        return (int)result == 1;
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private async Task<int> CreateOrderAsync(decimal totalOrderPrice, List<CartItem> selectedItems)
        {
            string queryCheckStock = @"
                                        SELECT Stock, Name
                                        FROM Products 
                                        WHERE ProductId = @ProductId";

            string queryInsertOrder = @"
                                        INSERT INTO Orders (UserId, Amount, OrderDate, OrderStatus, ShippingAddress)
                                        OUTPUT INSERTED.OrderId
                                        VALUES (@UserId, @Amount, GETDATE(), @OrderStatus, @ShippingAddress)";

            string queryInsertOrderItem = @"
                                        INSERT INTO OrderItems (OrderId, ProductId, Quantity, UnitPrice)
                                        VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)";

            string queryGetUserAddress = @"
                                        SELECT Address 
                                        FROM Users 
                                        WHERE UserId = @UserId";

            string queryUpdateStock = @"
                                        UPDATE Products 
                                        SET Stock = Stock - @Quantity 
                                        WHERE ProductId = @ProductId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in selectedItems)
                            {
                                using (SqlCommand commandCheckStock = new SqlCommand(queryCheckStock, connection, transaction))
                                {
                                    commandCheckStock.Parameters.AddWithValue("@ProductId", item.ProductId);

                                    using (SqlDataReader reader = await commandCheckStock.ExecuteReaderAsync())
                                    {
                                        if (await reader.ReadAsync())
                                        {
                                            int stock = Convert.ToInt32(reader["Stock"]);
                                            string productName = reader["Name"].ToString();

                                            if (stock < item.Quantity)
                                            {
                                                reader.Close();
                                                DevExpress.XtraEditors.XtraMessageBox.Show($"Ürün '{productName}' için yeterli stok bulunmamaktadır.", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                transaction.Rollback();
                                                return 0;
                                            }
                                        }
                                        else
                                        {
                                            reader.Close();
                                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün bilgileri alınamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            transaction.Rollback();
                                            return 0;
                                        }
                                    }
                                }
                            }
                            string shippingAddress = string.Empty;
                            using (SqlCommand commandGetAddress = new SqlCommand(queryGetUserAddress, connection, transaction))
                            {
                                commandGetAddress.Parameters.AddWithValue("@UserId", UserId);
                                var addressResult = await commandGetAddress.ExecuteScalarAsync();
                                shippingAddress = addressResult as string;

                                if (string.IsNullOrEmpty(shippingAddress))
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcının adresi bulunamadı.");
                                    transaction.Rollback();
                                    return 0;
                                }
                            }
                            int orderId;
                            using (SqlCommand commandInsertOrder = new SqlCommand(queryInsertOrder, connection, transaction))
                            {
                                commandInsertOrder.Parameters.AddWithValue("@UserId", UserId);
                                commandInsertOrder.Parameters.AddWithValue("@Amount", totalOrderPrice);
                                commandInsertOrder.Parameters.AddWithValue("@OrderStatus", "Pending");
                                commandInsertOrder.Parameters.AddWithValue("@ShippingAddress", shippingAddress);

                                orderId = (int)await commandInsertOrder.ExecuteScalarAsync();
                            }

                            foreach (var item in selectedItems)
                            {
                                using (SqlCommand commandInsertOrderItem = new SqlCommand(queryInsertOrderItem, connection, transaction))
                                {
                                    commandInsertOrderItem.Parameters.AddWithValue("@OrderId", orderId);
                                    commandInsertOrderItem.Parameters.AddWithValue("@ProductId", item.ProductId);
                                    commandInsertOrderItem.Parameters.AddWithValue("@Quantity", item.Quantity);
                                    commandInsertOrderItem.Parameters.AddWithValue("@UnitPrice", item.Price);

                                    await commandInsertOrderItem.ExecuteNonQueryAsync();
                                }

                                using (SqlCommand commandUpdateStock = new SqlCommand(queryUpdateStock, connection, transaction))
                                {
                                    commandUpdateStock.Parameters.AddWithValue("@ProductId", item.ProductId);
                                    commandUpdateStock.Parameters.AddWithValue("@Quantity", item.Quantity);

                                    await commandUpdateStock.ExecuteNonQueryAsync();
                                }
                            }

                            transaction.Commit();
                            return orderId;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}");
                return 0;
            }
        }
        public class CartItem
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public Panel ProductPanel { get; set; }
        }
        private void ChangeAccountColorToOrange()
        {
            btnAccount.ForeColor = Color.Orange;
            pbAccount.Image = E_Ticaret.Properties.Resources.userOrange;
        }
        private void ChangeAccountColorToBlack()
        {
            btnAccount.ForeColor = Color.Black;
            pbAccount.Image = E_Ticaret.Properties.Resources.userBlack;
        }
        private void pbAccount_MouseEnter(object sender, EventArgs e)
        {
            ChangeAccountColorToOrange();
        }
        private void pbAccount_MouseLeave(object sender, EventArgs e)
        {
            ChangeAccountColorToBlack();
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
        private void pbFavourites_MouseEnter(object sender, EventArgs e)
        {
            ChangeFavouriteColorToOrange();
        }
        private void pbFavourites_MouseLeave(object sender, EventArgs e)
        {
            ChangeFavouriteColorToBlack();
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm(UserId, Name, Surname);
            this.Hide();
            userProfileForm.ShowDialog();
        }
        private void pbAccount_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm(UserId, Name, Surname);
            this.Hide();
            userProfileForm.ShowDialog();
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
        private void pbFavourites_Click(object sender, EventArgs e)
        {
            UserWishlistForm wishlistForm = new UserWishlistForm(UserId, Name, Surname);
            this.Hide();
            wishlistForm.ShowDialog();
        }
        private void btnFavourites_Click(object sender, EventArgs e)
        {
            UserWishlistForm wishlistForm = new UserWishlistForm(UserId, Name, Surname);
            this.Hide();
            wishlistForm.ShowDialog();
        }
        private void InitializePlaceholder()
        {
            txtFilter.Text = "Sepetimde Ara";
            txtFilter.ForeColor = Color.Gray;

            txtFilter.Enter += txtFilter_Enter;
            txtFilter.Leave += txtFilter_Leave;
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Sepetimde Ara")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Sepetimde Ara";
                txtFilter.ForeColor = Color.Gray;
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
        private void pbHome_MouseEnter(object sender, EventArgs e)
        {
            ChangeHomeColorToOrange();
        }
        private void pbHome_MouseLeave(object sender, EventArgs e)
        {
            ChangeHomeColorToBlack();

        }
        private void pbSheezyDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(UserId, Name, Surname);
            this.Hide();
            dashboardForm.ShowDialog();
        }
        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await LoadProductsWithQuantityAsync(UserId, txtFilter.Text);
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
    }
}