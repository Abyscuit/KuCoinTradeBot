using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuCoinTradeBot
{
    public class Config
    {
        public string KUCOIN_APIKEY, KUCOIN_APISECRET, KUCOIN_APIPASSPHRASE;
        public bool EXIT_MESSAGE;

        public void LoadConfig()
        {
            string filename = "Settings.ini";
            string fullpath = Directory.GetCurrentDirectory() + $"\\{filename}";
            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(fullpath));
            KUCOIN_APIKEY = config.KUCOIN_APIKEY;
            KUCOIN_APISECRET = config.KUCOIN_APISECRET;
            KUCOIN_APIPASSPHRASE = config.KUCOIN_APIPASSPHRASE;
        }
        public static void SaveConfig()
        {
            string filename = "Settings.ini";
            string fullpath = Directory.GetCurrentDirectory() + $"\\{filename}";
            File.WriteAllText(fullpath, JsonConvert.SerializeObject(Form1.config, Formatting.Indented));
        }
    }
}
