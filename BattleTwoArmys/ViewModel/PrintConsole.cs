using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTwoArmys.ViewModel
{
    public class PrintConsole

    {
        public class Line
        {
            public static void AllMinus()
            {
                var allMinus = new string('-', 100);
                Console.WriteLine(allMinus);
            }
        }

    }
}
