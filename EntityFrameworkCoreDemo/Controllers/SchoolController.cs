using EntityFrameworkCoreDemo.DbEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Controllers
{
    public class SchoolController : Controller
    {

        private readonly ApplicationDbContext _context;

        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var school = _context.School.FirstOrDefault();
            return View(school);


        }
    }
}
