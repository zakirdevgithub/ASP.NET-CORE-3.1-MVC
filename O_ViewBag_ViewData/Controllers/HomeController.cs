using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using O_ViewBag_ViewData.Models;

namespace O_ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            ViewBag.Message = "Hello I am Here";
            ViewBag.Number = 24789;
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            ViewBag.ListNumbers = numbers;
            return View();
        }
        public ViewResult Services()
        {
            dynamic obj = new ExpandoObject();
            obj.Name = "Zakir";
            obj.Age = 25;
            ViewBag.Obj = obj;

            var data = new Book() { Id = 10, Title = "ViewBag Practice" };
            ViewBag.PassClassObject = data;
            return View();
        }
        public ViewResult Portfolio()
        {
            ViewData["message"] = "Stay Home, Stay Safe";
            List<string> names = new List<string>() {"Zakir","Keya","Mitu","Setu" };
            ViewData["Names"] = names;

            var data=new Book() { Id = 11, Title = "ViewData Practice" };
            ViewData["data"] = data;

            dynamic myData = new ExpandoObject();
            myData.Name = "Zakir Hossain";
            myData.Age = 25;
            ViewData["info"] = myData;
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
