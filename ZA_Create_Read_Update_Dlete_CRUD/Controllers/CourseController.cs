using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZA_Create_Read_Update_Dlete_CRUD.Data;
using ZA_Create_Read_Update_Dlete_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace ZA_Create_Read_Update_Dlete_CRUD.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _context;
        public CourseController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Methods
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _context.Course_Table.ToList();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var courses = _context.Course_Table.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var courses = _context.Course_Table.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var courses = _context.Course_Table.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }



        [HttpPost]
        public IActionResult Create(Course model)
        {
            _context.Course_Table.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Post Methods
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            _context.Course_Table.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Course model)
        {
            _context.Course_Table.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
