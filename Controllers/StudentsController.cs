using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ORM_EFcore.DataAccess;
using ORM_EFcore.Models;

namespace ORM_EFcore.Controllers
{
    public class StudentsController:Controller
    {
        private readonly ORMEFCoreContext _db;
        
        public StudentsController(ORMEFCoreContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var studentList = _db.Students.ToList();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
            }
            else
            {
                return View(student);
            }
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult Delete(int stuid)
        {
            var studentNeedToDelete = _db.Students.Find(stuid);
            _db.Students.Remove(studentNeedToDelete);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var studentNeedToUpdate = _db.Students.Find(id);
            return View(studentNeedToUpdate);
        }
        
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(student);
                _db.SaveChanges();
            }
            else
            {
                return View(student);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}