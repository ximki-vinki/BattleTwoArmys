namespace BattleTwoArmys.Base;

public abstract class Unit
{
    public List<Attack> AllAttacks = new();
    public abstract string Name { get; }

    public int HitPoint { get; protected set; }


    public int UnitValue { get; protected set; } = 1;

    public int MaxInStack { get; protected set; } = 1;

    public Armor Armor { get; protected set; } = null!;


    public void TakeDamage(int damage)
    {
        if (HitPoint <= damage) HitPoint = 0;
        else HitPoint -= damage;
    }
}