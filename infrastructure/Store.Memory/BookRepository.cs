using System;
using System.Linq;
using Store;

namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of game", "ISBN 1231-31231", "Dr dze"),
        new Book(1, "Obelix", "ISBN 1241-31231", "Elvine"),
        new Book(1, "Down lord", "ISBN 2231-31231", "Polkaz"),
    };

    public Book[] GetAllByIsbn(string isbn)
    {
        throw new NotImplementedException();
    }

    public Book[] GetBooks(string isbn)
    {
        throw new NotImplementedException();
    }

    public Book[] GetByAllTitle(string titlePart)
    {
        return books.Where(book => book.Title.Contains(titlePart))
                    .ToArray();
    }

    public Book[] GetByAllTitleOrAuthor(string titleOrAuthor)
    {
        throw new NotImplementedException();
    }
}
