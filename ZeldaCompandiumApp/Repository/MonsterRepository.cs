using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaCompandiumApp.Model;

namespace ZeldaCompandiumApp.Repository
{
    internal class MonsterRepository
    {

        private static List<Monster> _monsters;

        public static List<Monster> GetMonsters()
        {
            if (_monsters != null) return _monsters;


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var resourceName = "ZeldaCompandiumApp.Resources.Json.CompandiumInfo.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
          
                    string json = reader.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<Dictionary<string, List<Monster>>>(json);
                    List<Monster> monsters = result["monsters"];


                    _monsters = monsters;

                    return monsters;
                }
            }

        }


        public static List<String> GetMonsterImages()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var resourceName = "ZeldaCompandiumApp.Resources.Json.CompandiumInfo.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<Dictionary<string, List<Monster>>>(json);
                    List<Monster> monsters = result["monsters"];

                    List<String> resultList = new List<string>();

                    for(int i = 0; i < monsters.Count; i++)
                    {
                        resultList.Add(monsters[i].Image);
                    }


                    return resultList;
                }
            }

        }

        

    }
}
