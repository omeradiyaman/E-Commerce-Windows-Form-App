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
using static E_Ticaret.UserLoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_Ticaret
{
    public partial class DashboardForm : DevExpress.XtraEditors.XtraForm
    {
        private static bool isWelcomeMessageShown = false;
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private SqlConnection connection;
        public DashboardForm(int userId, string name, string surname)
        {
            InitializeComponent();
            InitializePlaceholder();
            UserId = userId;
            if (!isWelcomeMessageShown)
            {
                isWelcomeMessageShown = true;
                WelcomeForm form = new WelcomeForm();
                form.ShowDialog();
            }
        }
        public DashboardForm()
        {
            
        }
        private async Task LoadCategoriesAsync()
        {
            connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName ASC", connection);
            SqlDataReader reader = await command.ExecuteReaderAsync();
            if (lbCategories.InvokeRequired)
            {
                lbCategories.Invoke(new Action(() =>
                {
                    lbCategories.Items.Clear();
                    lbCategories.Items.Insert(0, new ListItem("Kategori Seçiniz", string.Empty));
                }));
            }
            else
            {
                lbCategories.Items.Clear();
                lbCategories.Items.Insert(0, new ListItem("Kategori Seçiniz", string.Empty));
            }

            while (await reader.ReadAsync())
            {
                if (lbCategories.InvokeRequired)
                {
                    lbCategories.Invoke(new Action(() =>
                    {
                        lbCategories.Items.Add(new ListItem(reader["CategoryName"].ToString(), reader["CategoryID"].ToString()));
                    }));
                }
                else
                {
                    lbCategories.Items.Add(new ListItem(reader["CategoryName"].ToString(), reader["CategoryID"].ToString()));
                }
            }

            reader.Close();
            connection.Close();
        }
        public class ListItem
        {
            public string Name { get; }
            public string Id { get; }
            public ListItem(string name, string id)
            {
                Name = name;
                Id = id;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void InitializePlaceholder()
        {
            txtFilter.Text = "Aradığınız ürün veya kategori adını yazınız";
            txtFilter.ForeColor = Color.Gray;

            txtFilter.Enter += txtFilter_Enter;
            txtFilter.Leave += txtFilter_Leave;
        }
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
        private async Task LoadProductsAsync(string categoryId = null, string filterText = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT ProductId, Name, Description, Price, ImageUrl FROM Products WHERE 1=1";
                if (!string.IsNullOrEmpty(categoryId))
                {
                    query += " AND CategoryID = @CategoryID";
                }
                if (!string.IsNullOrEmpty(filterText))
                {
                    query += " AND (Name LIKE @FilterText OR Description LIKE @FilterText)";
                }
                SqlCommand command = new SqlCommand(query, connection);
                if (!string.IsNullOrEmpty(categoryId))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                }
                if (!string.IsNullOrEmpty(filterText))
                {
                    command.Parameters.AddWithValue("@FilterText", "%" + filterText + "%");
                }
                SqlDataReader reader = await command.ExecuteReaderAsync();
                flpProducts.Controls.Clear();
                while (await reader.ReadAsync())
                {
                    int productId = (int)reader["ProductId"];
                    string productName = reader["Name"].ToString();
                    string imagePath = reader["ImageUrl"].ToString();
                    string price = reader["Price"].ToString();
                    string description = reader["Description"].ToString();
                    Panel productPanel = new Panel
                    {
                        Size = new Size(250, 350),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        BackColor = Color.White,
                        Padding = new Padding(5)
                    };
                    PictureBox productImage = new PictureBox
                    {
                        Size = new Size(150, 150),
                        Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : E_Ticaret.Properties.Resources.noImage,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top,
                        Margin = new Padding(0, 0, 0, 5)
                    };
                    bool isInWishlist = await IsProductInWishlistAsync(UserId, productId);

                    PictureBox favoriteIcon = new PictureBox
                    {
                        Size = new Size(30, 30),
                        Image = isInWishlist ? E_Ticaret.Properties.Resources.favoriteOrangeIcon : E_Ticaret.Properties.Resources.favoriteIcon,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(productImage.Right + 55, productImage.Top + 10),
                        Cursor = Cursors.Hand
                    };
                    favoriteIcon.Click += async (sender, e) =>
                    {
                        await InsertOrRemoveWishlistProductAsyncAsync(UserId, productId);

                        isInWishlist = !isInWishlist;
                        favoriteIcon.Image = isInWishlist
                            ? E_Ticaret.Properties.Resources.favoriteOrangeIcon
                            : E_Ticaret.Properties.Resources.favoriteIcon;
                    };
                    productPanel.Controls.Add(favoriteIcon);
                    Label nameLabel = new Label
                    {
                        Text = productName,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 30
                    };
                    Label descriptionLabel = new Label
                    {
                        Text = description,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 50,
                        Padding = new Padding(5)
                    };
                    Label priceLabel = new Label
                    {
                        Text = $"₺ {price}",
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Red,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 40,
                        Padding = new Padding(0, 3, 0, 3)
                    };
                    Button addToCartButton = new Button
                    {
                        Text = "Sepete Ekle",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.Orange,
                        FlatStyle = FlatStyle.Flat,
                        Dock = DockStyle.Bottom,
                        Height = 50,
                        Margin = new Padding(5),
                        Cursor = Cursors.Hand
                    };
                    addToCartButton.Click += async (sender, e) =>
                    {
                        await AddToCartAsync(UserId, productId);
                    };
                    productPanel.Controls.Add(favoriteIcon);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(descriptionLabel);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(productImage);
                    productPanel.Controls.Add(addToCartButton);
                    flpProducts.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }
        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.Trim();
            if (lbCategories.SelectedItem is ListItem selectedItem && !string.IsNullOrEmpty(selectedItem.Id))
            {
                await LoadProductsAsync(selectedItem.Id, filterText);
            }
            else
            {
                await LoadProductsAsync(null, filterText);
            }
        }
        private async void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedItem is ListItem selectedItem && !string.IsNullOrEmpty(selectedItem.Id))
            {
                await LoadProductsAsync(selectedItem.Id);
            }
            else
            {
                await LoadProductsAsync();
            }
        }
        private async Task<bool> IsProductInWishlistAsync(int userId, int productId)
        {
            int? wishlistId = await GetWishlistIdByUserIdAsync(userId);
            if (wishlistId == null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string insertQuery = "INSERT INTO Wishlists (UserId) OUTPUT INSERTED.WishlistId VALUES (@UserId)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    wishlistId = (int?)await command.ExecuteScalarAsync();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM WishlistItems WHERE WishlistId = @WishlistId AND ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@WishlistId", wishlistId);
                command.Parameters.AddWithValue("@ProductId", productId);
                int count = (int)await command.ExecuteScalarAsync();
                return count > 0;
            }
        }
        private async Task<int?> GetWishlistIdByUserIdAsync(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT WishlistId FROM Wishlists WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                var result = await command.ExecuteScalarAsync();
                return result != DBNull.Value ? (int?)result : null;
            }
        }
        private async Task InsertOrRemoveWishlistProductAsyncAsync(int userId, int productId)
        {
            int? wishlistId = await GetWishlistIdByUserIdAsync(userId);
            if (wishlistId == null)
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                bool isInWishlist = await IsProductInWishlistAsync(userId, productId);
                if (isInWishlist)
                {
                    string deleteQuery = "DELETE FROM WishlistItems WHERE WishlistId = @WishlistId AND ProductId = @ProductId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@WishlistId", wishlistId);
                    deleteCommand.Parameters.AddWithValue("@ProductId", productId);

                    await deleteCommand.ExecuteNonQueryAsync();
                }
                else
                {
                    string insertQuery = "INSERT INTO WishlistItems (WishlistId, ProductId) VALUES (@WishlistId, @ProductId)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@WishlistId", wishlistId);
                    insertCommand.Parameters.AddWithValue("@ProductId", productId);

                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }
        private async Task AddToCartAsync(int userId, int productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                try
                {
                    string findPersonCart = "SELECT CartId FROM Carts WHERE UserId = @UserId";
                    SqlCommand findCartCommand = new SqlCommand(findPersonCart, connection);
                    findCartCommand.Parameters.AddWithValue("@UserId", userId);

                    object cartIdObj = await findCartCommand.ExecuteScalarAsync();
                    int cartId;

                    if (cartIdObj == null)
                    {
                        //setpet yoksa oluştur
                        string cartIdQuery = @"
                                INSERT INTO Carts (UserId) OUTPUT INSERTED.CartId VALUES (@UserId)";

                        SqlCommand cartCommand = new SqlCommand(cartIdQuery, connection);
                        cartCommand.Parameters.AddWithValue("@UserId", userId);

                        cartId = (int)await cartCommand.ExecuteScalarAsync();
                    }
                    else
                    {
                        cartId = (int)cartIdObj;
                    }
                    string getProductPriceQuery = "SELECT Price FROM Products WHERE ProductId = @ProductId";
                    SqlCommand getProductPriceCommand = new SqlCommand(getProductPriceQuery, connection);
                    getProductPriceCommand.Parameters.AddWithValue("@ProductId", productId);
                    object priceObj = await getProductPriceCommand.ExecuteScalarAsync();

                    if (priceObj == null)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Ürün fiyatı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal productPrice = (decimal)priceObj;

                    string findCartItemQuery = "SELECT CartItemId, Quantity FROM CartItems WHERE CartId = @CartId AND ProductId = @ProductId";
                    SqlCommand findCartItemCommand = new SqlCommand(findCartItemQuery, connection);
                    findCartItemCommand.Parameters.AddWithValue("@CartId", cartId);
                    findCartItemCommand.Parameters.AddWithValue("@ProductId", productId);

                    SqlDataReader reader = await findCartItemCommand.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        int cartItemId = (int)reader["CartItemId"];
                        int existingQuantity = (int)reader["Quantity"];
                        reader.Close();

                        if (existingQuantity > 0)
                        {
                            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show(
                            "Bu ürün zaten sepette. Ürünü sepetten kaldırmak istiyor musunuz?",
                            "Ürün Zaten Sepette",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string removeCartItemQuery = "DELETE FROM CartItems WHERE CartItemId = @CartItemId";
                                SqlCommand removeCartItemCommand = new SqlCommand(removeCartItemQuery, connection);
                                removeCartItemCommand.Parameters.AddWithValue("@CartItemId", cartItemId);

                                await removeCartItemCommand.ExecuteNonQueryAsync();
                                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün sepetten kaldırıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        reader.Close();

                        string addCartItemQuery = "INSERT INTO CartItems (CartId, ProductId, Quantity, UnitPrice) VALUES (@CartId, @ProductId, 1, @UnitPrice)";
                        SqlCommand addCartItemCommand = new SqlCommand(addCartItemQuery, connection);
                        addCartItemCommand.Parameters.AddWithValue("@CartId", cartId);
                        addCartItemCommand.Parameters.AddWithValue("@ProductId", productId);
                        addCartItemCommand.Parameters.AddWithValue("@UnitPrice", productPrice);

                        int rowsAffected = await addCartItemCommand.ExecuteNonQueryAsync();
                        if (rowsAffected > 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün sepete eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün sepete eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Aradığınız ürün veya kategori adını yazınız")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Aradığınız ürün veya kategori adını yazınız";
                txtFilter.ForeColor = Color.Gray;
            }
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
        private void pbCart_MouseEnter(object sender, EventArgs e)
        {
            ChangeCartColorToOrange();
        }
        private void pbCart_MouseLeave(object sender, EventArgs e)
        {
            ChangeCartColorToBlack();
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
        private void pbSheezyDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(UserId, Name, Surname);
            this.Hide();
            dashboardForm.ShowDialog();
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