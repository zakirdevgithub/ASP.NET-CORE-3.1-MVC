using Microsoft.AspNetCore.Mvc;
using Q_Anchor_Tag_Helper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q_Anchor_Tag_Helper.Controllers
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
            Title = "Bookstore";
            var data= _bookData.AllBooks();
            return View(data);
        }
        [Route("BookId/{id}")]
        public ViewResult GetBookById(int id, string title)
        {
            Title = "Book Details";
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
