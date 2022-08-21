using HelpConfig;
using InfraStructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace SistemaLDA
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var servicesCollection = new ServiceCollection();
            ConfigureServices(servicesCollection);


            ServiceProvider = servicesCollection.BuildServiceProvider();

            var initForm = ServiceProvider.GetRequiredService<InitForm>();

            Application.Run(initForm);

        }

        static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<InitForm>()
            .AddSingleton<MainScreen>();

            HelpStartup.ConfigureSingleton(serviceCollection);
        }
    }
}
