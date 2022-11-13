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

        var firstArmy = new Army();
        firstArmy.Name = StringsMenu.GetString("RedArmy");
        firstArmy.UnitList.Add( Chose.UnitsArmy(1)!);
        Prints.UnitAllInformation(firstArmy.UnitList.First());
        var secondArmy = new Army();
        firstArmy.Name = StringsMenu.GetString("GreenArmy");
        secondArmy.UnitList.Add(Chose.UnitsArmy(2)!);
        
        (Unit, Unit) twoArmy = (firstArmy.UnitList.First(), secondArmy.UnitList.First());
        Prints.TwoArmy(twoArmy);
        Console.WriteLine(StringsMenu.GetString("BattleBegin"));
        Console.ReadLine();
        Battle.Attack(firstArmy.UnitList.First(), secondArmy.UnitList.First());
        Prints.TwoArmy(twoArmy);

    }




}