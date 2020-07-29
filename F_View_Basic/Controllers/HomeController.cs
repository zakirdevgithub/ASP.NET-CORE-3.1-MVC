using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F_View_Basic.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            //This will show About us Page
            return View("About");
        }

        public ViewResult Message()
        {
            //Full Path of Message.cshtml
            return View("/TempViews/Message.cshtml");

        }

        //Alternate
        public ViewResult Message2()
        {
            //Full Path of Message.cshtml
            return View("../../TempViews/Message");

        }
    }
}
