using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data.SqlClient;
using MimeKit;
using DevExpress.XtraEditors.TextEditController.Utils;
using MailKit.Net.Smtp;
namespace E_Ticaret
{
    public partial class UserRegisterForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private string TempVerificationCode;
        public UserRegisterForm()
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
        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-ZçÇşŞğĞüÜöÖıİ\s]+$");
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()\-_=+\[\]{};:'""\\|,.<>?])[A-Za-z\d!@#$%^&*()\-_=+\[\]{};:'""\\|,.<>?]{8,20}$");
        }


        private bool IsPasswordConfirmed(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        private bool ValidateForm(string firstName, string surname, string phoneNumber, string email, string password, string confirmPassword)
        {
            try
            {
                if (!IsValidName(firstName))
                {
                    throw new Exception("Ad sadece harflerden oluşmalı");
                }

                if (!IsValidName(surname))
                {
                    throw new Exception("Soyad sadece harflerden oluşmalı");
                }

                if (!IsValidEmail(email))
                {
                    throw new Exception($"Geçersiz mail adresi");
                }
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    throw new Exception("Telefon numarası 10 haneli ve rakamlardan oluşmalı!");
                }

                if (!IsValidPassword(password))
                {
                    throw new Exception("Şifre en az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 sembol içermeli ve 8-20 karakter uzunluğunda olmalı!");
                }

                if (!IsPasswordConfirmed(password, confirmPassword))
                {
                    throw new Exception("Şifre ve şifre onayı uyuşmuyor.");
                }

                return true;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private async void btn_Register_Click(object sender, EventArgs e)
        {
            string firstName = txtName.Text;
            string surname = txtSurname.Text;
            string phoneNumber = txtPhoneNumber.Text;
            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace("(", "");
            phoneNumber = phoneNumber.Replace(")", "");
            phoneNumber = phoneNumber.Replace(" ", "");
            string email = txtMail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (ValidateForm(firstName, surname, phoneNumber, email, password, confirmPassword))
            {
                try
                {
                    string activationCode = GenerateActivateCode();
                    bool isRegistered = await RegisterUserAsync(firstName, surname, phoneNumber, email, password, activationCode);

                    if (isRegistered)
                    {
                        await SendActivationCodeToEmailAsync(email, activationCode);
                        LoadingForm loadingForm = new LoadingForm();
                        this.Hide();
                        loadingForm.ShowDialog();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Mailinize Gönderilen Aktivasyon kodunu gelecek olan sayfada kullanınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActivateEmailForm form = new ActivateEmailForm(email);
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task<bool> RegisterUserAsync(string firstName, string surname, string phoneNumber, string email, string password, string activationCode)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    await con.OpenAsync();

                    string checkUserQuery = "SELECT ActivationCode, IsActivated FROM Users WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = await checkCmd.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                bool isActivated = reader.GetBoolean(reader.GetOrdinal("IsActivated"));
                                if (!isActivated)
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Bu e-posta zaten kayıtlı ancak aktivasyonu tamamlanmamış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActivateEmailForm form = new ActivateEmailForm(email);
                                    this.Hide();
                                    form.ShowDialog();
                                    return false;
                                }
                                else
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Bu e-posta adresi zaten aktif bir kullanıcıya ait.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }

                    string query = "INSERT INTO Users (Name, Surname, PhoneNumber, Email, Password, ActivationCode, IsActivated, IsAdmin, IsCreditCardActivated) VALUES (@Name, @Surname, @PhoneNumber, @Email, @Password, @ActivationCode, @IsActivated, @IsAdmin, @IsCreditCardActivated)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", firstName);
                        cmd.Parameters.AddWithValue("@Surname", surname);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ActivationCode", activationCode);
                        cmd.Parameters.AddWithValue("@IsActivated", false);
                        cmd.Parameters.AddWithValue("@IsAdmin", false);
                        cmd.Parameters.AddWithValue("@IsCreditCardActivated", false);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private string GenerateActivateCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private async Task SendActivationCodeToEmailAsync(string email, string resetCode)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sheezy", $"{email}"));
            message.To.Add(new MailboxAddress(email, email));
            message.Subject = "Aktivasyon KODU";
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
                                                    color: #ff6f20;
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
                                                <h1>Sheezy - Email Onaylama Kodu</h1>
                                                <p>Merhaba,</p>
                                                <p>Üye kaydınızı tamamlayabilmeniz için aşağıdaki onaylama kodunu kullanabilirsiniz:</p>
                                                <div class='code'>{resetCode}</div>
                                                <p>Bu kodu kullanarak üye kaydınızı başarılı bir şekilde tamamlayabilirsiniz.</p>
                                                <p>Üye olduğunuz için teşekkürler! Sheezy ailesine hoş geldiniz!</p>
                                                <div class='footer'>
                                                    <p>Sheezy - Güvenli Alışveriş</p>
                                                    <p>Teşekkürler!</p>
                                                </div>
                                            </div>
                                        </body>
                                    </html>";
            message.Body = new TextPart("html") { Text = bodyHtml };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("omeradiyaman1169@gmail.com", "wzws oljy wxvo pads");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            UserLoginForm loginForm = new UserLoginForm();
            this.Hide();
            loginForm.Show();
        }
        private void UserRegisterForm_Load(object sender, EventArgs e)
        {
        }
        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Register_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Register_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void UserRegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Register_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxLogin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = E_Ticaret.Properties.Resources.arrowRightBlue;
        }

        private void pictureBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = E_Ticaret.Properties.Resources.arrowRightBlack;

        }

        private void UserRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
