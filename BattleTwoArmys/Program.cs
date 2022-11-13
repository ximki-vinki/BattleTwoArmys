using System.Globalization;
using System.Reflection;
using BattleTwoArmys.Base;
using BattleTwoArmys.Model;
using System.Resources;
using Microsoft.VisualBasic;
using BattleTwoArmys.ViewModel;

internal class Program
{

    static void Main(string[] args)
    {

        //Chose.Language();

        var firstArmy = Chose.UnitsArmy(1);
        Prints.UnitAllInformation(firstArmy!);
        var secondArmy = Chose.UnitsArmy(2);

        Army aa = new Army();
        aa.Name = StringsMenu.GetString("RedArmy");
        aa.UnitList.Add( firstArmy);
        var aaa = aa.UnitList;
        (Unit, Unit) twoArmy = (firstArmy, secondArmy)!;

        Prints.TwoArmy(twoArmy);
        Console.WriteLine(StringsMenu.GetString("BattleBegin"));
        Console.ReadLine();
        Battle.Attack(firstArmy!, secondArmy!);
        Prints.TwoArmy(twoArmy);

    }




}