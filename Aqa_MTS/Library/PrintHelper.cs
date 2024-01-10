using System.Collections;

namespace Library;

    internal class PrintHelper
    {
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                if (item is DictionaryEntry)
                {
                    // Обработка случая словаря
                    var entry = (DictionaryEntry)item;
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                }
                else
                {
                    // Обработка других случаев
                    Console.Write($"{item} ");
                }
            }
        }
    }