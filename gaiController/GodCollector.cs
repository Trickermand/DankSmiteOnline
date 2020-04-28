using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{
    public class GodCollector
    {
        private List<God> allGods;

        public GodCollector()
        {
            CreateAllGods();
        }

        public List<God> RetrieveLegalList()
        {
            return allGods;
        }

        public List<God> RetrieveLegalList(List<GodType> selectedGodTypes)
        {
            List<God> legalGods = new List<God> { };
            foreach (God _god in allGods)
            {
                if (selectedGodTypes.Contains(_god.godType))
                    legalGods.Add(_god);
            }
            return legalGods;
        }

        public List<string> RetrieveAllGodNames()
        {
            List<string> list = new List<string> { };
            list.Add("God");
            foreach (God _god in allGods)
            {
                list.Add(_god.name.Replace('_', ' '));
            }
            return list;
        }

        public void CountGods()
        {
            int g = 0;
            int m = 0;
            int h = 0;
            int a = 0;
            int w = 0;

            foreach (God _god in allGods)
            {
                if (_god.godType.Equals("g")) { g++; }
                else if (_god.godType.Equals("m")) { m++; }
                else if (_god.godType.Equals("h")) { h++; }
                else if (_god.godType.Equals("a")) { a++; }
                else if (_god.godType.Equals("w")) { w++; }
            }
            Console.WriteLine("Guardians: " + g);
            Console.WriteLine("Mages: " + m);
            Console.WriteLine("Hunters: " + h);
            Console.WriteLine("Assassins: " + a);
            Console.WriteLine("Warriors: " + w);
            Console.WriteLine("Total: {0}",g+m+h+a+w);

        }
        
        public void CreateAllGods()
        {
            try
            {
                allGods = GetGodsFromConfigPath(ConfigurationManager.AppSettings["PathOfGodsConfig"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private List<God> GetGodsFromConfigPath(string configPath)
        {
            string godJsonAsString = ReadFile(configPath);

            JObject itemsInJObject = JObject.Parse(godJsonAsString);
            List<God> gods = new List<God>();

            foreach (var starterItem in itemsInJObject.First.First)
            {
                gods.Add(CreateGodFromToken(starterItem));
            }
            return gods;
        }
        
        private God CreateGodFromToken(JToken itemToken)
        {
            string name = itemToken.Value<string>("Name");
            string fileName = itemToken.Value<string>("FileName");
            string type = itemToken.Value<string>("Type");
            
            return new God(name, type, fileName);
        }

        private string ReadFile(string path)
        {
            string content = "";
            using (StreamReader reader = new StreamReader(path))
            {
                content = reader.ReadToEnd();
            }
            return content;
        }

    }
}
