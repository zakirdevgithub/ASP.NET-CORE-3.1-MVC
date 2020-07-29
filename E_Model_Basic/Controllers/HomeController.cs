using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_Model_Basic.Controllers
{
    public class HomeController : Controller
    {
         public string Index()
        {
            return "Hello World!";
        }
    }
}
