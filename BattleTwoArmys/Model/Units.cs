using System.Reflection;
using System.Reflection.Metadata;
using BattleTwoArmys.Base;
using BattleTwoArmys.ViewModel;

namespace BattleTwoArmys.Model
{
    class Infantry : Unit
    {
        public override string Name => StringsUnits.GetString("Infantry");
        
        public Infantry()
        {
            HitPoint = 4;
            UnitValue = 1;
            MaxInStack = 10;
            Armor = new ArmorLight();
            AllAttacks.Add(new SwordStrike(3));
        }
    }
    class Cavalery : Unit
    {
        public override string Name => StringsUnits.GetString("Cavalery");


        public Cavalery()
        {
            HitPoint = 5;
            UnitValue = 3;
            MaxInStack = 5;
            // Armor = new ArmorLight();
            AllAttacks.Add(new SwordStrike(5));
        }
    }

    class Hero : Unit
    {
        public override string Name => StringsUnits.GetString("Hero");


        public Hero()
        {
            HitPoint = 20;

            UnitValue = 10;
            MaxInStack = 1;
            //Armor = new ArmorHero();

            AllAttacks.Add(new Punch(10));

        }
    }

}
