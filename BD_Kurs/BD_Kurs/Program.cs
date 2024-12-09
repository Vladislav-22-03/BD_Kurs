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
            // ������� ��������� ���������
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // �������� ���������� � �������������� DI
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>()); // MainForm � ���� ������� �����
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // ����� ����� ������ �����������
            var connectionString = "Server=.;Database=BD_Kurs;Integrated Security=true; TrustServerCertificate=True";

            // ����������� DbContext
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(connectionString));

            // ����������� ����
            services.AddTransient<Form1>();
        }
    }
}