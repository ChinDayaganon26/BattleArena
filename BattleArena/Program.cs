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
            Warrior Oliver = new Warrior("Raymond", 100, 30, "Dinuraan");
            Warrior Billy = new Warrior("Kirk", 200, 15, "Dinaganan");

            Oliver.DisplayStats();
            Billy.DisplayStats();

            while (Oliver.IsAlive && Billy.IsAlive)
            {
                Console.WriteLine($"------Round {round}------");
                Oliver.Attack(Billy);
                Billy.Attack(Oliver);
                Console.WriteLine("----------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}