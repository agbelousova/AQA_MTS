namespace TransportPark;

public class TransportVid
{
    internal class TransportTrolleybus : TransportElectric 
    {
        string transportVid = "Троллейбус";

        public TransportTrolleybus() : base() => TransportVid = transportVid;
        public TransportTrolleybus(int number) : this() => Number = number;
        public TransportTrolleybus(int number, string address) : this(number) => Address = address;
        public TransportTrolleybus(int number, string address, int numberSeats) : this(number, address) => NumberSeats = numberSeats;
        public TransportTrolleybus(int number, string address, int numberSeats, DateTime departureTime) : this(number, address, numberSeats) => DepartureTime = departureTime;

    }
    
    internal class TransportTram : TransportRail 
    {
        string transportVid = "Трамвай";

        public TransportTram() : base() => TransportVid = transportVid;
        public TransportTram(int number) : this() => Number = number;
        public TransportTram(int number, string address) : this(number) => Address = address;
        public TransportTram(int number, string address, int numberSeats) : this(number, address) => NumberSeats = numberSeats;
        public TransportTram(int number, string address, int numberSeats, DateTime departureTime) : this(number, address, numberSeats) => DepartureTime = departureTime;

    }
    
    internal class TransportBus : TransportAvtomobile 
    {
        string transportVid = "Автобус";

        public TransportBus() : base() => TransportVid = transportVid;
        public TransportBus(int number) : this() => Number = number;
        public TransportBus(int number, string address) : this(number) => Address = address;
        public TransportBus(int number, string address, int numberSeats) : this(number, address) => NumberSeats = numberSeats;
        public TransportBus(int number, string address, int numberSeats, DateTime departureTime) : this(number, address, numberSeats) => DepartureTime = departureTime;

    }

}