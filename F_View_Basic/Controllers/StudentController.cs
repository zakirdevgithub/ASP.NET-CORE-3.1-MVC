using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F_View_Basic.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Name()
        {
            return View();
        }
    }
}
