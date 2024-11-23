using DevExpress.DataAccess.Json;
using E_Commerce.Application.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private int yol = 10;

        public Form1(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCustomComponents();
        }

        private async void InitializeCustomComponents()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7039/api/Product/GetTop3RatedProducts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductDto>>(jsonData);
                // Burada 'values' değişkenini kullanarak gerekli işlemleri yapabilirsiniz.
                foreach (var item in values)
                {
                    // Panel oluşturma
                    Panel panel = new Panel
                    {
                        Size = new Size(300, 400),
                        Location = new Point(yol, 10),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.LightGray
                    };
                    yol += 15 + 300;
                    // PictureBox oluşturma
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(260, 150),
                        Location = new Point(20, 20),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        //Image = Image.FromFile("path_to_image.jpg") // Resim yolunu belirtin
                    };

                    // Ürün açıklaması için Label oluşturma
                    Label descriptionLabel = new Label
                    {
                        Text = item.Name,
                        Location = new Point(20, 180),
                        Size = new Size(260, 50),
                        AutoSize = true
                    };

                    // Ücret yazısı için Label oluşturma
                    Label priceLabel = new Label
                    {
                        Text = item.Price.ToString(),
                        Location = new Point(20, 240),
                        Size = new Size(100, 20),
                        AutoSize = true
                    };

                    // Ücret girişi için TextBox oluşturma
                    Label markaLabel = new Label
                    {
                        Text = item.BrandName,
                        Location = new Point(20, 240),
                        Size = new Size(100, 20),
                        AutoSize = true
                    };

                    // Kaydet butonu
                    Button saveButton = new Button
                    {
                        Text = "Kaydet",
                        Location = new Point(100, 280),
                        Size = new Size(100, 30)
                    };

                    // Panel'e kontrolleri ekleme
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(descriptionLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(markaLabel);
                    panel.Controls.Add(saveButton);

                    // Form'a paneli ekleme
                    this.Controls.Add(panel);
                }
                
            }
            else
            {
                MessageBox.Show("Ürünleri getirirken bir hata oluştu.");
            }
        }

    }
}

