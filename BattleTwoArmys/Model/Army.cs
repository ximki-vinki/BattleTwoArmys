using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleTwoArmys.Base;

namespace BattleTwoArmys.Model
{
    internal class Army
    {
        public string Name { get; set; } = null!;

        public List<Unit> UnitList { get; set; } = null!;
    }
}
