using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ORM_EFcore.DataAccess;
using ORM_EFcore.Models;

namespace ORM_EFcore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ORMEFCoreContext _db;
        public CategoriesController(ORMEFCoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listAllData = _db.Categories.ToList();
            return View(listAllData);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _db.Categories.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            if (id == null)
            {
                return View(new Category());
            }

            var categories = _db.Categories.Find(id);
            return View(categories);
        }
        
        [HttpPost]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _db.Categories.Add(category);
                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(category);

        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categoryNeedToDelete = _db.Categories.Find(id);
            _db.Categories.Remove(categoryNeedToDelete);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}