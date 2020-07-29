using Microsoft.AspNetCore.Mvc;
using O_ViewBag_ViewData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_ViewBag_ViewData.Controllers
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
            var data = _bookData.AllBooks();
            return View(data);
        }
        public ViewResult GetBookById(int id)
        {
            var data = _bookData.BookById(id);
            return View(data);
        }
        public ViewResult GetBookBySearch(string title, string author)
        {
            var data = _bookData.BookBySearch(title, author);
            return View(data);
        }
    }
}
