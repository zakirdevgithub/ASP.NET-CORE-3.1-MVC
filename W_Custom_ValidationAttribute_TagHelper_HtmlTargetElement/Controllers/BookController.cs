using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Models;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Station;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Controllers
{
    public class BookController : Controller
    {
        private readonly BookStation _bookStation = null;
        private readonly LanguageStation _languageStation = null;

        public BookController(BookStation bookStation, LanguageStation languageStation)
        {
            _bookStation = bookStation;
            _languageStation = languageStation;
        }


        [HttpGet]
        public ViewResult AddNewBook(bool IsSuccess=false, int bookId=0)
        { 
            var languages = new SelectList(_languageStation.GetLanguage(), "Id", "Name");
            ViewBag.Languages = languages;
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        public IActionResult AddNewBook(BookModel model)
        {
            if (ModelState.IsValid)
            {
                var id = _bookStation.AddNewBook(model);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId = id });
                }

            }

            var languages = new SelectList(_languageStation.GetLanguage(), "Id", "Name");
            ViewBag.Languages = languages;
            return View();
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookStation.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBookById(int id)
        {
            var data = _bookStation.GetBookById(id);
            return View(data);
        }
    }
}
