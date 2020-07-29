﻿using Microsoft.AspNetCore.Mvc;
using N_ViewStart_ViewImports.Data;
using N_ViewStart_ViewImports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_ViewStart_ViewImports.Controllers
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