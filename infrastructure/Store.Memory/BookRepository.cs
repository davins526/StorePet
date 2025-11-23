using System;
using System.Linq;
using Store;

namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of game", "ISBN 1231-31231", "Dr dze", "Des", 7m),
        new Book(1, "Obelix", "ISBN 1241-31231", "Elvine", "Des", 5m),
        new Book(1, "Down lord", "ISBN 2231-31231", "Polkaz", "Des", 3m),
    };

    public Book[] GetAllByIsbn(string isbn)
    {
        return books.Where(book => book.Isbn == isbn)
            .ToArray();    
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

    public Book[] GetByAllTitleOrAuthor(string query)
    {
        return books.Where(book => book.Author.Contains(query)
        || book.Title.Contains(query)).ToArray();
    }

    public Book GetById(int Id)
    {
        return books.Single(book => book.Id == Id);
               
    }
}
