namespace Number;
using System.Collections;
internal static class Helper
{
    public static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}