
namespace Store
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public Book[] GetAllByQuery(string query)
        {
            if (IsIsbn(query))
                return bookRepository.GetAllByIsbn(query);

            return bookRepository.GetByAllTitleOrAuthor(query);

           
        }

        private bool IsIsbn(string query)
        {
            throw new NotImplementedException();
        }
    }
}
