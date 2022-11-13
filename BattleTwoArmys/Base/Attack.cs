using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTwoArmys.Base
{
    public abstract class Attack
    {
        public int Value { get; protected set; } = 0;
        public abstract string Name { get; } 

        public abstract string Action { get; }
        protected Attack(int value)
        {
            Value = value;
        }
    }

}
