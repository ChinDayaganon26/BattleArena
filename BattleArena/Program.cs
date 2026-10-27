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
            int round = 1;
            var Oliver = new Marksman("Oliver", 100, 30);
            var Billy = new Fighter("Billy", 200, 15);
            var Nicole = new Tank("Nicole", 150, 30);

            Oliver.DisplayStats();
            Billy.DisplayStats();
            Nicole.DisplayStats();

            while (Oliver.IsAlive && Billy.IsAlive && Nicole.IsAlive)
            {

                Oliver.Attack(Billy);
                Console.WriteLine("----------------------------------------------");
                Nicole.Attack(Oliver);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}