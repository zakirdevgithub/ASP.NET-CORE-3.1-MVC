using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Model_Basic.Data;
using E_Model_Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Model_Basic.Controllers
{
    public class BookController : Controller
    {
        private readonly BookData _bookdata = null;
        public BookController()
        {
            _bookdata = new BookData();
        }

        public List<Book> GetAllBooks()
        {
            return _bookdata.AllBooks();
        }
        public Book GetBookById(int id)
        {
            return _bookdata.BookById(id);
        }
        public List<Book> GetBookBySearch(string title, string author)
        {
            return _bookdata.SearchBook(title, author);
        }
    }
}
