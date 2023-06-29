// Include namespace systems
public class Converter
{
    public static void Main(string[] args)
    {
        var number = Convert.ToInt64(Console.ReadLine());
        var system = Convert.ToInt64(Console.ReadLine());
        if (number == 0)
        {
        Console.WriteLine("0");
        Environment.Exit(0);
    }
    var alp = new String[]{"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
    var r = "";
        while (number > 0)
    {
        r = alp[(number % system)] + r;
        number = (int)(number / system);
    }
    Console.WriteLine(r);
    }
}