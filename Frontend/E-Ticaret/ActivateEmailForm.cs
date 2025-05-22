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
    public partial class ActivateEmailForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Server=MAHSUN;Initial Catalog=ETicaretDB;Integrated Security=True;TrustServerCertificate=True;";
        private string Email { get; set; }
        public ActivateEmailForm(string email)
        {
            InitializeComponent();
            Email = email;
            txtEmail.Text = Email;
            txtEmail.ReadOnly = true;
        }
        private async void btnAcceptActivationCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string activationCode = txtActivateCode.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(activationCode))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen e-posta ve aktivasyon kodunu doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    await con.OpenAsync();

                    string query = "SELECT IsActivated FROM Users WHERE Email = @Email AND ActivationCode = @ActivationCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ActivationCode", activationCode);

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && !(bool)result)
                        {
                            string updateQuery = "UPDATE Users SET IsActivated = 1 WHERE Email = @Email";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@Email", email);
                                await updateCmd.ExecuteNonQueryAsync();
                            }

                            DevExpress.XtraEditors.XtraMessageBox.Show("Aktivasyon başarılı! Giriş sayfasına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserLoginForm loginForm = new UserLoginForm();
                            this.Hide();
                            loginForm.ShowDialog();
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("E-posta veya aktivasyon kodu hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActivateEmailForm_Load(object sender, EventArgs e)
        {
        }
        private void txtActivateCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceptActivationCode_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            UserLoginForm loginForm = new UserLoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowLeftBlue;
        }
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = E_Ticaret.Properties.Resources.arrowBackBlue;
        }

        private void txtActivateCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}