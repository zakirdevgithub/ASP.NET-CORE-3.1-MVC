using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using Q_Anchor_Tag_Helper.Models;

namespace Q_Anchor_Tag_Helper.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public Book Book { get; set; }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Services()
        {
            return View();
        }
        public ViewResult Portfolio()
        {
            return View();
        }
        [Route("Zakir")]
        public ViewResult About()
        {
            Book = new Book() { Id = 100, Author = "Zakir Hossain" };
            return View();
        }
        [Route("ContactMe", Name ="Contact")]
        public ViewResult Contact()
        {
            //ViewData
            ViewData["Message"] = "Stay Home, Stay Safe";
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ViewData["Numbers"] = numbers;
            List<string> friends = new List<string> { "Shovon", "Pranto", "Milon" };
            ViewData["Friends"] = friends;
            dynamic obj = new ExpandoObject();
            obj.Book = new Book() { Id = 10, Title = "Programming Book" };
            obj.Name = "Zakir Hossain";
            ViewData["Obj"] = obj;

            var book = new Book() {Id=11, Title="Framework Book" };
            ViewData["Book"] = book;

            //ViewBag
            ViewBag.Country = "Bangladesh";
            ViewBag.Numbers = numbers;
            List<string> countries = new List<string>() { "Bangladesh", "India", "America" };
            ViewBag.Countries = countries;
            ViewBag.Obj = obj;
            ViewBag.Book = book;



            return View();
        }
    }
}
