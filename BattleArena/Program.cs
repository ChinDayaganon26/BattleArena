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
            Warrior Oliver = new Warrior();
            Oliver.Name = "Oliver";
            Oliver.Health = 100;
            Oliver.AttackPower = 30;

            Warrior Billy = new Warrior();
            Billy.Name = "Billy";
            Billy.Health = 150;
            Billy.AttackPower = 25;

            Console.WriteLine($"{Oliver.Name} has " +
                $"{Oliver.Health} health and {Oliver.AttackPower} " + $"attack power.");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Billy.Name} has" +
                $" {Billy.Health} health and {Billy.AttackPower} attack power.");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}

namespace BattleArena.Warriors
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
    }
}