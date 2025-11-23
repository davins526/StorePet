using Microsoft.AspNetCore.Mvc;
using Store.Memory;
using Store;

namespace Store.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Index()
        {

            Book book = bookRepository.GetAllById(id);

            return View();
        }
    }
}
