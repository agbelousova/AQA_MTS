namespace Products;
//Комплект (названия, цена, перечень продуктов)
internal class Equipment : Party
{
    public Equipment(string name, decimal price, DateTime productionDate, DateTime expirationDate) : base(name, price, productionDate, expirationDate)
    {
    }

    //метод для вывода информации о товарах, унаследованный от партии
    public override void PrintProductInfo()
    {
        Console.Write($"Наименование: {Name} \n");
        Console.Write("Цена: {0:c2}\n", Price);
        Console.Write(string.Format("Дата производства: {0}\n", ProductionDate.ToString("yyyy.MM.dd")));
        Console.Write(string.Format("Срок годности: {0}\n", ExpirationDate.ToString("yyyy.MM.dd")));
    }
}