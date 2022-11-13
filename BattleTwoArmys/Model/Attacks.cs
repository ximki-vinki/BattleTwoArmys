using BattleTwoArmys.Base;
using BattleTwoArmys.ViewModel;

namespace BattleTwoArmys.Model;

public class Punch : Attack
{
    protected internal Punch(int value) : base(value)
    {
    }

    public override string Name => StringsAttacks.GetString("Punch");
    public override string Action => StringsAttacks.GetString("Punches");
}

internal class SwordStrike : Attack
{
    protected internal SwordStrike(int value) : base(value)
    {
    }

    public override string Name => StringsAttacks.GetString("Strike");
    public override string Action => StringsAttacks.GetString("SwordStrike");
}