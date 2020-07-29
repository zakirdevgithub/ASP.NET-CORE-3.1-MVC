using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G_Razor_Basic.Controllers
{
    public class HomeController :Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
