using Dev_Ocean.Validation;
using DevOcean.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DevOcean_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new();
            services.AddTransient<ISpaceshipsService, SpaceshipsService>();
            services.AddTransient<IInputValidation, InputValidation>();
            services.AddTransient<Input>();
            var serviceProvider = GetServiceProvider(services);
            var input = serviceProvider.GetRequiredService<Input>();

            input.ReadInput();
        }

        public static ServiceProvider GetServiceProvider(IServiceCollection services)
        {
            return services.BuildServiceProvider();
        }
    }
}
