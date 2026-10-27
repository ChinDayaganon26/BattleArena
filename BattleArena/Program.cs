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
            Warrior Oliver = new Warrior("Oliver", 100, 30);
            Warrior Billy = new Warrior("Billy", 200, 15);

            Console.WriteLine($"{Oliver.Name} has " +
                $"{Oliver.Health} health and {Oliver.AttackPower} attack power.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{Billy.Name} has" +
                $" {Billy.Health} health and {Billy.AttackPower} attack power.");
            Console.WriteLine("---------------------------------");
            
            Console.ReadKey();
        }
    }
}