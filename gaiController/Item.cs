using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{

    public enum ItemColorType
    {
        Damage,
        Hybrid,
        Defense,
        NoColor
    }

    public enum MapTypes
    {
        Arena,
        Assualt,
        Clash,
        Conquest,
        Joust,
        Siege
    }


    public class Item
    {
        public string name;
        public List<GodType> godItemType;
        public string fileName;
        public ItemColorType itemColorType;
        public List<MapTypes> mapTypes;

        /// <summary>
        /// Creates an instance of an Item
        /// </summary>
        /// <param name="_name">Name of the Item</param>
        /// <param name="_godItemType">The type Gods that are allowed to use this Item</param>
        /// <param name="_itemColorType">The damage color of the Item. Can be Damage/Hybrid/Defense/NoColor</param>
        /// <param name="_mapType">The maps the Item are allowed</param>
        public Item(string _name, string _fileName, GodType _godItemType, ItemColorType _itemColorType, MapTypes _mapType)
        {
            this.name = _name;
            this.fileName = _fileName;
            this.godItemType = new List<GodType>() { _godItemType };
            this.itemColorType = _itemColorType;
            this.mapTypes = new List<MapTypes>() { _mapType };
        }

        public Item(string _name, string _fileName, string _godItemTypes, string _itemColorType, string _mapTypes)
        {
            this.name = _name;
            this.fileName = _fileName;
            this.godItemType = CreateGodItemTypeListFromString(_godItemTypes);
            this.itemColorType = ItemColorTypeFromString(_itemColorType);
            this.mapTypes = CreateMapTypesListFromString(_mapTypes);
        }

        private ItemColorType ItemColorTypeFromString(string itemColor)
        {
            if (itemColor.Equals("damage", StringComparison.CurrentCultureIgnoreCase))
                return ItemColorType.Damage;
            else if (itemColor.Equals("hybrid", StringComparison.CurrentCultureIgnoreCase))
                return ItemColorType.Hybrid;
            else if (itemColor.Equals("defense", StringComparison.CurrentCultureIgnoreCase))
                return ItemColorType.Defense;
            else
                return ItemColorType.NoColor;
        }

        private List<GodType> CreateGodItemTypeListFromString(string godItemType)
        {
            List<GodType> godTypes = new List<GodType>();
            if (godItemType.Equals("all", StringComparison.CurrentCultureIgnoreCase))
            {
                godTypes.Add(GodType.Assassin);
                godTypes.Add(GodType.Guardian);
                godTypes.Add(GodType.Hunter);
                godTypes.Add(GodType.Mage);
                godTypes.Add(GodType.Warrior);
            }
            else if (godItemType.Equals("physical", StringComparison.CurrentCultureIgnoreCase))
            {
                godTypes.Add(GodType.Assassin);
                godTypes.Add(GodType.Hunter);
                godTypes.Add(GodType.Warrior);
            }
            else if (godItemType.Equals("magical", StringComparison.CurrentCultureIgnoreCase))
            {
                godTypes.Add(GodType.Guardian);
                godTypes.Add(GodType.Mage);
            }
            else
            {
                string[] godTypesAsStringArr = godItemType.Split(';');

                foreach (var godTypesAsString in godTypesAsStringArr)
                {
                    if (godTypesAsString.Equals("mage", StringComparison.CurrentCultureIgnoreCase))
                        godTypes.Add(GodType.Mage);

                    if (godTypesAsString.Equals("guardian", StringComparison.CurrentCultureIgnoreCase))
                        godTypes.Add(GodType.Guardian);

                    if (godTypesAsString.Equals("hunter", StringComparison.CurrentCultureIgnoreCase))
                        godTypes.Add(GodType.Hunter);

                    if (godTypesAsString.Equals("assassin", StringComparison.CurrentCultureIgnoreCase))
                        godTypes.Add(GodType.Assassin);

                    if (godTypesAsString.Equals("warrior", StringComparison.CurrentCultureIgnoreCase))
                        godTypes.Add(GodType.Warrior);
                }
            }

            return godTypes;
        }

        private List<MapTypes> CreateMapTypesListFromString(string inputMapTypes)
        {
            List<MapTypes> mapTypes = new List<MapTypes>();
            if (inputMapTypes.Equals("all", StringComparison.CurrentCultureIgnoreCase))
            {
                mapTypes.Add(MapTypes.Arena);
                mapTypes.Add(MapTypes.Assualt);
                mapTypes.Add(MapTypes.Clash);
                mapTypes.Add(MapTypes.Conquest);
                mapTypes.Add(MapTypes.Joust);
                mapTypes.Add(MapTypes.Siege);
            }
            else
            {
                string[] mapTypesAsStringArr = inputMapTypes.Split(';');

                foreach (var mapTypesAsString in mapTypesAsStringArr)
                {
                    if (mapTypesAsString.Equals("arena", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Arena);

                    if (mapTypesAsString.Equals("assault", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Assualt);

                    if (mapTypesAsString.Equals("clash", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Clash);

                    if (mapTypesAsString.Equals("conquest", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Conquest);

                    if (mapTypesAsString.Equals("joust", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Joust);

                    if (mapTypesAsString.Equals("siege", StringComparison.CurrentCultureIgnoreCase))
                        mapTypes.Add(MapTypes.Siege);
                }
            }

            return mapTypes;
        }

    }
    
}

