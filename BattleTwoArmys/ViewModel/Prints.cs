using BattleTwoArmys.Base;
using BattleTwoArmys.Model;

namespace BattleTwoArmys.ViewModel;

public class Prints
{
    private const int CursorPosition = 50;

    public static void UnitAllInformation(Unit unit)
    {
        PrintConsole.Line.AllMinus();
        UnitParameter.Name(unit);
        Console.Write("\n");
        UnitParameter.HitPoint(unit);
        Console.Write("\n");
        UnitParameter.Damage(unit);
        Console.Write("\n");
        PrintConsole.Line.AllMinus();
    }

    public static void UnitAllInformation(Unit firstUnit, Unit secondUnit)
    {
        PrintConsole.Line.AllMinus();
        UnitParameter.Name(firstUnit, secondUnit);
        UnitParameter.HitPoint(firstUnit, secondUnit);
        UnitParameter.Damage(firstUnit, secondUnit);
        PrintConsole.Line.AllMinus();
    }

    public static void UnitAllInformation(Unit unit, bool isRightPosition)
    {
        if (isRightPosition)
        {
            PrintConsole.Line.AllMinus();
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            UnitParameter.Name(unit);
            Console.Write("\n");
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            UnitParameter.HitPoint(unit);
            Console.Write("\n");
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            UnitParameter.Damage(unit);
            Console.Write("\n");
            PrintConsole.Line.AllMinus();
        }
        else
        {
            UnitAllInformation(unit);
        }
    }

    public static void ChoseLanguage()
    {
        Console.WriteLine(StringsMenu.GetString("ChoseLanguage"));
        Console.WriteLine("1.{0} ", StringsMenu.GetString("Language", "en-EN"));
        Console.WriteLine("2.{0} ", StringsMenu.GetString("Language", "ru-Ru"));
    }

    public static void ChoseType(Type type)
    {
        var typeString = type.Name;
        switch (typeString)
        {
            case "Unit":
                Console.WriteLine(StringsMenu.GetString("ChoseUnit"));
                break;
            default:
                throw new Exception("No such type for chose");
        }
    }

    public static void TwoArmy((Army first, Army second) army)
    {
        PrintConsole.Line.AllMinus();
        OneLineForTwoArmy(army.first.Name, army.second.Name);
        var maxCountUnit = Math.Max(army.first.UnitList.Count, army.second.UnitList.Count);
        var minCountUnit = Math.Min(army.first.UnitList.Count, army.second.UnitList.Count);
        for (var i = 0; i < maxCountUnit; i++)
            if (i < minCountUnit)
            {
                UnitAllInformation(army.first.UnitList[i], army.second.UnitList[i]);
            }
            else
            {
                var printRightArmy = army.first.UnitList.Count < army.second.UnitList.Count;
                if (printRightArmy)
                    UnitAllInformation(army.second.UnitList[i], printRightArmy);
                else
                    UnitAllInformation(army.first.UnitList[i]);
            }
    }

    private static void OneLineForTwoArmy(string firstArmyString, string secondArmyString)
    {
        Console.Write(firstArmyString);
        Console.SetCursorPosition(CursorPosition, Console.CursorTop);
        Console.Write(secondArmyString);
        Console.Write("\n");
    }

    public class UnitParameter
    {
        public static void Name(Unit unit)
        {
            Console.Write("{0} : {1}", StringsUnits.GetString("Name"), NameType.Get(unit.GetType()));
        }

        public static void Name(Unit firstUnit, Unit secondUnit)
        {
            Name(firstUnit);
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            Name(secondUnit);
            Console.Write("\n");
        }

        public static void HitPoint(Unit unit)
        {
            Console.Write("{0} : {1}", StringsUnits.GetString("HitPoints"), unit.HitPoint);
        }

        public static void HitPoint(Unit firstUnit, Unit secondUnit)
        {
            HitPoint(firstUnit);
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            HitPoint(secondUnit);
            Console.Write("\n");
        }

        public static void Damage(Unit unit)
        {
            Console.Write("{0} : {1}", StringsUnits.GetString("Damage"), unit.AllAttacks.First().Value);
        }

        public static void Damage(Unit firstUnit, Unit secondUnit)
        {
            Damage(firstUnit);
            Console.SetCursorPosition(CursorPosition, Console.CursorTop);
            Damage(secondUnit);
            Console.Write("\n");
        }
    }
    //public static void Battle()
}