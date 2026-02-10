using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is not supposed to make sense

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Heads or Tails?");

            string headsOrTails = Console.ReadLine();

            List<string> coin = new List<string> { "You WIN", "You LOSE" };

            Random coin_toss = new Random();

            int index = coin_toss.Next(coin.Count);

            Console.WriteLine(coin[index]);

        }
    }
}
