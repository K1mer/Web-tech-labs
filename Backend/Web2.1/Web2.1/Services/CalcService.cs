using Microsoft.AspNetCore.Mvc;

namespace Web2._1.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }


    public class CalcService : Controller
    {
    }
}
