using System;
using System.Globalization;
using System.Reflection;
using System.Resources;


namespace BattleTwoArmys.ViewModel
{
    public class StringsUnits
    {
        public static string GetString(string key)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsUnits",
             Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key) ?? throw new InvalidOperationException("Key is not found");
        }
        public static string GetString(string key, string lang)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsUnits",
                Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key, new CultureInfo(lang)) ?? throw new InvalidOperationException("Key or CultureInfo is not found");
        }

    }

    public class StringsMenu
    {
        public static string GetString(string key)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsMenu",
                Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key) ?? throw new InvalidOperationException("Key is not found");
        }
        public static string GetString(string key, string lang)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsMenu",
                Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key, new CultureInfo(lang)) ?? throw new InvalidOperationException("Key or CultureInfo is not found");
        }
    }
    public class StringsAttacks
    {
        public static string GetString(string key)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsAttacks",
                Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key) ?? throw new InvalidOperationException("Key is not found");
        }
        public static string GetString(string key, string lang)
        {
            var stringsUnits = new ResourceManager("BattleTwoArmys.Localization.StringsAttacks",
                Assembly.GetExecutingAssembly());

            return stringsUnits.GetString(key, new CultureInfo(lang)) ?? throw new InvalidOperationException("Key or CultureInfo is not found");
        }
    }



}
