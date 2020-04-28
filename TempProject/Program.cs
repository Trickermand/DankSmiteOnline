using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GodsAndItems;

namespace TempProject
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<God> gods = SmiteGamepediaApi.GetAllGods();

            foreach (var god in gods)
            {
                Console.Write($"" +
                    $"{god.Name.PadRight(15)}" +
                    $"{god.Pantheon.PadRight(15)}" +
                    $"{god.AttackType.ToString().PadRight(15)}" +
                    $"{god.PowerType.ToString().PadRight(15)}" +
                    $"{god.GodClass.ToString().PadRight(15)}" +
                    $"{god.Difficulty.PadRight(15)}" +
                    $"{god.FavorCost.PadRight(15)}" +
                    $"{god.GemsCost.PadRight(15)}" +
                    $"{god.ReleaseDate.PadRight(15)}");
                Console.WriteLine();
            }


            Console.WriteLine("Complete...");
            Console.ReadLine();
        }
    }
}
