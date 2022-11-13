using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BattleTwoArmys.Base;
using BattleTwoArmys.ViewModel;

namespace BattleTwoArmys.Model
{
    public class Punch : Attack
    {
        public override string Name => StringsAttacks.GetString("Punch");
        public override string Action => StringsAttacks.GetString("Punches");

        protected internal Punch(int value) : base(value)
        {
          
        }

    }

    class SwordStrike : Attack
    {
        public override string Name => StringsAttacks.GetString("Strike");
        public override string Action => StringsAttacks.GetString("SwordStrike");
        
        protected internal SwordStrike(int value) : base(value)
        {
           
        }
    }

}
