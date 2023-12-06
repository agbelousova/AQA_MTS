/*
// See https://aka.ms/new-console-template for more information

Создать класс, со следующими свойствами:
сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
    Определить get, set методы для этих свойств.

Создать класс с main методом, в котором будет объявлен объект класса Bus.
Вывести все данные (значения полей) объекта в консоль.

    - Определить иерархию классов в предметной области: Парк общественного траспорта.
    - Определить иерархию различных видов общественного транспорта
(например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.)
    - Определить в суперклассе (например, сlass Transport) метод, возвращающий
тип транспорта (Electric, Rail, и т.п.). Переопределить этот метод в классах
наследниках.
    - В классе с main методом создать массив объектов из различных видов транспорта.
Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
Запросить у пользователя время отправления и/или пункт назначения.
Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные
в консоль. Запросить у пользователя время отправления.
Вывести в консоль список транспорта, отправляющегося после заданного времени.

** Определить метод в суперклассе (e.g. Transport), который нельзя будет
переопределить в классах наследниках и запретить это переопределение.
** Создать класс TransportService. Определить внутри класса TransportService
метод printTransportType, который будет принимать объект типа Transport как параметр.
Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип
транспорта и вывести эту информацию на консоль.
** В main вызвать метод printTransportType несколько раз, передавая ему как
параметр объекты классов наследников (Bus, Trolleybus и т.д.)
*/


using TransportPark;
//Создать класс с main методом, в котором будет объявлен объект класса Bus. 
//Вывести все данные (значения полей) объекта в консоль.
internal partial class Program
{
    private static void Main(string[] args)
    {
        Bus bus = new("Москва", 5, new DateTime(2023, 11, 1), 20);
        Console.WriteLine(
            $"Автобус: Пункт назначения - {bus.Address}\nНомер - {bus.Number}\nВремя отправления - {bus.DepartureTime}\nЧисло мест - {bus.NumberSeats}");
        Console.WriteLine();


        //В классе с main методом создать массив объектов из различных видов транспорта.
        Transport[] transports = new Transport[]
        {
            new TransportVid.TransportTrolleybus(10, "Иваново", 15, new DateTime(2023, 7, 1)),
            new TransportVid.TransportBus(15, "Москва", 20, DateTime.Now),
            new TransportVid.TransportTram(10, "Иваново", 15, new DateTime(2023, 5, 1)),
            new TransportVid.TransportBus(15, "Москва"),
            new TransportVid.TransportBus(55, "Новгород", 55, DateTime.Now),
            new TransportVid.TransportTrolleybus(1, "Москва", 35, new DateTime(2023, 8, 11))
        };
            
        //Вызовем метод PrintTransportServise для объектов разных типов - сразу для отсортированного массива
        Console.WriteLine("Массив объектов из различных видов транспорта. Сортировка по количеству мест.");
        Console.WriteLine("------------------------------");
        var arraySorted = transports.OrderBy(key => key.numberSeats);
        foreach (Transport transport in arraySorted)
            TransportService.PrintTransportServise(transport);

        //Запросить у пользователя время отправления и/или пункт назначения.
        //Вывести в консоль список транспорта, отправляющегося после заданного времени.
        Console.WriteLine("Поиск маршрутов по дате отправления. Введите дату: ");
        string? data = Console.ReadLine();
        DateTime data2 = Convert.ToDateTime(data);
        Console.WriteLine("Поиск маршрутов по месту назначения. Введите пункт назначения: ");
        string? punkt = Console.ReadLine();

        int poisk = 1;
 
        foreach (Transport transport in transports)
            if (transport.DepartureTime >= data2 && transport.Address.ToLower() == punkt.ToLower() )
            {
                    TransportService.PrintTransportServise(transport);
                    poisk++;
            }
        
           if (poisk == 1)
           {
               Console.WriteLine("Маршрута на указанную дату и следующего до указанного пункта назначения НЕТ");
           }

    }
}


        