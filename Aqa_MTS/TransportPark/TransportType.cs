namespace TransportPark;

internal class TransportElectric : Transport
{
    public TransportElectric() : base() => TransportType = "Электрический транспорт";

    public override string GetTransportInfo() => base.PrintTransportInfo("Электрический");
}

internal class TransportRail : Transport
{
    public TransportRail() : base() => TransportType = "Рельсовый транспорт";

    public override string GetTransportInfo() => base.PrintTransportInfo("Рельсовый");
}

internal class TransportAvtomobile : Transport
{
    public TransportAvtomobile() : base() => TransportType = "Автомобильный транспорт";

    public override string GetTransportInfo() => base.PrintTransportInfo("Автомобильный");
}