using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X_Client_Side_Validation_Upload_Image.Models;
using X_Client_Side_Validation_Upload_Image.Station;
using Microsoft.AspNetCore.Hosting;

namespace X_Client_Side_Validation_Upload_Image.Controllers
{
    public class BookController : Controller
    {
        private readonly BookStation _bookStation = null;
        private readonly LanguageStation _languageStation = null;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BookController(BookStation bookStation,
            LanguageStation languageStation,
            IWebHostEnvironment webHostEnvironment)
        {
            _bookStation = bookStation;
            _languageStation = languageStation;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public async  Task<ViewResult> AddNewBook(bool IsSuccess=false, int bookId=0)
        {
            var languages = new SelectList(await _languageStation.GetLanguage(), "Id", "Name");
            ViewBag.Languages = languages;
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.CoverPhoto != null)
                {
                    string folder = "books/cover";
                    folder += Guid.NewGuid().ToString() + "_" + model.CoverPhoto.FileName;
                    model.CoverImageUrl = "/" + folder;

                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
                    await model.CoverPhoto.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                }


                var id = await _bookStation.SendBookToDatabase(model);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId = id });
                }
            }

            var languages = new SelectList(await _languageStation.GetLanguage(), "Id", "Name");
            ViewBag.Languages = languages;
            return View();
        }

        public async Task<ViewResult> ShowBooks()
        {
            var data = await _bookStation.GetAllBooks();
            return View(data);
        }

        public async Task<ViewResult> ShowBookById(int id)
        {
            var data = await _bookStation.GetBookById(id);
            return View(data);
        }
    }
}
