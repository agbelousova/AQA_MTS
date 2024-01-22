namespace LINQ_HM.data;
public record Сlient(int Code, int Year, int Month, int DurationSport)
{
    public override string ToString()
    {
        return $"Code: {Code}, Year: {Year}, Month: {Month}, DurationSport: {DurationSport}";
    }

    // Добавить только при работе со сложными объектами
    public virtual bool Equals(Сlient? client)
    {
        return (Code == client.Code) && Year == client.Year && (Month == client.Month) && (DurationSport == client.DurationSport);
    }
    
    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => HashCode.Combine(Code, Year, Month, DurationSport);
}