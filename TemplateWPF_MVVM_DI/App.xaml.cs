using Microsoft.Extensions.DependencyInjection;

using System.Windows;
using TemplateWPF_MVVM_DI.DI_Register;

namespace TemplateWPF_MVVM_DI;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider serviceProvider;
    public App()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        WindowRegister.Register(services);
        ServicesRegister.Register(services);
        ViewModelRegister.Register(services);
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainwindow = serviceProvider.GetRequiredService<MainWindow>();
        mainwindow.Show();
        base.OnStartup(e);
    }
}

