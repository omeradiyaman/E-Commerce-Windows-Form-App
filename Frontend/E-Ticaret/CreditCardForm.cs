using DevExpress.XtraEditors;
using MailKit.Net.Smtp;
using MimeKit;
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
    public partial class CreditCardForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        public CreditCardForm(int userId, string name, string surname)
        {
            InitializeComponent();
            UserId = userId;
            Name = name;
            Surname = surname;
        }
        private async void btnAccept_Click(object sender, EventArgs e)
        {
            string creditCardNumber = txtCreditCardNumber.Text.Replace("-", "");
            string cardDate = txtCardDate.Text.Replace(".", "");
            string cvv = txtCvv.Text;
            if (!await ValidateInputAsync(creditCardNumber, cardDate, cvv))
            {
                return;
            }
            string email = await GetUserEmailAsync(UserId);
            if (string.IsNullOrEmpty(email))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı e-posta adresi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string resetCode = GenerateResetCode();

            if (await SaveCodeToDatabaseAsync(UserId, resetCode))
            {
                LoadingForm form = new LoadingForm();
                form.Show();
                await SendEmailAsync(email, resetCode);
                var activateForm = new CreditCardActivateForm(UserId, creditCardNumber, cardDate, cvv, Name, Surname);
                this.Hide();
                activateForm.ShowDialog();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Doğrulama kodu kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> SaveCodeToDatabaseAsync(int userId, string resetCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "UPDATE Users SET CreditCardActivationCode = @ResetCode, IsCreditCardActivated = 0 WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResetCode", resetCode);
                        command.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
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
                                                    color: #ffa500;
                                                    background-color: #333333;
                                                    padding: 15px;
                                                    text-align: center;
                                                    border-radius: 8px;
                                                    margin: 20px auto;
                                                    display: block; /*
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
                                                <h1>Sheezy - Kart Onaylama Kodu</h1>
                                                <p>Merhaba,</p>
                                                <p>Kartınızı kaydedebilmeniz için aşağıdaki onaylama kodunu kullanabilirsiniz:</p>
                                                <div class='code'>{resetCode}</div>
                                                <p>Bu kodu kullanarak kartınızı başarılı bir şekilde kaydedebilirsiniz.</p>
                                                <div class='footer'>
                                                    <p>Sheezy - Güvenli Alışveriş</p>
                                                    <p>Teşekkürler!</p>
                                                </div>
                                            </div>
                                        </body>
                                    </html>";
                message.Body = new TextPart("html") { Text = bodyHtml };
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("omeradiyaman1169@gmail.com", "wzws oljy wxvo pads");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                LoadingForm form = new LoadingForm();
                form.ShowDialog();
                DevExpress.XtraEditors.XtraMessageBox.Show("Onay kodu başarıyla e-posta adresinize gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"E-posta gönderiminde bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateResetCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private async Task<bool> ValidateInputAsync(string creditCardNumber, string cardDate, string cvv)
        {
            if (string.IsNullOrEmpty(creditCardNumber) || string.IsNullOrEmpty(cardDate) || string.IsNullOrEmpty(cvv))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (creditCardNumber.Length != 16 || !creditCardNumber.All(char.IsDigit))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kredi kartı numarası 16 haneli olmalı ve sadece rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidCardDate(cardDate))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kart tarihi geçerli bir formatta olmalı (MM.YY).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("CVV 3 haneli olmalı ve sadece rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidCardDate(string cardDate)
        {
            if (cardDate.Length != 4)
                return false;
            if (!int.TryParse(cardDate.Substring(0, 2), out int month) || month < 1 || month > 12)
                return false;
            if (!int.TryParse(cardDate.Substring(2, 2), out int year))
                return false;
            DateTime expiryDate = new DateTime(2000 + year, month, 1).AddMonths(1).AddDays(-1);
            DateTime today = DateTime.Now;
            return expiryDate >= today;
        }
        private void CreditCardForm_Load(object sender, EventArgs e)
        {

        }
        private void txtCreditCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAccept_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            UserCartForm form = new UserCartForm(UserId, Name, Surname);
            this.Hide();
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