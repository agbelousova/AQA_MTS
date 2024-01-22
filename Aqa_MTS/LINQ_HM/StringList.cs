using LINQ_HM.data;
namespace LINQ_HM;

public class StringList
{
    private List<string> _stringSet = new List<string>()
    {
        "BIM", "TOM", "ALEX", "OLGA", "ANNA", "MIHA", "ANASTASIA", "ALEXANDER", "VIOLETTA"
    };

    public void Run()
    {
        Console.WriteLine($"Начальная коллекция строк:");
        PrintHelper.Print(_stringSet);
        var result = _stringSet.OrderBy(item => item.Length).ThenByDescending(item => item);
        Console.WriteLine($"\nОтсортрованная коллекция строк:");
        PrintHelper.Print(result);
    }
}