using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KuCoinTradeBot
{
    public class Kucoin
    {
        static  HttpClient client = new HttpClient();
        static string BASE_ADDRESS = "";
        static string API_KEY = "";
        static string API_SECRET = "";
        static string API_PASSPHRASE = "";

        public static void SetupClient(string api_key, string api_secret, string api_passphrase)
        {
            API_KEY = api_key;
            API_SECRET = api_secret;
            API_PASSPHRASE = api_passphrase;
        }

        public static void GetAccounts()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{BASE_ADDRESS}/");
            request.Headers.Add("", "");
        }
    }
}
