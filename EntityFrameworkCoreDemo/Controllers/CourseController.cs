using EntityFrameworkCoreDemo.DbEntities;
using EntityFrameworkCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Controllers
{
    public class CourseController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var courses = _context.Course.ToList();
            if (!string.IsNullOrEmpty(id))
            {
                var course = courses.Where(x => x.Id == id).FirstOrDefault();
                return View(course);
            }
            ViewBag.ViewType = "Course";
            return View("GenericListView", courses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View(course);
            }

            var school = _context.School.FirstOrDefault();
            if (school is null)
            {
                return View("Error");
            }

            course.Schoold = school.Id;
            _context.Course.Add(course);
            _context.SaveChanges();

            return View("Index", course);
        }

        public IActionResult Delete(string id)
        {
            var courses = _context.Course.ToList();
            var course = courses.Where(x => x.Id == id).FirstOrDefault();
            if(course is null)
            {
                return View("Error");
            }

            _context.Course.Remove(course);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
