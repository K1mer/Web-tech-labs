namespace Web2._1.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }

    public class CalcService
    {
        static Random random = new Random();

        public int GetInt()
        {
            return (random.Next() % 11);
        }

        public string Add(int a, int b) => (a + b).ToString();
        public string Sub(int a, int b) => (a - b).ToString();
        public string Mult(int a, int b) => (a * b).ToString();
        public string Div(int a, int b) => b != 0 ? (a / b).ToString() : "Infinity";
    }
}
