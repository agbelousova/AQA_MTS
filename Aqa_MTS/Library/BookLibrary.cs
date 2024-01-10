using System.Collections;

namespace Library;

internal class BookLibrary
{
    private List<Books> Books { get; set; } = new List<Books>(16);
    
    public BookLibrary() { }
    public BookLibrary(List<Books> books) => Books = books;

    public void AddBook(string? bookName, string? bookAuthor, string? bookYearPublication)
    {
        if (Int32.TryParse(bookYearPublication, out int year))
        {
            Books.Add(new Books(new ArrayList { bookName, bookAuthor, bookYearPublication }));
            Console.WriteLine("Книга успешно добавлена");
        }
        else
            Console.WriteLine("Введен некорректный год издания");
    }
    
    public void PrintBooksList()
    {
        foreach (var book in Books)
            book.PrintInfo();
    }

    public void FindByAuthor(string? author)
    {
        if (author != "")
        {
            bool found = false;

            foreach (var book in Books)
                if (book.BookInfo.Contains(author))
                {
                    book.PrintInfo();
                    found = true;
                }
            if (!found)
                Console.WriteLine($"Книги автора {author} не найдены");
        }
    }
    public void RemoveByID(string? idInput)
    {
        if (IsCorrectInt32(idInput, out int id))
        {
            int index = Books.FindIndex(item => item.ID == id);

            if (index >= 0)
            {
                Books.Remove(Books[index]);
                Console.WriteLine("Книга успешно удалена");
            }
            else
                Console.WriteLine($"Книга с ID [{id}] не найдена");
        }
    }
    
    public static bool IsCorrectInt32(string? input, out int value)
    {
        if (!String.IsNullOrWhiteSpace(input) && Int32.TryParse(input, out value))
        {
            return true;
        }

        Console.WriteLine("Введено некорректное значение - требуется целое число");
        value = 0;
        return false;
    }
}