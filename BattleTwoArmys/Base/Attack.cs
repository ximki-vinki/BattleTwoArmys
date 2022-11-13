namespace BattleTwoArmys.Base;

public abstract class Attack
{
    protected Attack(int value)
    {
        Value = value;
    }

    public int Value { get; protected set; }
    public abstract string Name { get; }

    public abstract string Action { get; }
}