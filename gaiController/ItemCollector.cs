using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{
    public class ItemCollector
    {
        private List<Item> allItems;
        private List<Item> allBoots;
        private List<Item> allStarters;
        private List<Item> allRelics;

        /// <summary>
        /// Retrieves all items for the chosen god type. Does not consider Katanas for hunters.
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="hyb"></param>
        /// <param name="def"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Item> retrieveLegalItems(bool dmg, bool hyb, bool def, string type)
        {
            List<Item> list = new List<Item> { };
            List<Item> list2 = new List<Item> { };

            //Mathces god damage type
            foreach (Item item in allItems)
            {
                if(    (type.Equals("g")||type.Equals("m"))&&item.isMag
                    || (type.Equals("h")||type.Equals("a")||type.Equals("w"))&&item.isPhy)
                {
                    list.Add(item);
                }
            }
            //Remove wrong item colors
            foreach (Item item in list)
            {
                if (dmg && item.itemColor.Equals("dmg"))
                {
                    list2.Add(item);
                }
                else if (hyb && item.itemColor.Equals("hyb"))
                {
                    list2.Add(item);
                }
                else if (def && item.itemColor.Equals("def"))
                {
                    list2.Add(item);
                }
            }

            return list2;
        }

        /// <summary>
        /// Retrieves all boots for the chosen god damage type. There is no differentiation between dmg, hyb or def boots.
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="hyb"></param>
        /// <param name="def"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Item> retrieveLegalBoots(bool dmg, bool hyb, bool def, string type)
        {
            List<Item> list = new List<Item> { };

            foreach (Item item in allBoots)
            {
                bool legalType = false;
                if ((type.Equals("m") || type.Equals("g")) && item.isMag)
                {
                    legalType = true;
                }
                else if ((type.Equals("h") || type.Equals("a") || type.Equals("w")) && item.isPhy)
                {
                    legalType = true;
                }

                if (legalType)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// Retrieves all starter items. Dmg/hyb/def is NOT CONSIDERED!
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="hyb"></param>
        /// <param name="def"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Item> retrieveLegalStarters(bool dmg, bool hyb, bool def, string type)
        {
            List<Item> list = new List<Item> { };
            foreach (Item item in allStarters)
            {
                if ((type.Equals("m") || type.Equals("g")) && item.isMag)
                {
                    list.Add(item);
                }
                else if ((type.Equals("h") || type.Equals("a") || type.Equals("w")) && item.isPhy)
                {
                    list.Add(item);
                }

            }
            return list;
        }

        /// <summary>
        /// Retrieves all relics. There is currently no diffentiation between relics, so all arguments are only for consistency.
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="hyb"></param>
        /// <param name="def"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Item> retrieveLegalRelics(bool dmg, bool hyb, bool def, string type)
        {
            List<Item> list = new List<Item> { };
            foreach (Item item in allRelics)
            {
                list.Add(item);
            }
            return list;
        }

        public void countItems()
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

        public ItemCollector()
        {
            createAllItems();
        }

        public void createAllItems()
        {
            allItems = new List<Item> { };
            allBoots = new List<Item> { };
            allStarters = new List<Item> { };
            allRelics = new List<Item> { };

            //Item class constructor is:
            //String name, String color, bool isMag, bool isPhy, bool isKatana
            //"dmg", "hyb", "def", damage, hybrid, defense

            //
            //=============================NORMAL ITEMS=============================//
            //

            //=============================Physical only=============================//
            allItems.Add(new Item("Gladiator's_Shield", "hyb", false, true, false));
            allItems.Add(new Item("Shifter's_Shield", "hyb", false, true, false));
            allItems.Add(new Item("Void_Shield", "hyb", false, true, false));

            allItems.Add(new Item("Ichaival", "dmg", false, true, false));
            allItems.Add(new Item("Silverbranch_Bow", "dmg", false, true, false));
            allItems.Add(new Item("Odysseus'_Bow", "dmg", false, true, false));
            allItems.Add(new Item("Atalanta's_Bow", "dmg", false, true, false));

            allItems.Add(new Item("Asi", "dmg", false, true, false));
            allItems.Add(new Item("Qin's_Sais", "dmg", false, true, false));
            allItems.Add(new Item("The_Executioner", "dmg", false, true, false));

            allItems.Add(new Item("Ancile", "hyb", false, true, false));
            allItems.Add(new Item("Runic_Shield", "hyb", false, true, false));

            allItems.Add(new Item("Runeforged_Hammer", "hyb", false, true, false));
            allItems.Add(new Item("Blackthorn_Hammer", "hyb", false, true, false));
            allItems.Add(new Item("Frostbound_Hammer", "hyb", false, true, false));

            allItems.Add(new Item("Soul_Eater", "dmg", false, true, false));
            allItems.Add(new Item("Devourer's_Gauntlet", "dmg", false, true, false));
            allItems.Add(new Item("Bloodforge", "dmg", false, true, false));

            allItems.Add(new Item("Hydra's_Lament", "dmg", false, true, false));
            allItems.Add(new Item("Transcendence", "dmg", false, true, false));

            allItems.Add(new Item("Brawler's_Beat_Stick", "dmg", false, true, false));
            allItems.Add(new Item("The_Crusher", "dmg", false, true, false));
            allItems.Add(new Item("Titan's_Bane", "dmg", false, true, false));
            allItems.Add(new Item("Jotunn's_Wrath", "dmg", false, true, false));

            allItems.Add(new Item("Poisoned_Star", "dmg", false, true, false));
            allItems.Add(new Item("Wind_Demon", "dmg", false, true, false));

            allItems.Add(new Item("Rage", "dmg", false, true, false));
            allItems.Add(new Item("Malice", "dmg", false, true, false));
            allItems.Add(new Item("Deathbringer", "dmg", false, true, false));

            //=============================Katanas=============================//
            allItems.Add(new Item("Heartseeker", "dmg", false, true, true));
            allItems.Add(new Item("Masamune", "dmg", false, true, true));
            allItems.Add(new Item("Stone_Cutting_Sword", "dmg", false, true, true));
            allItems.Add(new Item("Hastened_Katana", "dmg", false, true, true));

            //=============================Neutral items=============================//
            allItems.Add(new Item("Relic_Dagger", "hyb", true, true, false));
            allItems.Add(new Item("Winged_Blade", "hyb", true, true, false));
            allItems.Add(new Item("Witchblade", "hyb", true, true, false));
            allItems.Add(new Item("Toxic_Blade", "hyb", true, true, false));

            allItems.Add(new Item("Oni_Hunter's_Garb", "def", true, true, false));
            allItems.Add(new Item("Genji's_Guard", "def", true, true, false));
            allItems.Add(new Item("Shogun's_Kusari", "def", true, true, false));
            
            allItems.Add(new Item("Emperor's_Armor", "def", true, true, false));
            allItems.Add(new Item("Sovereignty", "def", true, true, false));
            allItems.Add(new Item("Midgardian_Mail", "def", true, true, false));
            allItems.Add(new Item("Mystical_Mail", "def", true, true, false));

            allItems.Add(new Item("Stone_of_Gaia", "def", true, true, false));
            allItems.Add(new Item("Shield_of_Regrowth", "def", true, true, false));
            allItems.Add(new Item("Gauntlet_of_Thebes", "def", true, true, false));
            allItems.Add(new Item("Mail_of_Renewal", "def", true, true, false));

            allItems.Add(new Item("Magi's_Blessing", "def", true, true, false));
            allItems.Add(new Item("Hide_of_the_Urchin", "def", true, true, false));
            allItems.Add(new Item("Spirit_Robe", "def", true, true, false));
            allItems.Add(new Item("Mantle_of_Discord", "def", true, true, false));

            allItems.Add(new Item("Heartward_Amulet", "def", true, true, false));
            allItems.Add(new Item("Pestilence", "def", true, true, false));
            allItems.Add(new Item("Bulwark_of_Hope", "def", true, true, false));

            allItems.Add(new Item("Spectral_Armor", "def", true, true, false));
            allItems.Add(new Item("Hide_of_the_Nemean_Lion", "def", true, true, false));
            allItems.Add(new Item("Breastplate_of_Valor", "def", true, true, false));

            //=============================Magical only=============================//
            allItems.Add(new Item("Dynasty_Plate_Helm", "hyb", true, false, false));
            allItems.Add(new Item("Celestial_Legion_Helm", "hyb", true, false, false));
            allItems.Add(new Item("Lotus_Crown", "hyb", true, false, false));
            allItems.Add(new Item("Jade_Emperor's_Crown", "hyb", true, false, false));

            allItems.Add(new Item("Stone_of_Binding", "hyb", true, false, false));
            allItems.Add(new Item("Void_Stone", "hyb", true, false, false));
            allItems.Add(new Item("Stone_of_Fal", "hyb", true, false, false));

            allItems.Add(new Item("Doom_Orb", "dmg", true, false, false));
            allItems.Add(new Item("Chronos'_Pendant", "dmg", true, false, false));
            allItems.Add(new Item("Rod_of_Tahuti", "dmg", true, false, false));

            allItems.Add(new Item("Spear_Of_The_Magus", "dmg", true, false, false));
            allItems.Add(new Item("Obsidian_Shard", "dmg", true, false, false));
            allItems.Add(new Item("Divine_Ruin", "dmg", true, false, false));
            allItems.Add(new Item("Spear_of_Desolation", "dmg", true, false, false));

            allItems.Add(new Item("Bancroft's_Talon", "dmg", true, false, false));
            allItems.Add(new Item("Polynomicon", "dmg", true, false, false));
            allItems.Add(new Item("Pythagorem's_Piece", "dmg", true, false, false));
            allItems.Add(new Item("Book_of_the_Dead", "dmg", true, false, false));

            allItems.Add(new Item("Demonic_Grip", "dmg", true, false, false));
            allItems.Add(new Item("Shaman's_Ring", "dmg", true, false, false));
            allItems.Add(new Item("Telkhines_Ring", "dmg", true, false, false));
            allItems.Add(new Item("Hastened_Ring", "dmg", true, false, false));

            allItems.Add(new Item("Rod_of_Asclepius", "dmg", true, false, false));
            allItems.Add(new Item("Warlock's_Sash", "dmg", true, false, false));
            allItems.Add(new Item("Ethereal_Staff", "dmg", true, false, false));
            allItems.Add(new Item("Gem_of_Isolation", "dmg", true, false, false));

            allItems.Add(new Item("Book_of_Thoth", "dmg", true, false, false));
            allItems.Add(new Item("Soul_Reaver", "dmg", true, false, false));

            //
            //=============================BOOTS=============================//
            //
            
            //Physical
            allBoots.Add(new Item("Warrior_Tabi", "dmg", false, true, false));
            allBoots.Add(new Item("Ninja_Tabi", "dmg", false, true, false));
            allBoots.Add(new Item("Talaria_Boots", "hyb", false, true, false));
            allBoots.Add(new Item("Reinforced_Greaves", "def", false, true, false));
            //Magical
            allBoots.Add(new Item("Shoes_of_the_Magi", "dmg", true, false, false));
            allBoots.Add(new Item("Shoes_of_Focus", "dmg", true, false, false));
            allBoots.Add(new Item("Traveler's_Shoes", "hyb", true, false, false));
            allBoots.Add(new Item("Reinforced_Shoes", "def", true, false, false));
            
            //
            //=============================STARTER ITEMS=============================//
            //

            //Physical
            allStarters.Add(new Item("Bluestone_Pendant", "dmg", false, true, false));
            allStarters.Add(new Item("Death's_Toll", "dmg", false, true, false));
            allStarters.Add(new Item("War_Flag", "dmg", false, true, false));
            //Magical
            allStarters.Add(new Item("Sands_Of_Time", "dmg", true, false, false));
            allStarters.Add(new Item("Soul_Stone", "dmg", true, false, false));
            allStarters.Add(new Item("Vampiric_Shroud", "dmg", true, false, false));
            //Neutral
            allStarters.Add(new Item("Bumba's_Mask", "dmg", true, true, false));
            allStarters.Add(new Item("Lono's_Mask", "def", true, true, false));
            allStarters.Add(new Item("Rangda's_Mask", "dmg", true, true, false));
            allStarters.Add(new Item("Mark_Of_The_Vanguard", "def", true, true, false));
            allStarters.Add(new Item("Swift_Wing", "hyb", true, true, false));
            allStarters.Add(new Item("Watcher's_Gift", "hyb", true, true, false));

            //
            //=============================RELICS=============================//
            //

            //dmg
            allRelics.Add(new Item("Belt_of_Frenzy", "dmg", true, true, false));
            allRelics.Add(new Item("Cursed_Ankh", "dmg", true, true, false));
            allRelics.Add(new Item("Sundering_Spear", "dmg", true, true, false));
            //hyb
            allRelics.Add(new Item("Blink_Rune", "hyb", true, true, false));
            allRelics.Add(new Item("Hand_of_the_Gods", "hyb", true, true, false));
            allRelics.Add(new Item("Heavenly_Wings", "hyb", true, true, false));
            allRelics.Add(new Item("Horrific_Emblem", "hyb", true, true, false));
            allRelics.Add(new Item("Teleport_Glyph", "hyb", true, true, false));
            //def
            allRelics.Add(new Item("Aegis_Amulet", "def", true, true, false));
            allRelics.Add(new Item("Bracer_of_Undoing", "def", true, true, false));
            allRelics.Add(new Item("Magic_Shell", "def", true, true, false));
            allRelics.Add(new Item("Meditation_Cloak", "def", true, true, false));
            allRelics.Add(new Item("Purification_Beads", "def", true, true, false));
            allRelics.Add(new Item("Shield_of_Thorns", "def", true, true, false));
            allRelics.Add(new Item("Phantom_Veil", "hyb", true, true, false));

        }
    }
}
