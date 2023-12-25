using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop;

internal static class Helper
{
    public static void AddProduct(ref Dictionary<string, Product>? inventory, Product? item)
    {
        if (item is not null)
        {
            inventory.Add(Guid.NewGuid().ToString(), item);
        }
    }

    public static void DeleteProduct(ref Dictionary<string, Product>? items, string id)
    {
        Product value;

        if (items.Count != 0 || !string.IsNullOrEmpty(id))
        {
            if (items.TryGetValue(id, out value))
            {
                if (value is Product it)
                {
                    items.Remove(id);
                }
            }
            else
            {
                Console.WriteLine("Данный id отсутствует");
            }
        }
    }

    public static void UpdateProduct(ref Dictionary<string, Product>? inventory, string? id)
    {
        Product value;

        if (inventory.Count != 0 || !string.IsNullOrEmpty(id))
        {
            if (inventory.TryGetValue(id, out value))
            {
                if (value is Product item)
                {
                    Console.Write("Введите цену для обновления: ");
                    decimal price;

                    if (decimal.TryParse(Console.ReadLine().ToString(), out price))
                    {
                        item.PriceProduct = price;
                    }
                    Console.Write("Введите количество для обновления: ");
                    int quantity;

                    if (int.TryParse(Console.ReadLine().ToString(), out quantity))
                    {
                        item.QuantityProduct = quantity;
                    }
                }
            }
            else
            {
                Console.WriteLine("Данный id отсутствует");
            }
        }
    }

    public static void SearchByID(Dictionary<string, Product>? items, string? id)
    {
        Product value;

        if (items.Count != 0 || !string.IsNullOrEmpty(id))
        {
            if (items.TryGetValue(id, out value))
            {
                if (value is Product it)
                {
                    Console.WriteLine(
                        $"ID {id}: {it.NameProduct} цена: {it.PriceProduct}р. кол-во: {it.QuantityProduct}");
                }
            }
            else
            {
                Console.WriteLine("Данный id отсутствует");
            }
        }
    }

    public static void PrintProduct(Dictionary<string, Product> dictionary)
    {
        Console.WriteLine($"Продукты:");

        foreach (var pair in dictionary)
        {
            Console.Write($"ID: {pair.Key} ");

            if (pair.Value is Product item)
            {
                Console.Write(string.Format("Наименование: {0} ", item.NameProduct));
                Console.Write(string.Format("Цена: {0:C2} ", item.PriceProduct));
                Console.Write(string.Format("Количество: {0}", item.QuantityProduct));
                Console.WriteLine();
            }
        }
    }
}