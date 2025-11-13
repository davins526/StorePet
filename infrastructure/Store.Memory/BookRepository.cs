using System;
using System.Linq;
using Store;

namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of game"),
        new Book(1, "Obelix"),
        new Book(1, "Down lord"),
    };
    public Book[] GetByAllTitle(string titlePart)
    {
        return books.Where(book => book.Title.Contains(titlePart))
                    .ToArray();
    }
}
