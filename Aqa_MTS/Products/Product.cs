namespace Products;
//Продукт (название, цена, дата производства, срок годности)
internal abstract class Product : IProductValid
{
    //абстрактные свойства Наименование и Цена продукта, которые можно реалиизовать в дочернем классе, поскольку они общие для партии и комплекта
    public abstract string Name { get; set; }

    public abstract decimal Price { get; set; }

    //абстрактный метод для вывода информаци по продукту, будет реализован в дочеррнем классе Партия продукта
    public abstract void PrintProductInfo();
    
    //виртуальный метод наследованный из интерфейса для опрределения срока годности, переопрределять его не будем в дочерних классах
    public virtual bool IsValid(DateTime expiriationDate)
    {
        //если срок годности продукта больше или равен текущей даты - вернуть true (годен), иначе продукт просрочен вернем false
        if (expiriationDate.CompareTo(DateTime.Today) >= 0) return true;
        else return false;
    }
}