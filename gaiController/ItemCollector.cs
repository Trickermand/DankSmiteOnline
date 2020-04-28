using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace gaiController
{
    public class ItemCollector
    {
        private List<Item> allItems;
        private List<Item> allBoots;
        private List<Item> allStarters;
        private List<Item> allRelics;
        private MapTypes selectedMapType;

        public ItemCollector(string _dropDownListValue)
        {
            selectedMapType = GetMapTypeFromString(_dropDownListValue);
            CreateAllItems();
        }

        private MapTypes GetMapTypeFromString(string mapTypeAsString)
        {
            if (mapTypeAsString.Equals("1"))
                return MapTypes.Conquest;
            else if (mapTypeAsString.Equals("2"))
                return MapTypes.Joust;
            else if (mapTypeAsString.Equals("3"))
                return MapTypes.Arena;
            else if (mapTypeAsString.Equals("4"))
                return MapTypes.Clash;
            else if (mapTypeAsString.Equals("5"))
                return MapTypes.Assualt;
            else if (mapTypeAsString.Equals("6"))
                return MapTypes.Siege;
            else
                return MapTypes.Conquest;
        }

        /// <summary>
        /// Retrieves all items for the chosen god type. Does not consider Katanas for hunters.
        /// </summary>
        /// <param name="legalItemColors">Legal items seleceted with the Checkboxes</param>
        /// <param name="godType">Curent God's type</param>
        /// <returns></returns>
        public List<Item> RetrieveLegalItems(List<ItemColorType> legalItemColors, GodType godType)
        {
            List<Item> legalItems = new List<Item> { };
            
            foreach (Item currentItem in allItems)
            {
                //Check if an items legal gods contains the current god
                //And checks if the item is of legal color, as selected from Checkboxes
                if (currentItem.godItemType.Contains(godType) && legalItemColors.Contains(currentItem.itemColorType) && currentItem.mapTypes.Contains(selectedMapType))
                {
                    legalItems.Add(currentItem);
                }
                
            }

            return legalItems;
        }

        /// <summary>
        /// Retrieves all boots for the chosen god damage type. There is no differentiation between dmg, hyb or def boots.
        /// </summary>
        /// <param name="legalItemColors">Legal items seleceted with the Checkboxes</param>
        /// <param name="godType">Curent God's type</param>
        /// <returns></returns>
        public List<Item> RetrieveLegalBoots(List<ItemColorType> legalItemColors, GodType godType)
        {
            List<Item> legalItems = new List<Item> { };

            foreach (Item currentItem in allBoots)
            {
                if (currentItem.godItemType.Contains(godType) && currentItem.mapTypes.Contains(selectedMapType))
                {
                    legalItems.Add(currentItem);
                }
            }
            return legalItems;
        }

        /// <summary>
        /// Retrieves all starter items. Dmg/hyb/def is NOT CONSIDERED!
        /// </summary>
        /// <param name="legalItemColors">Legal items seleceted with the Checkboxes</param>
        /// <param name="godType">Curent God's type</param>
        /// <returns></returns>
        public List<Item> RetrieveLegalStarters(List<ItemColorType> legalItemColors, GodType godType)
        {
            List<Item> legalItems = new List<Item> { };
            foreach (Item currentItem in allStarters)
            {
                if (currentItem.godItemType.Contains(godType) && currentItem.mapTypes.Contains(selectedMapType))
                {
                    legalItems.Add(currentItem);
                }
            }
            return legalItems;
        }

        /// <summary>
        /// Retrieves all relics. There is currently no diffentiation between relics, so all arguments are only for consistency.
        /// </summary>
        /// <returns></returns>
        public List<Item> RetrieveLegalRelics()
        {
            return allRelics;
        }

        public void CountItems()
        {
            int s1 = allItems.Count;
            Console.WriteLine("Normal items: "+s1);
            int s2 = allBoots.Count;
            Console.WriteLine("Boots: "+s2);
            int s3 = allRelics.Count;
            Console.WriteLine("Relics: "+s3);
            int s4 = allStarters.Count;
            Console.WriteLine("Starters: " + s4);

            Console.WriteLine("Total: {0}\n", s1 + s2 + s3 + s4);
                
        }



        public void CreateAllItems()
        {
            try
            {
                allStarters = GetItemListFromConfigPath(ConfigurationManager.AppSettings["PathOfStarterItemsConfig"]);
                allItems = GetItemListFromConfigPath(ConfigurationManager.AppSettings["PathOfNormalItemsConfig"]);
                allBoots = GetItemListFromConfigPath(ConfigurationManager.AppSettings["PathOfBootsConfig"]);
                allRelics = GetItemListFromConfigPath(ConfigurationManager.AppSettings["PathOfRelicsConfig"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Item> GetItemListFromConfigPath(string configPath)
        {
            string itemJsonAsString = ReadFile(configPath);

            JObject itemsInJObject = JObject.Parse(itemJsonAsString);
            List<Item> items = new List<Item>();

            foreach (var starterItem in itemsInJObject.First.First)
            {
                items.Add(CreateItemFromToken(starterItem));
            }
            return items;
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

        private Item CreateItemFromToken(JToken itemToken)
        {
            string name = itemToken.Value<string>("Name");
            string fileName = itemToken.Value<string>("FileName");
            string type = itemToken.Value<string>("AllowedGodTypes");
            string color = itemToken.Value<string>("Color");
            string allowedMaps = itemToken.Value<string>("AllowedMaps");

            return new Item(name, fileName, type, color, allowedMaps);
        }

    }
}
