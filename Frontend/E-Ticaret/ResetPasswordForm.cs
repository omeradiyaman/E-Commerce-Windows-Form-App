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
using MailKit;
using MimeKit;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace E_Ticaret
{
    public partial class ResetPasswordForm : DevExpress.XtraEditors.XtraForm
    {
        private bool IsCodeAlreadySent = false;
        private string newPassword;
        private string _txtEmail;
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        public ResetPasswordForm()
        {
            InitializeComponent();
        }
        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            string emailToCheck = txtEmail.Text;
            try
            {
                bool isEmailExists = await IsEmailExistsAsync(emailToCheck);

                if (isEmailExists)
                {
                    string resetCode = GenerateResetCode();
                    bool isCodeSent = await SaveResetCodeToDatabaseAsync(emailToCheck, resetCode);

                    if (isCodeSent)
                    {
                        LoadingForm form = new LoadingForm();
                        form.Show();
                        await SendEmailAsync(emailToCheck, resetCode);
                        _txtEmail = txtEmail.Text;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Şifre sıfırlama kodu e-posta adresinize gönderildi.Lütfen kodu kimseyle paylaşmayınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblActivationCode.Visible = true;
                        txtResetCode.Visible = true;
                        btnAcceptResetCode.Visible = true;

                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Kod gönderimi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bu e-posta sistemde kayıtlı değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<bool> IsEmailExistsAsync(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)await command.ExecuteScalarAsync();
                    return count > 0;
                }
            }
        }
        private async Task<bool> SaveResetCodeToDatabaseAsync(string email, string resetCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "UPDATE Users SET ResetPasswordCode = @ResetCode WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ResetCode", resetCode);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
        private async Task SendEmailAsync(string email, string resetCode)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sheezy", $"{email}"));
            message.To.Add(new MailboxAddress(email, email));
            message.Subject = "Şifre Sıfırlama Kodu";
            string bodyHtml = $@"
                                <html>
                                    <head>
                                        <style>
                                            body {{
                                                font-family: Arial, sans-serif;
                                                background-color: #ffffff;
                                                margin: 0;
                                                padding: 0;
                                            }}
                                            .container {{
                                                width: 100%;
                                                max-width: 600px;
                                                margin: 0 auto;
                                                background-color: #f9f9f9;
                                                padding: 30px;
                                                border-radius: 10px;
                                                box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
                                            }}
                                            h1 {{
                                                text-align: center;
                                                color: #ff6f20; /* Turuncu */
                                                font-size: 32px;
                                                margin-bottom: 20px;
                                                text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.1);
                                            }}
                                            p {{
                                                font-size: 16px;
                                                color: #333333;
                                                line-height: 1.6;
                                            }}
                                            .code {{
                                                font-size: 36px;
                                                font-weight: bold;
                                                color: #ffffff;
                                                background-color: #ffa500;
                                                padding: 15px;
                                                text-align: center;
                                                border-radius: 8px;
                                                margin: 20px auto;
                                                display: block;
                                                letter-spacing: 5px;
                                                box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2);
                                                width: fit-content;
                                            }}
                                            .footer {{
                                                text-align: center;
                                                font-size: 14px;
                                                color: #888888;
                                                margin-top: 30px;
                                            }}
                                        </style>
                                    </head>
                                    <body>
                                        <div class='container'>
                                            <h1>Sheezy - Şifre Sıfırlama Kodu</h1>
                                            <p>Merhaba,</p>
                                            <p>Şifrenizi sıfırlamak için aşağıdaki onaylama kodunu kullanabilirsiniz:</p>
                                            <div class='code'>{resetCode}</div>
                                            <p>Bu kodu kullanarak şifrenizi başarılı bir şekilde sıfırlayabilirsiniz.</p>
                                            <div class='footer'>
                                                <p>Sheezy - Güvenli Alışveriş</p>
                                                <p>Teşekkürler!</p>
                                            </div>
                                        </div>
                                    </body>
                                </html>";
            message.Body = new TextPart("html") { Text = bodyHtml };

            var image = E_Ticaret.Properties.Resources.sheezy;
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("omeradiyaman1169@gmail.com", "wzws oljy wxvo pads");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
        private string GenerateResetCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private async void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string resetCode = txtResetCode.Text;
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            txtEmail.ReadOnly = true;
            txtResetCode.ReadOnly = true;
            try
            {
                if (newPassword != confirmPassword)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidPassword(newPassword))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Şifre en az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 sembol içermeli ve 8-20 karakter uzunluğunda olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isValidCode = await ValidateResetPasswordCodeAsync(resetCode);

                if (isValidCode)
                {
                    bool isPasswordUpdated = await UpdateUserPasswordAsync(newPassword);

                    if (isPasswordUpdated)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Şifreniz başarıyla güncellenmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserLoginForm userLoginForm = new UserLoginForm();
                        this.Hide();
                        userLoginForm.ShowDialog();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Şifre güncellenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz şifre sıfırlama kodu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnAcceptResetCode_Click(object sender, EventArgs e)
        {
            string resetCode = txtResetCode.Text;
            try
            {
                if (!string.IsNullOrEmpty(resetCode))
                {
                    bool isResetCodeValid = await ValidateResetPasswordCodeAsync(resetCode);

                    if (isResetCodeValid)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Şifre sıfırlama kodu geçerli. Yeni şifrenizi girin.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblPassword.Visible = true;
                        lblConfirmPassword.Visible = true;
                        txtPassword.Visible = true;
                        txtConfirmPassword.Visible = true;
                        btnUpdatePassword.Visible = true;
                        pictureBoxConfirmPasswordHideShow.Visible = true;
                        pictureBoxPasswordHideShow.Visible = true;
                        txtEmail.ReadOnly = true;
                        txtResetCode.ReadOnly = true;
                        btnSendCode.Enabled = false;
                        btnAcceptResetCode.Enabled = false;
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz sıfırlama kodu. Lütfen kodu doğru giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen sıfırlama kodunu girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Bir hata oluştu : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()\-_=+\[\]{};:'""\\|,.<>?])[A-Za-z\d!@#$%^&*()\-_=+\[\]{};:'""\\|,.<>?]{8,20}$");
        }
        public async Task<bool> UpdateUserPasswordAsync(string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@Email", _txtEmail);

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
        public async Task<bool> ValidateResetPasswordCodeAsync(string resetCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT ResetPasswordCode FROM Users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", _txtEmail);
                    command.Parameters.AddWithValue("@ResetCode", resetCode);

                    var result = await command.ExecuteScalarAsync();

                    return result != null && result.ToString() == resetCode;
                }
            }
        }
        private void lblAlreadyHasACode_Click(object sender, EventArgs e)
        {

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
        private void pictureBoxConfirmPasswordHideShow_MouseHover(object sender, EventArgs e)
        {
            pictureBoxConfirmPasswordHideShow.Image = E_Ticaret.Properties.Resources.show;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
        private void pictureBoxConfirmPasswordHideShow_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxConfirmPasswordHideShow.Image = E_Ticaret.Properties.Resources.hide;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }
        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendCode_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtResetCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceptResetCode_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdatePassword_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                if (this.Tag.ToString() == "User")
                {
                    UserLoginForm userLoginForm = new UserLoginForm();
                    userLoginForm.Show();
                    this.Hide();
                }
                else if (this.Tag.ToString() == "Admin")
                {
                    AdminLoginForm adminLoginForm = new AdminLoginForm();
                    adminLoginForm.Show();
                    this.Hide();
                }
            }
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlack;
        }
    }
}