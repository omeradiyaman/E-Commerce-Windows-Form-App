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
    public partial class AdminLoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public AdminLoginForm()
        {
            InitializeComponent();
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
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
        }
        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!ValidateInput(email, password))
            {
                return;
            }

            if (CheckUserInDatabase(email, password))
            {
                WelcomeForm welcomeForm = new WelcomeForm();
                this.Hide();
                welcomeForm.ShowDialog();
                AdminPanelForm dashboard = new AdminPanelForm();
                this.Hide();
                dashboard.ShowDialog();
            }
        }
        private bool ValidateInput(string email, string password)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Geçerli bir email adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool CheckUserInDatabase(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password AND IsAdmin = 1 AND IsActivated = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        string activationQuery = "SELECT IsActivated FROM Users WHERE Email = @Email";
                        using (SqlCommand activationCmd = new SqlCommand(activationQuery, conn))
                        {
                            activationCmd.Parameters.AddWithValue("@Email", email);
                            conn.Open();
                            bool isActivated = Convert.ToBoolean(activationCmd.ExecuteScalar());
                            conn.Close();

                            if (!isActivated)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı aktif değil. Email aktifleştirmek için yönlendiriliyorsunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ActivateEmailForm form = new ActivateEmailForm(email);
                                this.Hide();
                                form.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Mail veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return false;
                    }
                }
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            UserLoginForm loginForm = new UserLoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm form = new ResetPasswordForm();
            form.Tag = "Admin";
            this.Hide();
            form.ShowDialog();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm form = new UserRegisterForm();
            this.Hide();
            form.ShowDialog();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AdminLogin_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlue;
        }
        private void AdminLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AdminLogin_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}