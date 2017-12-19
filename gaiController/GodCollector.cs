using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{
    public class GodCollector
    {
        private List<God> allGods;


        public List<God> retrieveLegalList(bool g, bool m, bool h, bool a, bool w)
        {
            List<God> list = new List<God> { };
            foreach (God _god in allGods)
            {
                if (   g && _god.type.Equals("g")
                    || m && _god.type.Equals("m")
                    || h && _god.type.Equals("h")
                    || a && _god.type.Equals("a")
                    || w && _god.type.Equals("w")
                    )
                        { list.Add(_god); }
            }
            return list;
        }

        public List<string> retrieveAllGodNames()
        {
            List<string> list = new List<string> { };
            list.Add("God");
            foreach (God _god in allGods)
            {
                list.Add(_god.name.Replace('_', ' '));
            }
            return list;
        }

        public void countGods()
        {
            int g = 0;
            int m = 0;
            int h = 0;
            int a = 0;
            int w = 0;

            foreach (God _god in allGods)
            {
                if (_god.type.Equals("g")) { g++; }
                else if (_god.type.Equals("m")) { m++; }
                else if (_god.type.Equals("h")) { h++; }
                else if (_god.type.Equals("a")) { a++; }
                else if (_god.type.Equals("w")) { w++; }
            }
            Console.WriteLine("Guardians: " + g);
            Console.WriteLine("Mages: " + m);
            Console.WriteLine("Hunters: " + h);
            Console.WriteLine("Assassins: " + a);
            Console.WriteLine("Warriors: " + w);
            Console.WriteLine("Total: {0}",g+m+h+a+w);

        }

        public GodCollector()
        {
            createAllGods();
        }

        public void createAllGods()
        {
            allGods = new List<God> { };

            allGods.Add(new God("Agni","m"));
            allGods.Add(new God("Ah_Muzen_Cab", "h"));
            allGods.Add(new God("Ah_Puch", "m"));
            allGods.Add(new God("Amaterasu", "w"));
            allGods.Add(new God("Anhur", "h"));
            allGods.Add(new God("Anubis", "m"));
            allGods.Add(new God("Ao_Kuang", "m"));
            allGods.Add(new God("Aphrodite", "m"));
            allGods.Add(new God("Apollo", "h"));
            allGods.Add(new God("Arachne", "a"));
            allGods.Add(new God("Ares", "g"));
            allGods.Add(new God("Artemis", "h"));
            allGods.Add(new God("Artio", "g"));
            allGods.Add(new God("Athena", "g"));
            allGods.Add(new God("Awilix", "a"));
            allGods.Add(new God("Bacchus", "g"));
            allGods.Add(new God("Bakasura", "a"));
            allGods.Add(new God("Bastet", "a"));
            allGods.Add(new God("Bellona", "w"));
            allGods.Add(new God("Cabrakan", "g"));
            allGods.Add(new God("Camazotz", "a"));
            allGods.Add(new God("Cernunnos", "h"));
            allGods.Add(new God("Chaac", "w"));
            allGods.Add(new God("Chang'e", "m"));
            allGods.Add(new God("Chiron", "h"));
            allGods.Add(new God("Chronos", "m"));
            allGods.Add(new God("Cu_Chulainn", "w"));
            allGods.Add(new God("Cupid", "h"));
            allGods.Add(new God("Da_Ji", "a"));
            allGods.Add(new God("Discordia", "m"));
            allGods.Add(new God("Erlang_Shen", "w"));
            allGods.Add(new God("Fafnir", "g"));
            allGods.Add(new God("Fenrir", "a"));
            allGods.Add(new God("Freya", "m"));
            allGods.Add(new God("Ganesha", "g"));
            allGods.Add(new God("Geb", "g"));
            allGods.Add(new God("Guan_Yu", "w"));
            allGods.Add(new God("Hachiman", "h"));
            allGods.Add(new God("Hades", "m"));
            allGods.Add(new God("He_Bo", "m"));
            allGods.Add(new God("Hel", "m"));
            allGods.Add(new God("Hercules", "w"));
            allGods.Add(new God("Hou_Yi", "h"));
            allGods.Add(new God("Hun_Batz", "a"));
            allGods.Add(new God("Isis", "m"));
            allGods.Add(new God("Izanami", "h"));
            allGods.Add(new God("Janus", "m"));
            allGods.Add(new God("Jing_Wei", "h"));
            allGods.Add(new God("Kali", "a"));
            allGods.Add(new God("Khepri", "g"));
            allGods.Add(new God("Kukulkan", "m"));
            allGods.Add(new God("Kumbhakarna", "g"));
            allGods.Add(new God("Kuzenbo", "g"));
            allGods.Add(new God("Loki", "a"));
            allGods.Add(new God("Medusa", "h"));
            allGods.Add(new God("Mercury", "a"));
            allGods.Add(new God("Ne_Zha", "a"));
            allGods.Add(new God("Neith", "h"));
            allGods.Add(new God("Nemesis", "a"));
            allGods.Add(new God("Nike", "w"));
            allGods.Add(new God("Nox", "m"));
            allGods.Add(new God("Nu_Wa", "m"));
            allGods.Add(new God("Odin", "w"));
            allGods.Add(new God("Osiris", "w"));
            allGods.Add(new God("Poseidon", "m"));
            allGods.Add(new God("Ra", "m"));
            allGods.Add(new God("Raijin", "m"));
            allGods.Add(new God("Rama", "h"));
            allGods.Add(new God("Ratatoskr", "a"));
            allGods.Add(new God("Ravana", "w"));
            allGods.Add(new God("Scylla", "m"));
            allGods.Add(new God("Serqet", "a"));
            allGods.Add(new God("Skadi", "h"));
            allGods.Add(new God("Sobek", "g"));
            allGods.Add(new God("Sol", "m"));
            allGods.Add(new God("Sun_Wukong", "w"));
            allGods.Add(new God("Susano", "a"));
            allGods.Add(new God("Sylvanus", "g"));
            allGods.Add(new God("Terra", "g"));
            allGods.Add(new God("Thanatos", "a"));
            allGods.Add(new God("The_Morrigan", "m"));
            allGods.Add(new God("Thor", "a"));
            allGods.Add(new God("Thoth", "m"));
            allGods.Add(new God("Tyr", "w"));
            allGods.Add(new God("Ullr", "h"));
            allGods.Add(new God("Vamana", "w"));
            allGods.Add(new God("Vulcan", "m"));
            allGods.Add(new God("Xbalanque", "h"));
            allGods.Add(new God("Xing_Tian", "g"));
            allGods.Add(new God("Ymir", "g"));
            allGods.Add(new God("Zeus", "m"));
            allGods.Add(new God("Zhong_Kui", "m"));

        }
    }
}
