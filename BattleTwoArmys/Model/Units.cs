using BattleTwoArmys.Base;
using BattleTwoArmys.ViewModel;

namespace BattleTwoArmys.Model;

internal class Infantry : Unit
{
    public Infantry()
    {
        HitPoint = 4;
        UnitValue = 1;
        MaxInStack = 10;
        Armor = new ArmorLight();
        AllAttacks.Add(new SwordStrike(3));
    }

    public override string Name => StringsUnits.GetString("Infantry");
}

internal class Cavalery : Unit
{
    public Cavalery()
    {
        HitPoint = 5;
        UnitValue = 3;
        MaxInStack = 5;
        // Armor = new ArmorLight();
        AllAttacks.Add(new SwordStrike(5));
    }

    public override string Name => StringsUnits.GetString("Cavalery");
}

internal class Hero : Unit
{
    public Hero()
    {
        HitPoint = 20;

        UnitValue = 10;
        MaxInStack = 1;
        //Armor = new ArmorHero();

        AllAttacks.Add(new Punch(10));
    }

    public override string Name => StringsUnits.GetString("Hero");
}