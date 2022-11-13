using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTwoArmys.Base
{
    public abstract class Armor
    {
        public string Name { get; protected set; } = null!;

        public int Defense { get; protected set; } = 1;
    }
}
