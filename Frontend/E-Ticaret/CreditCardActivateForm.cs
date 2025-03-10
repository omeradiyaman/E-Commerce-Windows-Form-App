using DevExpress.XtraEditors;
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
    public partial class CreditCardActivateForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private int UserId { get; set; }
        private string CreditCardNumber { get; set; }
        public string CardDate { get; set; }
        public string Cvv { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public CreditCardActivateForm(int userId, string creditCardNumber, string cardDate, string cvv, string name, string surname)
        {
            InitializeComponent();
            UserId = userId;
            CreditCardNumber = creditCardNumber;
            CardDate = cardDate;
            Cvv = cvv;
            Surname = Surname;
            Name = Name;
        }
        private async void btnAccept_Click(object sender, EventArgs e)
        {
            string enteredCode = txtActivationCode.Text;
            if (string.IsNullOrEmpty(enteredCode))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen doğrulama kodunu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string savedCode = await GetSavedResetCodeAsync(UserId);
            if (savedCode == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Doğrulama kodu bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (enteredCode == savedCode)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Doğrulama başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool cardSaved = await SaveCreditCardAsync(UserId, CreditCardNumber, CardDate, Cvv);
                if (cardSaved)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Kredi kartı başarıyla kaydedildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserCartForm form = new UserCartForm(UserId, Name, Surname);
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Kredi kartı kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Geçersiz doğrulama kodu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> SaveCreditCardAsync(int userId, string creditCardNumber, string cardDate, string cvv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string checkQuery = "SELECT u.IsCreditCardActivated FROM Users u JOIN CreditCards c ON u.UserId = c.UserId WHERE u.UserId = @UserId AND c.CardNumber = @CardNumber";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserId", userId);
                        checkCommand.Parameters.AddWithValue("@CardNumber", creditCardNumber);

                        object isActiveObj = await checkCommand.ExecuteScalarAsync();
                        if (isActiveObj != null)
                        {
                            bool isActive = Convert.ToBoolean(isActiveObj);
                            if (isActive)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bu kredi kartı zaten aktif.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                            else
                            {
                                string updateQuery = @"
                                                    UPDATE CreditCards 
                                                    SET CardDate = @CardDate, CVV = @CVV, IsCreditCardActivated = 1 
                                                    WHERE UserId = @UserId AND CardNumber = @CardNumber;

                                                    UPDATE Users 
                                                    SET IsCreditCardActivated = 1 
                                                    WHERE UserId = @UserId";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@CardDate", cardDate);
                                    updateCommand.Parameters.AddWithValue("@CVV", cvv);
                                    updateCommand.Parameters.AddWithValue("@UserId", userId);
                                    updateCommand.Parameters.AddWithValue("@CardNumber", creditCardNumber);

                                    int rowsUpdated = await updateCommand.ExecuteNonQueryAsync();
                                    return rowsUpdated > 0;
                                }
                            }
                        }
                    }
                    string insertQuery = @"
                                        INSERT INTO CreditCards (UserId, CardNumber, CardDate, CVV) 
                                        VALUES (@UserId, @CardNumber, @CardDate, @CVV);

                                        UPDATE Users 
                                        SET IsCreditCardActivated = 1 
                                        WHERE UserId = @UserId";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserId", userId);
                        insertCommand.Parameters.AddWithValue("@CardNumber", creditCardNumber);
                        insertCommand.Parameters.AddWithValue("@CardDate", cardDate);
                        insertCommand.Parameters.AddWithValue("@CVV", cvv);

                        int rowsInserted = await insertCommand.ExecuteNonQueryAsync();
                        return rowsInserted > 0;
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private async Task<string> GetSavedResetCodeAsync(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "SELECT CreditCardActivationCode FROM Users WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        object result = await command.ExecuteScalarAsync();
                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        private async Task<bool> ActivateCreditCardAsync(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "UPDATE Users SET IsCreditCardActivated = 1 WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Aktivasyon hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void txtActivationCode_KeyDown(object sender, KeyEventArgs e)
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
            CreditCardForm form = new CreditCardForm(UserId, Name, Surname);
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

        private void CreditCardActivateForm_Load(object sender, EventArgs e)
        {

        }
    }
}