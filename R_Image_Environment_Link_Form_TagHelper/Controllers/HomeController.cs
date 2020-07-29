using Microsoft.AspNetCore.Mvc;
using R_Image_Environment_Link_Form_TagHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R_Image_Environment_Link_Form_TagHelper.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Services()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Services(Book model)
        {
            ViewBag.Title = model.Title;
            ViewBag.Author = model.Author;
            ViewBag.Description = model.Description;
            ViewBag.TotalPage = model.TotalPage;
            return View();
        }
        public ViewResult Portfolio()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
