/*
 Задание 1:
Напишите программу, используя ArrayList, чтобы хранить информацию о книгах в библиотеке.
Ваша программа должна предоставлять следующие функциональности:
    Добавление книги: Пользователь может вводить информацию о новой книге, включая название,
автора и год издания. Эта информация должна быть добавлена в ArrayList.
    Отображение списка книг: Пользователь может просматривать список всех книг в библиотеке,
включая название, автора и год издания.
    Поиск книги по автору: Пользователь может ввести имя автора, и программа должна отобразить
список книг этого автора.
    Удаление книги: Пользователь может выбрать книгу из списка и удалить ее из библиотеки.
    Выход из программы: Пользователь может завершить программу.
*/

using System.Collections;
using Library;

bool exitFlag = false;

BookLibrary library = new BookLibrary(new List<Books>
{
    new Books( new ArrayList { "Унесенные ветром", "Маргарет Митчелл", 2007 }),
    new Books( new ArrayList { "Мастер и Маргарита", "Михаил Булгаков", 2004}),
    new Books( new ArrayList { "Война и мир", "Лев Толстой", 2015})
});

while (!exitFlag)
{
    Console.Write(
        $"-= Библиотека=-\n1 - Добавление книги\n2 - Отображение списка книг\n3 - Поиск книги по автору\n4 - Удаление книги\n5 - Выход из программы\nВведите номер операции: ");
    switch (Console.ReadLine())
    {
        case "1":
        {
            try
            {
                Console.WriteLine("Введите название книги, автора и год издания");
                library.AddBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            }
            catch (ExceptionBookInfo ex)
            {
                Console.WriteLine("Ошибка ввода данных по книге: " + ex.Message);
            }
            break;
        }
        case "2":
        {
            Console.Clear();
            library.PrintBooksList();
            break;
        }
        case "3":
        {
            Console.Clear();
            Console.WriteLine("Книги какого автора нужно найти?");
            library.FindByAuthor(Console.ReadLine());
            break;
        }
        case "4":
        {
            Console.Clear();
            Console.WriteLine("Введите ID книги, которую требуется удалить:");
            library.PrintBooksList();
            library.RemoveByID(Console.ReadLine());
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