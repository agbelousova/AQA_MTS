using System.Text;

namespace StringApp
{
    static class HM
    {
        static void Main(string[] args)
        {
            //Задание 1:
            // Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

            /*
            string str = "10test5ew0dwe00dte1sttestwewefef1550test5dvs45test515dstesteftecf540test";
            string fstr = "test";
            string insertStr = "testing";

            string replacedString1 = str.Replace("test", "testing");
            Console.WriteLine($"Новая строка с заменой: \n{replacedString1}");

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
                */
            //Задание 2
            // Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
            // Welcome to the TMS lesons.
            //     Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова

            // string str = "Welcome to the TMS lesons.";

            // -=================== Find subString (Поиск подстроки) ===================


            // -=================== IndexOf and IndexOfAny
            /*Console.WriteLine($"IndexOf 'j' (С учетом регистра): {f_str.IndexOf('j')}"); // С учетом регистра
            Console.WriteLine($"IndexOf 'J' (С учетом регистра): {f_str.IndexOf('J')}"); // С учетом регистра
            Console.WriteLine(
                $"IndexOf 'J' (Без учета регистра): {f_str.IndexOf('J', StringComparison.OrdinalIgnoreCase)}"); // Без учета регистра
            Console.WriteLine(
                $"IndexOf 'j' (С указанием начала поиска): {f_str.IndexOf('j', 9)}"); // С указанием начала поиска

            char[] chars1 = { 'T', 'o', 's' };
            char[] chars2 = { '!', '=', '^' };

            Console.WriteLine($"IndexOfAny 'chars1': {f_str.IndexOfAny(chars1)}");
            Console.WriteLine($"IndexOfAny 'chars1': {f_str.IndexOfAny(chars1, 2)}");
            Console.WriteLine($"IndexOfAny 'chars2': {f_str.IndexOfAny(chars2)}");

            Console.WriteLine($"IndexOf 'i': {f_str.IndexOf('i')}");
            Console.WriteLine($"LastIndexOf 'i': {f_str.LastIndexOf("i")}");
            // -=================== Insert (Вставка) ===================
            string originalInsertString = "Hello, world!";*/

            // string str = "Welcome to the TMS lesons.";
            /*
            // Пример вставки подстроки в середину строки
            string insertedString = f_str.Insert(f_str.IndexOf('i'), "1 ");
            Console.WriteLine($"Insert (в середине): {insertedString}");
            string replacedString1;
            if ( replacedString1 = str.Replace("Welcome", "Welcome"))
            Console.WriteLine($"Replace: {replacedString1}");
            */

            // Пример 2: Проверка наличия подстроки (регистронезависимая)
            /*bool containsSubstring2 = str.Contains("Welcome", StringComparison.OrdinalIgnoreCase);

            if (containsSubstring2 == true)
            {
                str = (""", + ");
                string replacedString1 = str.Replace("Welcome", "",""testing");
            }

            Console.WriteLine($"Contains (регистронезависимая): {containsSubstring2}");
            */

            // -=================== AppendLine
            // "Welcome to the TMS lesons.";
            /*
            StringBuilder sbAppendLine = new StringBuilder();
            sbAppendLine.Insert(0, "\"").AppendLine("Welcome");
           // sbAppendLine.Insert(sbAppendLine.Length, "\"");
            sbAppendLine.AppendLine("to");
            sbAppendLine.AppendLine("TMS");
            sbAppendLine.AppendLine("lesons.");

            Console.WriteLine($"AppendLine :  {sbAppendLine}");
            */
            
            string str = "Welcome to the TMS lesons.";
            
           string str2; // = str.Replace("Welcome", "\"Welcome\") + str.Replace("to", "\"to\"");
            /*
            string replacedString1;
            bool containsWel = str.Contains("Welcome", StringComparison.OrdinalIgnoreCase);
            bool containsTo = str.Contains("to", StringComparison.OrdinalIgnoreCase);
            bool containsThe = str.Contains("the", StringComparison.OrdinalIgnoreCase);
            bool containsTMS = str.Contains("TMS", StringComparison.OrdinalIgnoreCase);
            bool containsLes = str.Contains("lesons", StringComparison.OrdinalIgnoreCase);

            string insertedString;*/
            
            for (int i = 1; i < str.Length; i++)
            {
             int j = str.IndexOf(' ');
               str2 = str.Insert(j, "\"");
                i ++;
                Console.WriteLine($"Новая строка: {str2}");
            }
            
            /*
            if (char.IsDigit(replacedString1[i]))
                {
                    string removedSubstring2 = replacedString1.Remove(i, 1);
                    replacedString1 = removedSubstring2;
                    i -= 1;
                }
            }
            Console.WriteLine($"Новая строка без цифр: \n{replacedString1}");
            
            
            foreach (var word in str)
            {
                str2 = str.Replace("Welcome", "\"Welcome\"");
                
            if (containsWel == true)
            {
                   str2 = str.Replace("Welcome", "\"Welcome\"");
                Console.WriteLine($"Строка: {str}");
            } 
            if (containsTo == true)
            {
                // replacedString1 = 
                str.Replace("to", "\"to\"");
                Console.WriteLine($"Строка: {str}");
            }
            if (containsThe == true)
            {
                // replacedString1 = 
                str.Replace("the", "\"the\"");
                Console.WriteLine($"Строка: {str}");
            }
            if (containsTMS == true)
            {
                // replacedString1 = 
                str.Replace("TMS", "\"TMS\"");
                Console.WriteLine($"Строка: {str}");
            }
            if (containsLes == true)
            {
                // replacedString1 = 
                str.Replace("Welcome", "\"lesons\"");
                Console.WriteLine($"Строка: {str}");
            }*/
           // Console.WriteLine($"Строка: {replacedString1}");
        //string insertedAtStart = sbAppendLine.Insert(0, "Greeting: ");
           /* Вывод:
              Hello,
              world!
              How are you?
           */
        }
    }
}