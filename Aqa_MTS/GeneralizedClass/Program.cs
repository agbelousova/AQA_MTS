/*
Задание 2:
Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
Также, данный класс должен иметь методы для добавления данных в массив,
удаления из массива, получения элемента из массива по индексу и метод,
возвращающий длину массива.

Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
*/

namespace GeneralizedClass;

internal class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        ArrayGeneric<int> arrayInt = new ArrayGeneric<int>(5);

        for (int i = 0; i < arrayInt.Length; i++)
        {
            arrayInt.ArrayValues[i] = random.Next(2);
        }

        Console.WriteLine("Созданный массив со значениями типа int:");
        PrintHelper.PrintArray(arrayInt.ArrayValues);

        Console.WriteLine($"Элемент массива по индексу 3: {arrayInt.GetByIndex(3)}, длина массива: {arrayInt.GetLenth()}");

        arrayInt.Add(random.Next(3));
        Console.WriteLine("Массив со значениями типа int после добавления нового элемента:");
        PrintHelper.PrintArray(arrayInt.ArrayValues);

        arrayInt.Remove(1);
        Console.WriteLine("Массив со значениями типа int после удаления значения 1:");
        PrintHelper.PrintArray(arrayInt.ArrayValues);
    }
}