using System.Runtime.InteropServices.JavaScript;

namespace TransportPark;

public class Bus
{
    public string Address { get; set; }              //пункт назначения
    public int Number { get; set; }                  //номер автобуса
    private DateTime departureTime = DateTime.Now;     //Время отправления
    private int numberSeats = 1;                        //Число мест

    public Bus(string Address, int Number, DateTime departureTime, int numberSeats)
    {
       // Console.WriteLine($"Автобус: {Address}");
       this.Address = Address;
       this.Number = Number;
       this.departureTime = departureTime;
       this.numberSeats = numberSeats;
    }


    //проверка, что заданное время не больше текущей даты
    public DateTime DepartureTime
    {
        get { return departureTime; }
        set
        {
            if (value < DateTime.Now) Console.WriteLine("Дата поездки не может быть больше текущей даты!");
            else departureTime = value;
        }
    }
    //проверка, что чсло мест должно быть больше 0
    public int NumberSeats
    {
        get { return numberSeats; }
        set
        {
            if (value <1) Console.WriteLine("Число мест должно быть больше 0");
            else numberSeats = value;
        }
    }

}