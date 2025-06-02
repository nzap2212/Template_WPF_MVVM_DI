using Microsoft.Extensions.DependencyInjection;


namespace TemplateWPF_MVVM_DI.DI_Register
{
    public static class WindowRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
        }
    }
}
