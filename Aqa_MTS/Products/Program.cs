// See https://aka.ms/new-console-template for more information
/*
Задание 2:
Реализовать полную структуру классов и их взаимосвязь продумать самостоятельно. 
    Исходные данные: база (массив) из n товаров задать непосредственно в коде (захардкодить);
Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, 
а также определить, соответствует ли она сроку годности на текущую дату;

Создать производные классы:
Продукт (название, цена, дата производства, срок годности),
Партия (название, цена, количество шт, дата производства, срок годности), 
Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, 
и определения соответствия сроку годности.

    Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, 
    а также организовать поиск просроченного товара (на момент текущей даты).
*/
namespace Products;

internal class Program
{
    static void Main(string[] args)
    {
        Product[] equipments =
        {
            new Equipment("Печенье", 100, new DateTime(2023, 01, 01), new DateTime(2023, 09, 01)),
            new Equipment("Торт", 750, new DateTime(2023, 12, 01), new DateTime(2023, 12, 31)),
            new Equipment("Торт", 250, new DateTime(2023, 11, 11), new DateTime(2023, 12, 31)),
            new Equipment("Колбаса", 500, new DateTime(2023, 09, 01), new DateTime(2023, 11, 15)),
            new Equipment("Молоко", 75, new DateTime(2023, 12, 01), new DateTime(2023, 12, 15))
        };

        //Вывод всей информации по товару на экран
        foreach (Equipment equipment in equipments)
        {
            equipment.PrintProductInfo();
            Console.WriteLine(equipment.IsValid(equipment.ExpirationDate) ? "--Товар годен--" : "--Товар просрочен--");
            Console.WriteLine();
        }
        
        //Поиск товаров с истекшим сроком годности
        Console.WriteLine($"Список просроченных товаров:");
        
        foreach (Equipment equipment in equipments)
        {
            if (!equipment.IsValid(equipment.ExpirationDate)) equipment.PrintProductInfo();
        }
    }
}