using System.Reflection;
using System.Resources;

namespace BattleTwoArmys.Base;

public abstract class LocModels
{
    private const string Path = "BattleTwoArmys.Localization";
    private const string PathRussian = "Russian";
    private const string PathEnglish = "English";
    private static ResourceManager? _rsManager;


    protected LocModels()
    {
        _rsManager = Thread.CurrentThread.CurrentCulture.Name switch
        {
            //Get the current manager based on the current Culture
            "ru-RU" => new ResourceManager($"{Path}.{PathRussian}.{Name}",
                Assembly.GetExecutingAssembly()),
            "en-EN" => new ResourceManager($"{Path}.{PathEnglish}.{Name}",
                Assembly.GetExecutingAssembly()),
            _ => _rsManager
        };
    }

    public abstract string Name { get; }

    public static string? GetString(string key)
    {
        return _rsManager?.GetString(key);
    }
}