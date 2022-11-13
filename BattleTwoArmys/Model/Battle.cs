using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleTwoArmys.Base;
using BattleTwoArmys.ViewModel;

namespace BattleTwoArmys.Model
{
    public class Battle
    {
        public static void Attack(Unit firstArmy, Unit secondArmy)
        {
            firstArmy.TakeDamage(secondArmy.AllAttacks.First().Value);
            PrintConsole.Line.AllMinus();
            Console.WriteLine("{0} {1} and give {2} damage", secondArmy.Name, secondArmy.AllAttacks.First().Action, secondArmy.AllAttacks.First().Value);
            secondArmy.TakeDamage(firstArmy.AllAttacks.First().Value);
            Console.WriteLine("{0} {1} and give {2} damage", firstArmy.Name, firstArmy.AllAttacks.First().Action, firstArmy.AllAttacks.First().Value);
            PrintConsole.Line.AllMinus();
        }
    }
}
