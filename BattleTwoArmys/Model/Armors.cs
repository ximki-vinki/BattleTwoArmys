using BattleTwoArmys.Base;

namespace BattleTwoArmys.Model;

internal class ArmorLight : Armor
{
    protected internal ArmorLight()
    {
        Name = "Light Armor";
        Defense = 5;
    }
}

internal class ArmorHero : Armor
{
    public ArmorHero()
    {
        Name = "Hero Armor";
        Defense = 15;
    }
}