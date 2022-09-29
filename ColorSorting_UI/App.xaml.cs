using ColorSorting_API.BitmapHelper;
using ColorSorting_API.ColorSort;
using ColorSorting_API.Common.Sorting;
using ColorSorting_Services.BitmapHelper;
using ColorSorting_Services.ColorSort;
using ColorSorting_Services.Common.Sorting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace ColorSorting_UI
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services)=>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddTransient<IBitmapHelper, BitmapHelper>();
                    services.AddTransient<IColorSort_Service, ColorSort_Service>();
                    services.AddTransient<IQuickSort, QuickSort>();
                }).Build();
        }
        protected override  void OnStartup(StartupEventArgs e)
        {
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();
            base.OnStartup(e);
        }
        protected override  void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
