using BattleTwoArmys.Base;

namespace BattleTwoArmys.Model;

public class Army
{
    public string Name { get; set; } = null!;

    public List<Unit> UnitList { get; set; } = new();
}