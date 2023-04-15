using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZeldaCompandiumApp.Model;

namespace ZeldaCompandiumApp.Repository
{
    internal class MonsterRepositoryServer
    {
        private static List<Monster> _monsters;

        public static List<Monster> GetMonsters()
        {
            if (_monsters != null) return _monsters;

            string url = "https://raw.githubusercontent.com/RafiOsmanu/ZeldaCompandiumApp/main/ZeldaCompandiumApp/Resources/Json/CompandiumInfo.json"; // Replace with the URL of your JSON data

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string json = webClient.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<Dictionary<string, List<Monster>>>(json);
                    List<Monster> monsters = result["monsters"];

                    _monsters = monsters;

                    return monsters;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the download or parsing process
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
