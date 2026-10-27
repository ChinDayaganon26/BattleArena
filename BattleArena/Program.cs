using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var Raymond = new Oliver(100, 30, 3);
            var Kirk = new Nicole(200, 15, 5);
            var Cods = new Billy(150, 30, 10);
            Oliver.DisplayStats();
            Nicole.DisplayStats();
            Billy.DisplayStats();

            while (Oliver.IsAlive && Nicole.IsAlive && Billy.IsAlive)
            {
                Console.WriteLine("\n\n----------------------------------------------");
                Oliver.Attack(Nicole);
                Nicole.DisplayStats();
                Console.WriteLine("----------------------------------------------");
                Billy.Attack(Oliver);
                Oliver.DisplayStats();
                Console.WriteLine("----------------------------------------------");
                Nicole.Attack(Billy);
                Billy.DisplayStats();
            }

            Console.ReadKey();
        }
    }
}