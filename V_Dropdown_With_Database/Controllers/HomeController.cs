﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V_Dropdown_With_Database.Controllers
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
