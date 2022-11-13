namespace BattleTwoArmys.ViewModel;

public class PrintConsole

{
    public class Line
    {
        public static void AllMinus()
        {
            var allMinus = new string('-', 100);
            Console.WriteLine(allMinus);
        }
    }
}