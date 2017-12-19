//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GodAndItemController
//{
//    public class Builder
//    {
//        static Item[] _build = new Item[9];
//        static God _god = new God("nope", "nope");
//        static List<God> legalGods;
//        static List<Item> legalItems;
//        static List<Item> legalBoots;
//        static List<Item> legalRelics;
//        static List<Item> legalStarters;
//        static GodCollector godCol = new GodCollector();
//        static ItemCollector itemCol = new ItemCollector();
//        private Random rnd = new Random();


//        public static Item[] Build
//        {
//            get { return _build; }
//            set { _build = value; }
//        }
//        public static God God
//        {
//            get { return _god; }
//            set { _god = value; }
//        }

//        static void Main(string[] args)
//        {

//        }

//        //Checkboxes with gods and itemcolours, sets _build to a full build, and _god to a god
//        public void fullRebuild(bool g, bool m, bool h, bool a, bool w, bool dmg, bool hyb, bool def)
//        {
//            //Choose god
//            int choice;
//            legalGods = godCol.retrieveLegalList(g, m, h, a, w);

//            choice = rnd.Next(legalGods.Count);
//            God = legalGods[choice];

//            legalBoots = itemCol.retrieveLegalBoots(dmg, hyb, def, God.type);
//            legalItems = itemCol.retrieveLegalItems(dmg, hyb, def, God.type);
//            legalRelics = itemCol.retrieveLegalRelics(dmg, hyb, def, God.type);
//            legalStarters = itemCol.retrieveLegalStarters(dmg, hyb, def, God.type);

//            for (int i = 0; i < 9; i++)
//            {
//                rerollItem(i);
//            }

//            #region old
//            ////Boots
//            //choice = rnd.Next(legalBoots.Count);
//            //Build[0] = legalBoots[choice];

//            ////Main build
//            //for (int i = 1; i < 6; i++)
//            //{
//            //    do
//            //    {
//            //        choice = rnd.Next(legalItems.Count);
//            //        itemCandidate = legalItems[choice];
//            //    } while (itemInBuild(itemCandidate) && (itemCandidate.isKatana && God.type.Equals("h")));
//            //}

//            ////Relics
//            //for (int i = 6; i < 7; i++)
//            //{
//            //    do
//            //    {
//            //        choice = rnd.Next(legalRelics.Count);
//            //        itemCandidate = legalRelics[choice];
//            //    } while (itemInBuild(itemCandidate));
//            //}

//            ////Starter
//            //if (true)
//            //{
//            //    do
//            //    {
//            //        choice = rnd.Next(legalRelics.Count);
//            //        itemCandidate = legalRelics[choice];
//            //    } while (itemInBuild(itemCandidate));
//            //}
//            #endregion
//        }
        

//        //Takes an int itemNumber:
//        //0: Boots
//        //1-5: Items
//        //6-7: Relics
//        //8: Starter
//        public void rerollItem(int itemNumber)
//        {
//            int choice;
//            Item itemCandidate;

//            //Boots
//            if (itemNumber == 0)
//            {
//                do
//                {
//                    choice = rnd.Next(legalBoots.Count);
//                    itemCandidate = legalBoots[choice];
//                } while (itemInBuild(itemCandidate));
//            }

//            //Normal items
//            else if (1 <= itemNumber && itemNumber < 6)
//            {
//                do
//                {
//                    choice = rnd.Next(legalItems.Count);
//                    itemCandidate = legalItems[choice];
//                } while (itemInBuild(itemCandidate) || (itemCandidate.isKatana && God.type.Equals("h")));
//            }

//            //Relics
//            else if (6 <= itemNumber && itemNumber < 8)
//            {
//                do
//                {
//                    choice = rnd.Next(legalRelics.Count);
//                    itemCandidate = legalRelics[choice];
//                } while (itemInBuild(itemCandidate));
//            }

//            //Fallback on starter item
//            else
//            {
//                do
//                {
//                    choice = rnd.Next(legalStarters.Count);
//                    itemCandidate = legalStarters[choice];
//                } while (itemInBuild(itemCandidate));
//            }

//            Build[itemNumber] = itemCandidate;
//        }

//        //Rerolls the god, taking into account whether or not Katanas are in the tree.
//        public void rerollGod()
//        {
//            bool isMag = false;
//            if (God.type.Equals("g") || God.type.Equals("m"))
//            {
//                isMag = true;
//            }

//            bool hasKatana = buildContainsKatana();
//            int choice;
//            God godCandidate;

//            if (isMag)
//            {
//                do
//                {
//                    choice = rnd.Next(legalGods.Count);
//                    godCandidate = legalGods[choice];
//                } while (  
//                           (   godCandidate.type.Equals("m")
//                            || godCandidate.type.Equals("g"))
//                        && !godCandidate.name.Equals(God.name)
//                         );

//            }
//            else
//            {
//                if (hasKatana)
//                {
//                    do
//                    {
//                        choice = rnd.Next(legalGods.Count);
//                        godCandidate = legalGods[choice];
//                    } while (  
//                               (   godCandidate.type.Equals("a")
//                                || godCandidate.type.Equals("w"))
//                            && !godCandidate.name.Equals(God.name)
//                                );
//                }
//                else
//                {
//                    do
//                    {
//                        choice = rnd.Next(legalGods.Count);
//                        godCandidate = legalGods[choice];
//                    } while (  
//                               (   godCandidate.type.Equals("h")
//                                || godCandidate.type.Equals("a")
//                                || godCandidate.type.Equals("w"))
//                            && !godCandidate.name.Equals(God.name)
//                                ) ;
//                }
//            }
//            God = godCandidate;
//        }


//        public bool itemInBuild(Item item)
//        {

//            foreach (Item builditem in Build)
//            {
//                if (builditem != null && builditem.name.Equals(item.name))
//                {
//                    return true;
//                }
//            }

//            return false;

//        }

//        public bool buildContainsKatana()
//        {
//            foreach (Item item in Build)
//            {
//                if (item.isKatana)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }
//}
