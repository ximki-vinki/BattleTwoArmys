using System.Globalization;
using System.Reflection;
using BattleTwoArmys.Base;
using BattleTwoArmys.Model;

namespace BattleTwoArmys.ViewModel;

public class Chose
{
    public static void Language()
    {
        Prints.ChoseLanguage();
        var chosedNumberLang = Number(2);
        switch (chosedNumberLang)
        {
            case 1:
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
                break;
            case 2:
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-Ru");
                break;
        }
    }

    public static Type SubType(Type type)
    {
        var listOfTypes = Assembly.GetAssembly(type)?.GetTypes().Where(x => x.IsSubclassOf(type)).ToList();

        var countOfTypes = (listOfTypes ?? throw new InvalidOperationException("Type doesn't consist subtype"))
            .Count();

        Prints.ChoseType(type);

        for (var i = 0; i < countOfTypes; i++)
        {
            var name = NameType.Get(listOfTypes[i]);

            Console.WriteLine("{0} - {1}", i + 1, name);
        }

        var chosedNumberOfTypes = Number(countOfTypes);

        var outType = listOfTypes[chosedNumberOfTypes - 1];

        Console.WriteLine("{0} {1}", StringsMenu.GetString("YouChose"), NameType.Get(outType));

        return outType;
    }

    public static int Number(int maxNumber)
    {
        var chosedNumber = -1;

        var checkRightNumber = false;

        do
        {
            if (checkRightNumber) Console.WriteLine(StringsMenu.GetString("ChoseCorrectNumber"));

            // Console.WriteLine(StringsMenu.GetString("ChoseNumber"));

            var readLine = Console.ReadLine();

            checkRightNumber = int.TryParse(readLine, out var result);

            if (checkRightNumber) chosedNumber = int.Parse(readLine!);

            checkRightNumber = chosedNumber > maxNumber || chosedNumber < 1;
        } while (checkRightNumber);

        return chosedNumber;
    }

    public static Unit? UnitsArmy(int numberArmy)
    {
        switch (numberArmy)
        {
            case 1:
                Console.WriteLine(StringsMenu.GetString("RedArmy"));
                break;
            case 2:
                Console.WriteLine(StringsMenu.GetString("GreenArmy"));
                break;
            default:
                throw new Exception("Chose 1 or 2");
        }

        var subTypeUnit = SubType(typeof(Unit));
        return (Unit)Activator.CreateInstance(subTypeUnit)!;
    }
}