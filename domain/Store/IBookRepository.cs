namespace Store
{
public interface IBookRepository
{
    Book[] GetAllByIsbn(string isbn);
    Book[] GetByAllTitleOrAuthor(string titleOrAuthor);
    Book[] GetById(int Id);
}

}

