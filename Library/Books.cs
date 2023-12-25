namespace Library;
using System.Collections;
using System;
internal class Books
{
    private string bookName;
    private string bookAuthor;
    private int bookYearPublication;
    public string BookName { get => bookName; set => bookName = value; }
    public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
    public int BookYearPublication { get => bookYearPublication; set => bookYearPublication = value; }
    public static Books AddBook(string bookName, string bookAuthor, int bookYearPublication)
    {
        Books book = new Books();

        if (String.IsNullOrWhiteSpace(bookName) || String.IsNullOrWhiteSpace(bookAuthor))
            throw new ExceptionBookInfo("Заполнены не все поля!");
        else
        {
            book.BookName = bookName;
            book.BookAuthor = bookAuthor;
            book.bookYearPublication = bookYearPublication;

            return book;
        }
    }
    public static void FindBookAuthor(string bookAuthorFind, ArrayList libBook)
    {
        Console.WriteLine("Книги автора: " + bookAuthorFind);
        foreach(Books book in libBook) 
        {
            if(book.bookAuthor.ToLower() == bookAuthorFind.ToLower())
                Console.WriteLine($"Название: {book.BookName}, Год публикации: {book.BookYearPublication}");
        }
    }
}