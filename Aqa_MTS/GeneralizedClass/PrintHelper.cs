namespace GeneralizedClass;

internal class PrintHelper
{
    public static void PrintArray<T>(T[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write($"{array[index]} ");
        }
        Console.WriteLine();
    }
}