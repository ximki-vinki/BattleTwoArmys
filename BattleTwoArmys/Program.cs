using BattleTwoArmys.Model;
using BattleTwoArmys.ViewModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Chose.Language();

        var firstArmy = new Army();
        firstArmy.Name = StringsMenu.GetString("RedArmy");
        firstArmy.UnitList.Add(Chose.UnitsArmy(1)!);
        Prints.UnitAllInformation(firstArmy.UnitList.First());
        var secondArmy = new Army();
        secondArmy.Name = StringsMenu.GetString("GreenArmy");
        secondArmy.UnitList.Add(Chose.UnitsArmy(2)!);

        (Army, Army) twoArmy = (firstArmy, secondArmy);
        Prints.TwoArmy(twoArmy);
        Console.WriteLine(StringsMenu.GetString("BattleBegin"));
        Console.ReadLine();
        Battle.Attack(firstArmy.UnitList.First(), secondArmy.UnitList.First());
        Prints.TwoArmy(twoArmy);
    }
}