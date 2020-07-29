using Microsoft.AspNetCore.Mvc;
using S_Connect_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S_Connect_Database.Controllers
{

    public class HomeController : Controller
    {
        [ViewData]
        public string Welcome { get; set; }
        [ViewData]
        public Book MyBook { get; set; }
        public ViewResult Index()
        {
            Welcome = "Welcome to my Site";
            MyBook = new Book() { Title = "ASP.NET Core from scratch" };
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
        [Route("Whatsup", Name ="myRoute")]
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
