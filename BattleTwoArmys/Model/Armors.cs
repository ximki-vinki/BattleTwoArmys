using BattleTwoArmys.Base;

namespace BattleTwoArmys.Model
{
     class ArmorLight : Armor
    {
        protected internal ArmorLight()
        {
            Name = "Light Armor";
            Defense = 5;
        }
    }

    class ArmorHero : Armor
    {
        public ArmorHero()
        {
            Name = "Hero Armor";
            Defense = 15;
        }
    }
}
