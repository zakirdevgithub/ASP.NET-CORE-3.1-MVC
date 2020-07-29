using Microsoft.AspNetCore.Mvc;
using P_ViewData_Attribute.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using P_ViewData_Attribute.Models;

namespace P_ViewData_Attribute.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public int Roll { get; set; }

        [ViewData]
        public string Name { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public Book Book { get; set; }

        public ViewResult Index()
        {
            Title = "Home Page";
            Roll = 24;
            Name = "Md. Zakir Hossain";
            Book = new Book { Id = 10, Category = "Programming" };
            return View();
        }
        public ViewResult Services()
        {
            Title = "Service Page";
            return View();
        }
        public ViewResult Portfolio()
        {
            Title = "Portfolio Page";
            return View();
        }
        public ViewResult About()
        {
            Title = "About Page";

            ViewBag.Message = "My Name is Zakir";
            ViewBag.Number = 2494;
            int[] numbers = new int[] {1,2,3,4,5};
            ViewBag.Numbers = numbers;
            List<string> friends = new List<string>() {"Shovon","Limon","Pranto","Tushar" };
            ViewBag.Friends = friends;
            dynamic obj = new ExpandoObject();
            obj.Id = 1;
            obj.Title = "Programmer";
            ViewBag.Obj = obj;
            var book = new Book() { Id = 1, Title = "Software Developer" };
            ViewBag.Book = book;

            return View();
        }
        public ViewResult Contact()
        {
            Title = "Contact Page";

            ViewData["Message"] = "My Name is Zakir";
            ViewData["Number"] = 2494;
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ViewData["Numbers"] = numbers;
            List<string> friends = new List<string>() { "Shovon", "Limon", "Pranto", "Tushar" };
            ViewData["Friends"] = friends;
            dynamic obj = new ExpandoObject();
            obj.Id = 1;
            obj.Title = "Programmer";
            ViewData["Obj"] = obj;
            var book = new Book() { Id = 1, Title = "Software Developer" };
            ViewData["Book"] = book;

            return View();
        }
        
    }
}
