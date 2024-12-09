using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BD_Kurs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Создаем сервисный провайдер
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Стартуем приложение с использованием DI
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>()); // MainForm — ваша главная форма
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Прямо задаём строку подключения
            var connectionString = "Server=.;Database=BD_Kurs;Integrated Security=true; TrustServerCertificate=True";

            // Регистрация DbContext
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(connectionString));

            // Регистрация форм
            services.AddTransient<Form1>();
        }
    }
}