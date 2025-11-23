using Moq;
using Xunit;

namespace Store.Test;

public class BookServiceTests
{
    [Fact]
    public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
    {
        var bookRepositoryStub = new Mock<IBookRepository>();
        bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
            .Returns(new[]{ new Book(1, "", "", "") });

        bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
            .Returns(new[] { new Book(2, "", "", "") });

        var bookService = new BookService (bookRepositoryStub.Object);
        var invalidIsbn = "12345-67890";

        var actual = bookService.GetAllByQuery("ISBN 12345-67890");

        Assert.Collection(actual, book => Assert.Equal(2, book.Id));
    }

}
