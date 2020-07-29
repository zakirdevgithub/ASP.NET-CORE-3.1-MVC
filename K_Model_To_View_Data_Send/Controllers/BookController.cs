using K_Model_To_View_Data_Send.Data;
using Microsoft.AspNetCore.Mvc;

namespace K_Model_To_View_Data_Send.Controllers
{
    public class BookController : Controller
    {
        private readonly BookData _bookData = null;
        public BookController()
        {
            _bookData = new BookData();
        }

        public ViewResult GetAllBooks()
        {
            var allBooks = _bookData.AllBooks();
            return View(allBooks);
        }
        public ViewResult GetBookById(int id)
        {
            var bookById= _bookData.BookById(id);
            return View(bookById);
        }
        public ViewResult GetBookBySearch(string title, string author)
        {
            var bookBySearch = _bookData.BookBySearch(title, author);
            return View(bookBySearch);
        }
    }
}
