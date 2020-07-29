using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using S_Connect_Database.Data;
using S_Connect_Database.Models;

namespace S_Connect_Database.Controllers
{
    public class BookController : Controller
    {
        private readonly BookData _bookData = null;
        public BookController(BookData bookData)
        {
            _bookData = bookData;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookData.AllBooks();
            return View(data);
        }

      
        public async Task<ViewResult> GetBookById(int id)
        {
            var data = await _bookData.BookById(id);
            return View(data);
        }
        public ViewResult GetBookBySearch(string title, string author)
        {
            var data = _bookData.BookBySearch(title, author);
            return View(data);
        }
        [HttpGet]
     
        public ViewResult AddNewBook(bool IsSuccess=false, int bookId=0)
        {

            ViewBag.Message = "Add New Book";
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.Id = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(Book model)
        {
            var id =await _bookData.AddNewBook(model);
            if(id>0)
            {
                return RedirectToAction(nameof(AddNewBook), new { IsSuccess=true, bookId=id });
            }
            return View();
        }

    }
}