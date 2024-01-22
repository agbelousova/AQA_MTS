using LINQ_HM.data;

namespace LINQ_HM;

public class ClientList
{
    private ClientObjectSet _clientObjectSet = new ClientObjectSet();

    public void Run()
    {
        Console.WriteLine("Клиент с наименьшими часами занятий:");
        
        var min = _clientObjectSet.Min(client => client.DurationSport);
        var result = _clientObjectSet.Where(client => client.DurationSport == min).Select(client =>
            new
            {
                client.DurationSport,
                client.Year,
                client.Month
            }).Last();

        Console.WriteLine($"Продолжительность занятий (в часах): {result.DurationSport}" +
                          $", Год: {result.Year}" +
                          $", Номер месяца: {result.Month}");
    }
}