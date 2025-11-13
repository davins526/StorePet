namespace Store;

public interface IBookRepository
{
    Book[] GetByAllTitle(string titlePart);
}
