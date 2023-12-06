namespace TransportPark;

public class Transport
{
    public string TransportType { get; set; }
    public string TransportVid { get; set; }
    
    public string Address { get; set; }              //пункт назначения
    public int Number { get; set; }                  //номер автобуса
    public DateTime DepartureTime { get; set; }       //Время отправления
    public int numberSeats = 1;                        //Число мест
    
    //проверка, что число мест должно быть больше 0
    public int NumberSeats
    {
        get { return numberSeats; }
        set
        {
            if (value <1) Console.WriteLine("Число мест должно быть больше 0");
            else numberSeats = value;
        }
    }
    
    public Transport () {}
    
    public virtual string GetTransportInfo() => TransportType;

    public string PrintTransportInfo(string type)
    {
        return($"""
                Тип:    {TransportType}
                Вид:    {TransportVid}

                Номер:              {Number}
                Пункт назначения:   {Address}
                Время отправления   {DepartureTime}
                Число мест:         {numberSeats}
                =======
                """);
    }

    // "Определить метод в суперклассе, который нельзя будет переопределить
    // в классах наследниках и запретить это переопределение"
    //
    //Следующий метод нельзя переопределить, так как он не virtual / abstract
    //sead здесь не подходит, так как используется, если метод уже override
    public string GetTransportSubType() => TransportType;
}