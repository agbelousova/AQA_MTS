/*
 Задание 2:
Напишите программу, используя Dictionary, чтобы управлять инвентарем товаров в магазине.
Ваша программа должна предоставлять следующие функциональности:
    Добавление товара: Каталог товаров генерируется на основании рандомных значений или
инициализируется конкретными данными. Информация о новом товаре, включает уникальный идентификатор,
название, цену и количество на складе.
    Отображение списка товаров: Пользователь может просматривать список всех товаров в магазине,
включая название, цену и количество на складе.
    Поиск товара по идентификатору: Пользователь может ввести уникальный идентификатор товара,
и программа должна отобразить информацию о товаре с этим идентификатором.
    Обновление информации о товаре: Пользователь может выбрать товар из списка и обновить
его цену или количество на складе.
    Удаление товара: Пользователь может выбрать товар из списка и удалить его из инвентаря.
*/

using System.Collections;
using Shop;

//Инициализация
Dictionary<string, Product>? productShop = new Dictionary<string, Product>() { };

for (int i = 1; i < 6; i++)
{
    Product item = new Product($"продукт{i}", 100.10M + i, 15 + i);
    Helper.AddProduct(ref productShop, item);
}

bool exitFlag = false;

while (!exitFlag)
{
    Console.Write(
        $"-= Магазин =-\n1 - Отображение списка товаров\n2 - Поиск товара по id\n3 - Обновлене информации товара\n4 - Удаление товара\n5 - Выход из программы\nВведите номер операции: ");

    switch (Console.ReadLine())
    {
        case "1":
        {
            Console.WriteLine("Начальный список товаров:");
            Helper.PrintProduct(productShop);
            break;
        }
        case "2":
        {
            Console.Clear();
            Console.Write("Введите id для поиска: ");
            string? searchId = Console.ReadLine().ToString();
            Console.WriteLine("Найдено:");
            Helper.SearchByID(productShop, searchId);
            break;
        }
        case "3":
        {
            Console.Write("Введите id обновления: ");
            string? updateId = Console.ReadLine().ToString();
            Helper.UpdateProduct(ref productShop, updateId);
            Helper.PrintProduct(productShop);
            break;
        }
        case "4":
        {
            Console.Write("Введите id для удаления: ");
            string? deletedId = Console.ReadLine().ToString();
            Helper.DeleteProduct(ref productShop, deletedId);
            Helper.PrintProduct(productShop);
            break;
        }
        case "5":
        {
            exitFlag = true;
            break;
        }
        default:
        {
            Console.WriteLine("Неверный номер операции (от 1 до 5)!");
            break;
        }
    }
}