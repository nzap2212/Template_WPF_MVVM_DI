using Microsoft.Extensions.DependencyInjection;
using TemplateWPF_MVVM_DI.ViewModel;

namespace TemplateWPF_MVVM_DI.DI_Register
{
    public static class ViewModelRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<MainViewModel>();
        }
    }
}
