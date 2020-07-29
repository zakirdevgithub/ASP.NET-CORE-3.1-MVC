using Microsoft.AspNetCore.Mvc;
using P_ViewData_Attribute.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_ViewData_Attribute.Controllers
{
    public class BookController : Controller
    {
        [ViewData]
        public string Title { get; set; }

        private readonly BookData _bookData = null;
        public BookController()
        {
            _bookData = new BookData();
        }

        public ViewResult GetAllBooks()
        {
            Title = "Book";

            var data = _bookData.AllBooks();
            return View(data);
        }
        public ViewResult GetBookById(int id)
        {
            Title = "Book By Id";
            var data = _bookData.BookById(id);
            return View(data);
        }
        public ViewResult GetBookBySearch(string title, string author)
        {
            var data = _bookData.BookBySearch(title,author);
            return View(data);
        }
    }
}
