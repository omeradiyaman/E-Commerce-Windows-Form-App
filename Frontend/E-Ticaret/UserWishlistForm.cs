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
    public partial class UserWishlistForm : DevExpress.XtraEditors.XtraForm
    {
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        public UserWishlistForm(int UserId, string name, string surname)
        {
            this.UserId = UserId;
            InitializeComponent();
            InitializePlaceholder();
            Name = name;
            Surname = surname;
        }
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private async Task LoadWishlistAsync(int userId, string filter = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = @"
                SELECT 
                    p.ProductId, p.Name, p.Description, p.Price, p.ImageUrl
                FROM 
                    Products p
                INNER JOIN 
                    WishlistItems wi ON p.ProductId = wi.ProductId
                INNER JOIN 
                    Wishlists w ON wi.WishlistId = w.WishlistId
                WHERE 
                    w.UserId = @UserId AND 1=1";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " AND (p.Name LIKE @Filter OR p.Description LIKE @Filter)";
                }
                query += " ORDER BY WishlistItemId DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                SqlDataReader reader = await command.ExecuteReaderAsync();
                flpWishlist.Controls.Clear();
                while (await reader.ReadAsync())
                {
                    int productId = (int)reader["ProductId"];
                    string productName = reader["Name"].ToString();
                    string imagePath = reader["ImageUrl"].ToString();
                    decimal price = (decimal)reader["Price"];
                    string description = reader["Description"].ToString();

                    Panel productPanel = new Panel
                    {
                        Size = new Size(500, 200),
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
                        Dock = DockStyle.Left,
                        Margin = new Padding(5)
                    };

                    PictureBox removePictureBox = new PictureBox
                    {
                        Image = Properties.Resources.removeIcon,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 30,
                        Height = 30,
                        Cursor = Cursors.Hand,
                    };
                    removePictureBox.Location = new Point(productPanel.Width - removePictureBox.Width - 5, 5);

                    removePictureBox.Click += async (sender, e) => await RemoveWishlistItemAsync(userId, productId, productPanel);
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

                    Button addToCartButton = new Button
                    {
                        Text = "Sepete Ekle",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Size = new Size(70, 50),
                        BackColor = Color.Orange,
                        FlatStyle = FlatStyle.Standard,
                        Dock = DockStyle.Bottom,
                        Margin = new Padding(10, 0, 0, 10)
                    };

                    addToCartButton.Click += async (sender, e) =>
                    {
                        await AddProductToCartAsync(userId, productId);
                    };

                    productPanel.Controls.Add(addToCartButton);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(descriptionLabel);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(productImage);

                    flpWishlist.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }
        private async Task RemoveWishlistItemAsync(int userId, int productId, Panel productPanel)
        {
            DialogResult dialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("İstek listesinden silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                string query = @"
                                DELETE FROM WishlistItems
                                WHERE WishlistId = (
                                    SELECT WishlistId
                                    FROM Wishlists
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
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata : {ex.Message}");
                }
            }
            else
            {
                return;
            }
        }
        private async Task AddProductToCartAsync(int userId, int productId)
        {
            //ürün sepette mi?
            string checkQuery = @"
                                SELECT COUNT(*) 
                                FROM CartItems 
                                WHERE CartId = (SELECT CartId FROM Carts WHERE UserId = @UserId) 
                                AND ProductId = @ProductId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserId", userId);
                        checkCommand.Parameters.AddWithValue("@ProductId", productId);

                        int count = (int)await checkCommand.ExecuteScalarAsync();

                        if (count > 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bu ürün zaten sepette");
                            return;
                        }
                    }

                    string productQuery = @"
                                        SELECT Price 
                                        FROM Products 
                                        WHERE ProductId = @ProductId";

                    decimal price;

                    using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                    {
                        productCommand.Parameters.AddWithValue("@ProductId", productId);

                        price = (decimal)await productCommand.ExecuteScalarAsync();
                    }

                    string insertQuery = @"
                                        INSERT INTO CartItems (CartId, ProductId, Quantity, UnitPrice)
                                        VALUES (
                                            (SELECT CartId FROM Carts WHERE UserId = @UserId),
                                            @ProductId,
                                            @Quantity,
                                            @Price
                                        )";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserId", userId);
                        insertCommand.Parameters.AddWithValue("@ProductId", productId);
                        insertCommand.Parameters.AddWithValue("@Quantity", 1);
                        insertCommand.Parameters.AddWithValue("@Price", price);

                        await insertCommand.ExecuteNonQueryAsync();
                    }
                }
                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün sepete eklendi");
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Hata : {ex.Message}");
            }
        }
        private async void UserWishlistForm_Load(object sender, EventArgs e)
        {
            await LoadWishlistAsync(UserId);
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
        private void InitializePlaceholder()
        {
            txtFilter.Text = "Favorilerimde Ara";
            txtFilter.ForeColor = Color.Gray;

            txtFilter.Enter += txtFilter_Enter;
            txtFilter.Leave += txtFilter_Leave;
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Favorilerimde Ara")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Favorilerimde Ara";
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
            await LoadWishlistAsync(UserId, txtFilter.Text);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}