using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_Form_Validation.Models;

namespace T_Form_Validation.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepo = null;
        public BookController(BookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet]
        public ViewResult AddNewBook(bool IsSuccess=false, int booKId=0)
        {
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.BookId = booKId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(Book model)
        {
            if (ModelState.IsValid)
            {
                var id =await _bookRepo.AddNewBook(model);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId = id });
                }
            }
            ModelState.AddModelError("", "This is First custom model error");
            ModelState.AddModelError("", "This is Second Custom Model Error");
            return View();
        }

        public async Task<ViewResult> GetAllBooks()
        {
           var allBooks=await _bookRepo.GetAllBooks();
            return View(allBooks);
        }

        public async Task<ViewResult> GetBookById(int id)
        {
            var bookById =await _bookRepo.GetBookById(id);
            return View(bookById);
        }
    }
}
