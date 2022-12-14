namespace BattleTwoArmys.Model;

public class NameType
{
    public static string? Get(Type type)
    {
        var createdType = Activator.CreateInstance(type);
        var name = type.GetProperty("Name")?.GetValue(createdType);
        if (name?.GetType() != typeof(string)) throw new Exception("Wrong type for name");
        return (string)name!;
    }
}