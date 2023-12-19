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
ArrayList libraryBook = new ArrayList();

while (!exitFlag)
{
    Console.Write(
        $"-= Библиотека=-\n1 - Добавление книги\n2 - Отображение списка книг\n3 - Поиск книги по автору\n4 - Удаление книги\nВсего в библотеке {libraryBook.Count} книг\n5 - Выход из программы\nВведите номер операции: ");
    switch (Console.ReadLine())
    {
        case "1":
        {
            try
            {
                Console.Clear();
                Console.Write("Введите название книги: ");
                string bookName = Console.ReadLine();
                Console.Write("Введите автора книги: ");
                string bookAuthor = Console.ReadLine();
                Console.Write("Введите год публикации книги: ");
                int bookYearPublication = Convert.ToInt32(Console.ReadLine());

                libraryBook.Add(Books.AddBook(bookName, bookAuthor, bookYearPublication));
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
            int i = 1;

            if (libraryBook.Count != 0)
            {
                foreach (Books book in libraryBook)
                {
                    Console.WriteLine(
                        $"{i}. Название: {book.BookName}, Автор: {book.BookAuthor}, Год публикации: {book.BookYearPublication}");
                    i++;
                }
                break;
            }
            else
            {
                Console.WriteLine("Библиотека пустая. Нужно сначала добавить книгу!");
                break;
            }
        }
        case "3":
        {
            Console.Clear();
            Console.Write("Введите имя автора: ");
            string bookAuthorFind = Console.ReadLine();
            Books.FindBookAuthor(bookAuthorFind, libraryBook);
            break;
        }
        case "4":
        {
            Console.Clear();
            int i = 1;

            if (libraryBook.Count != 0)
            {
                Console.WriteLine("Список книг в библиотеке: ");

                foreach (Books book in libraryBook)
                {
                    Console.WriteLine(
                        $"№: {i}. Название: {book.BookName}, Автор: {book.BookAuthor}, Год публикации: {book.BookYearPublication}");
                    i++;
                }

                Console.Write("Введите номер книги для удаления: ");
                int removeIndex = Convert.ToInt32(Console.ReadLine());

                if (removeIndex > libraryBook.Count - 1 || removeIndex < 0)
                    Console.WriteLine("Ошибка, индекс за пределами списка");
                else
                {
                    libraryBook.RemoveAt(removeIndex);
                    Console.WriteLine("Книга удалена из списка");
                }
                break;
            } else
            {
                Console.WriteLine("Библиотека пустая. Нужно сначала добавить книгу!");
                break;
            }
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