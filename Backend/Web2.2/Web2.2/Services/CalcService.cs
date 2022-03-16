using System.ComponentModel.DataAnnotations;

namespace Web2._2.Services
{
    public enum Operation
    {
        [Display(Name = "+")]
        Add,
        [Display(Name = "-")]
        Sub,
        [Display(Name = "*")]
        Mult,
        [Display(Name = "/")]
        Div
    }

    public static class ServiceProviderExtensions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }

    public class CalcService
    {
        public static string Add(int a, int b) => (a + b).ToString();
        public static string Sub(int a, int b) => (a - b).ToString();
        public static string Mult(int a, int b) => (a * b).ToString();
        public static string Div(int a, int b) => b != 0 ? (a / b).ToString() : "Infinity";
    }
}
