using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Dashboard
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dependency Injection'ı yapılandırma
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ServiceProvider üzerinden Form1'i başlatma
            var form1 = _serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // IHttpClientFactory için gerekli ayar
            services.AddHttpClient();
            // Form1'i DI ile kaydetme
            services.AddTransient<Form1>();
        }

    }
}
