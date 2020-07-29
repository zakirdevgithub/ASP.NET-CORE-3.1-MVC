using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U_Dropdown_HardCoded.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        } 

        [Route("Services", Name ="Services")]
        public ViewResult Services()
        {
            return View();
        }
        [Route("Portfolio", Name ="Portfolio")]
        public ViewResult Portfolio()
        {
            return View();
        }
        [Route("About", Name ="About")]
        public ViewResult About()
        {
            return View();
        }
        [Route("Contact", Name ="Contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}
