﻿/*
 * Задание 1:
Дана целочисленная последовательность.
Извлечь из нее все нечетные числа, сохранив их исходный порядок
следования и удалив все вхождения повторяющихся элементов, кроме первых.

Задание 2:
Исходная последовательность содержит сведения о клиентах фитнес-центра.
Каждый элемент последовательности включает следующие целочисленные поля:
<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий (в часах)>;
Найти элемент последовательности с минимальной продолжительностью занятий.
Вывести эту продолжительность, а также соответствующие ей год и номер месяца
(в указанном порядке на той же строке).
Если имеется несколько элементов с минимальной продолжительностью,
то вывести данные того из них, который является последним в исходной последовательности.

Задание 3:
Дана строковая последовательность. Строки последовательности содержат только заглавные
буквы латинского алфавита. Отсортировать последовательность по возрастанию длин строк,
а строки одинаковой длины – по убыванию.

 */
using LINQ_HM;

public class Program
{
    static void Main()
    {
        //Заданиие 1
        Console.WriteLine($"\n----== Задача 1 ==----");
        new IntList().Run();

        //Заданиие 2
        Console.WriteLine($"\n\n----== Задача 2 ==----");
        new ClientList().Run();

        //Заданиие 3
        Console.WriteLine($"\n\n----== Задача 3 ==----");
        new StringList().Run();
    }
}