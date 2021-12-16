using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ORM_EFcore.DataAccess;
using ORM_EFcore.Models;

namespace ORM_EFcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ORMEFCoreContext _db;

        public HomeController(ILogger<HomeController> logger, ORMEFCoreContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var StudentList = _db.Students.ToList();
            int a = 1;
            int b = a;
            return View(StudentList);
        }

        public IActionResult Details(int StudentId)
        {
            var student = _db.Students.Where(s => s.StudentId == StudentId).FirstOrDefault();
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}