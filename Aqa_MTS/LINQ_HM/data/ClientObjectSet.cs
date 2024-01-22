using System.Collections;
namespace LINQ_HM.data;

public class ClientObjectSet : IEnumerable<Сlient>
{
    public IEnumerator<Сlient> GetEnumerator()
    {
        var list = new List<Сlient>()
        {
            new Сlient(1, 2023, 1, 100),
            new Сlient(2, 2021, 9, 10),
            new Сlient(3, 2023, 5, 10),
            new Сlient(4, 2022, 1, 25),
            new Сlient(5, 2024, 4, 25),
            new Сlient(6, 2024, 8, 77),
            new Сlient(7, 2023, 3, 150)
        };

        foreach (var client in list)
        {
            yield return client;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}