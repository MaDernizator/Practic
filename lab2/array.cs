// Include namespace system
public class Array
{
    public static void task5()
    {
        var arr = new int[]{1, 2, 3, 4, 5, 6, 7};
        foreach (var i in arr)
        {
            if ((i % 2) == 0)
            {
                Console.Write(i);
            }
        }
        foreach (var i in arr)
        {
            if ((i % 2) != 0)
            {
                Console.Write(i);
            }
        }
    }
    public static void task4()
    {
        var arr = new int[]{1, 2, 3, 3, 3, 4, 5, 5, 6, 7, 7, 7, 7, 7, 7};
        var len = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if ((arr[i - 1]) == arr[i])
            {
                len++;
            }
            else
            {
                Console.Write(len);
                len = 1;
            }
        }
        Console.Write(len);
    }
    public static void Main(string[] args)
    {
        task4();
        Console.WriteLine();
        task5();
    }
}