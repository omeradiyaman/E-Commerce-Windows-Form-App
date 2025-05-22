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
using System.Xml.Linq;

namespace E_Ticaret
{
    public partial class UserLoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public UserLoginForm()
        {
            InitializeComponent();
        }
        public static class CurrentUser
        {
            public static int UserID { get; set; }
            public static string Name { get; set; }
            public static string Surname { get; set; }
        }   
        private void pictureBoxPasswordHideShow_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPasswordHideShow.Image = E_Ticaret.Properties.Resources.show;
            txtPassword.UseSystemPasswordChar = false;
        }
        private void pictureBoxPasswordHideShow_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPasswordHideShow.Image = E_Ticaret.Properties.Resources.hide;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void labelAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.ShowDialog();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_CustomerLogin_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text;
            string password = txtPassword.Text;
            if (ValidateInput(email, password))
            {
                if (CheckUserInDatabase(email, password))
                {
                    WelcomeForm welcomeForm = new WelcomeForm();
                    this.Hide();
                    welcomeForm.ShowDialog();
                    DashboardForm dashboardForm = new DashboardForm(CurrentUser.UserID, CurrentUser.Name, CurrentUser.Surname);
                    this.Hide();
                    dashboardForm.ShowDialog();
                }
            }
        }
        private bool ValidateInput(string email, string password)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen geçerli bir email adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckUserInDatabase(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Name, Surname, Email, IsActivated FROM Users WHERE Email = @Email AND Password = @Password AND IsAdmin = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isActivated = reader.GetBoolean(reader.GetOrdinal("IsActivated"));
                                if (!isActivated)
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Hesabınız henüz aktivasyon yapılmamış. Lütfen aktivasyon e-postanızı kontrol edin.", "Aktivasyon Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ActivateEmailForm activationForm = new ActivateEmailForm(email);
                                    this.Hide();
                                    activationForm.ShowDialog();
                                    return false;
                                }

                                CurrentUser.UserID = Convert.ToInt32(reader["UserID"]);
                                CurrentUser.Name = reader["Name"].ToString();
                                CurrentUser.Surname = reader["Surname"].ToString();
                                return true;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Mail veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Veritabanı hatası : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            UserRegisterForm form = new UserRegisterForm();
            this.Hide();
            form.ShowDialog();
        }
        private void lblForgetPw_Click(object sender, EventArgs e)
        {
            ResetPasswordForm form = new ResetPasswordForm();
            form.Tag = "User";
            this.Hide();
            form.ShowDialog();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CustomerLogin_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CustomerLogin_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void UserLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}