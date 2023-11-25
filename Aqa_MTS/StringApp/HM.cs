using System.Text;

namespace StringApp
{
    static class HM
    {
        static void Main(string[] args)
        {
            //Задание 1:
            // Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

            Console.WriteLine("\n================\n");
            
            string str = "10test5ew0dwe00dte1sttestwewefef1550test5dvs45test515dstesteftecf540test";
            string fstr = "test";
            string insertStr = "testing";
            Console.WriteLine($"Изначальная строка: \n{str}");
            
            string replacedString1 = str.Replace("test", "testing");
            Console.WriteLine($"Новая строка с заменой: 'test' на 'testing':\n{replacedString1}");

                for (int i = 0; i < replacedString1.Length; i++)
              {
                   if (char.IsDigit(replacedString1[i]))
                  {
                       string removedSubstring2 = replacedString1.Remove(i, 1);
                       replacedString1 = removedSubstring2;
                           i -= 1;
                  }
               }
                Console.WriteLine($"Новая строка без цифр: \n{replacedString1}");

                Console.WriteLine("\n================\n");
            //Задание 2
            // Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
            // Welcome to the TMS lesons.
            //     Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова

            Console.WriteLine("\"Welcome\" " + "\"to\" " + "\"the\" "+ "\"TMS\" "+ "\"lesons\".");
            Console.WriteLine("\n================\n");
            // Задание 3
            // Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
            //Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
            //    Результат вывести в консоль.

            
            string str1 = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            Console.WriteLine($"Строка = {str1}");
            int startIndex = str1.IndexOf("abc");
            string str12 = str1.Substring(0, startIndex);
            string str13 = str1.Substring(startIndex+3);
            Console.WriteLine($"Строка до abc = {str12}");
            Console.WriteLine($"Строка после abc = {str13}");
            Console.WriteLine("\n================\n");

            //    Задание 4
            // Дана строка: “Плохой день.”
            //Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду
            //insert создать строку со значением: Хороший день!!!!!!!!!.
            //Заменить последний "!" на "?"

            string str11 = "Плохой день.";
            string strZamena = "плохой";
            Console.WriteLine($"Строка = {str11}");
            string str211 = str11.Substring(strZamena.Length);
// Console.WriteLine($"Строка 2 = {str2}");

            string insertedAtStart = str211.Insert(0, "Хороший");
// Console.WriteLine($"Insert (в начале): {insertedAtStart}");     

            string insertedAtEnd = insertedAtStart.Insert(insertedAtStart.Length - 1, "!!!!!!!!!");
// Console.WriteLine($"Insert (в конце): {insertedAtEnd}");
            string removedFromEnd = insertedAtEnd.Remove(insertedAtEnd.Length - 2, 2) + "?";
            Console.WriteLine($"Новая строка: {removedFromEnd}");
            Console.WriteLine("\n================\n");
        }
    }
}