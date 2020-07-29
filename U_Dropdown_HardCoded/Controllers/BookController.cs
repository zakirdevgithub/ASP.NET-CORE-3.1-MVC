using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using U_Dropdown_HardCoded.Models;
using U_Dropdown_HardCoded.Station;

namespace U_Dropdown_HardCoded.Controllers
{
    public class BookController : Controller
    {
        private readonly BookExpress _bookExpress = null;
        public BookController(BookExpress bookExpress)
        {
            _bookExpress = bookExpress;
        }



        [HttpGet]
        public ViewResult AddNewBook( bool IsSuccess=false, int bookId=0)
        {
            var selectedLanguage = new Book()
            {
               // Language = "2"
            };

            //var languageList =new List<string>() { "Bengali", "English", "Hindi" };

            //var languageList =new SelectList( new List<string>() { "Bengali", "English", "Hindi" });

            //var languageList = new SelectList(GetLanguages(), "Id", "Text");

            //var languageList = GetLanguages().Select(x => new SelectListItem()
            //{
            //    Text=x.Text,
            //    Value=x.Id.ToString()
            //});

            //var group1 = new SelectListGroup() { Name = "Groupe 1" };
            //var group2 = new SelectListGroup() { Name = "Groupe 2" };
            //var group3 = new SelectListGroup() { Name = "Groupe 3", Disabled=true };

            //var languageList = new List<SelectListItem>()
            //{
            //    new SelectListItem(){Text="Bengali", Value="1", Group=group1},
            //    new SelectListItem(){Text="English", Value="2", Group=group1},
            //    new SelectListItem(){Text="Hindi", Value="3", Group=group2},
            //    new SelectListItem(){Text="Arabic", Value="4", Group=group2},
            //    new SelectListItem(){Text="Chinese", Value="5", Group=group3},
            //    new SelectListItem(){Text="Korean", Value="6", Group=group3},
            //};

            //ViewBag.LanguageList = languageList;
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.Id = bookId;
            return View(selectedLanguage);
        }

        [HttpPost]
        public IActionResult AddNewBook(Book model)
        {
            if (ModelState.IsValid)
            {
                var id = _bookExpress.PassingBookData(model);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId = id });
                }
            }
            //var languageList = new List<string>() { "Bengali", "English", "Hindi" };
            //var languageList = new SelectList(new List<string>() { "Bengali", "English", "Hindi" });

            //var group1 = new SelectListGroup() { Name = "Groupe 1" };
            //var group2 = new SelectListGroup() { Name = "Groupe 2" };
            //var group3 = new SelectListGroup() { Name = "Groupe 3", Disabled = true };

            //var languageList = new List<SelectListItem>()
            //{
            //    new SelectListItem(){Text="Bengali", Value="1", Group=group1},
            //    new SelectListItem(){Text="English", Value="2", Group=group1},
            //    new SelectListItem(){Text="Hindi", Value="3", Group=group2},
            //    new SelectListItem(){Text="Arabic", Value="4", Group=group2},
            //    new SelectListItem(){Text="Chinese", Value="5", Group=group3},
            //    new SelectListItem(){Text="Korean", Value="6", Group=group3},
            //};

            ModelState.AddModelError("", "This is Custom Error Message");
            ModelState.AddModelError("", "This is Second Custom Message");

            return View();
        }

        public ViewResult ShowBooks()
        {
            var books =_bookExpress.GetAllBooks();
            return View(books);
        }

        public ViewResult BookDetails(int id)
        {
            var bookDetails = _bookExpress.BookById(id);
            return View(bookDetails);
        }

        public List<Languages> GetLanguages()
        {
            return new List<Languages>()
            {
                new Languages(){Id=1, Text="Bengali"},
                new Languages(){Id=2, Text="English"},
                new Languages(){Id=3, Text="Hindi"},
                new Languages(){Id=4, Text="Tamil"}
            };
        } 

    }
}
