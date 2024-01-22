using LINQ_HM.data;

namespace LINQ_HM;

public class IntList
{
    private IntSet _intSet = new IntSet();

    public void Run()
    {
        Console.WriteLine($"Начальная коллекция чисел:");
        PrintHelper.Print(_intSet);
        var newIntSet = _intSet.Where(number => number % 2 != 0).Select(number => number).Distinct();
        Console.WriteLine($"\nНовая коллекция чисел:");
        PrintHelper.Print(newIntSet);
    }
}