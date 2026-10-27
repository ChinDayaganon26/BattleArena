using BattleArena.Enums;
using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Oliver = new Oliver(100, 30, 25, 10, TeamType.A);
            var Billy= new Billy(200, 15, 10, 30, TeamType.B);
            var Nicole = new Nicole(150, 20, 15, 10, TeamType.A);

            BattleArena.AddWarrior(Oliver);
            BattleArena.AddWarrior(Billy);
            BattleArena.AddWarrior(Nicole);

            BattleArena.StartBattle();
        }
    }
}