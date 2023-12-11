namespace Products;
//Партия (название, цена, количество шт, дата производства, срок годности)
internal class Party : Product
{
    public Party(string name, decimal price, DateTime productionDate, DateTime expirationDate)
    {
        Name = name;
        Price = price;
        ProductionDate = productionDate;
        ExpirationDate = expirationDate;
    }

    public Party(string name, decimal price, int quantity, DateTime productionDate, DateTime expirationDate) : this(name, price, productionDate, expirationDate)
    {
        Quantity = quantity;
    }
    //колчество
    public int Quantity { get; set; }
    //дата производства
    public DateTime ProductionDate { get; set; }
    //годен до
    public DateTime ExpirationDate { get; set; }
    //реализовываем свойства парти название, цену и метод вывода информации о продукте, унаследованные от продукта
    public override string Name { get; set; }

    public override decimal Price { get; set; }
    public override void PrintProductInfo()
    {
        Console.WriteLine($"{Name} {Price} {Quantity} {ProductionDate} {ExpirationDate}");
    }
}