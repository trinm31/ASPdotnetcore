using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ORM_EFcore.DataAccess;
using ORM_EFcore.Models;

namespace ORM_EFcore.Controllers
{
    public class ClassController : Controller
    {
        private readonly ORMEFCoreContext _db;
        public ClassController(ORMEFCoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listAllData = _db.Classes.ToList();
            return View(listAllData);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Class obj)
        {
            if (ModelState.IsValid)
            {
                _db.Classes.Add(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _db.Classes.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Class obj)
        {
            if (ModelState.IsValid)
            {
                _db.Classes.Update(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var classNeedToDelete = _db.Classes.Find(id);
            _db.Classes.Remove(classNeedToDelete);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}