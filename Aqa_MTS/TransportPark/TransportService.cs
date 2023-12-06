namespace TransportPark;
//Создать класс TransportService. Определить внутри класса TransportService
//метод printTransportType, который будет принимать объект типа Transport как параметр.
// Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип
//транспорта и вывести эту информацию на консоль.
    internal class TransportService
    {
        public static void PrintTransportServise(Transport transport)
        {
            Console.WriteLine(transport.GetTransportInfo()); 
        }
    }