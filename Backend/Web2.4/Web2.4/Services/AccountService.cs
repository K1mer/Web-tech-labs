using Web2._4.Models;

namespace Web2._4.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddAccountService(this IServiceCollection services)
        {
            services.AddTransient<AccountService>();
        }
    }

    public class AccountService
    {
        static Dictionary<string, Dictionary<string, string>> _data = new();
        public static void SetAccountUserInfo(Dictionary<string, string> newData) => _data["UserInfo"] = newData;
        public static Dictionary<string, string> GetAccountUserInfo() => _data["UserInfo"];
        public static void SetAccountLoginInfo(Dictionary<string, string> newData) => _data["LoginInfo"] = newData;
    }
}
