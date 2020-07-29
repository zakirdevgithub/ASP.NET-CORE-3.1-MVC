using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V_Dropdown_With_Database.Models;
using V_Dropdown_With_Database.Station;

namespace V_Dropdown_With_Database.Controllers
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
            ViewBag.Language = languages;
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(BookModel model)
        {
            if (ModelState.IsValid)
            {
                var id = _bookStation.AddNewBook(model);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId=id });
                }

                ModelState.AddModelError("", "This is First Custom Error Message");
                ModelState.AddModelError("", "This is Second Custom Error Message");
            }

            var languages = new SelectList(_languageStation.GetLanguage(), "Id", "Name");
            ViewBag.Language = languages;

            return View();
        }

        public ViewResult ShowAllBooks()
        {
            var data = _bookStation.GetAllBooks();
            return View(data);
        }

        public ViewResult BookDetails(int id)
        {
            var data = _bookStation.BookById(id);
            return View(data);
        }
    }
}
