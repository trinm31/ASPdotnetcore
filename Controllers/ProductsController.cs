using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ORM_EFcore.DataAccess;
using ORM_EFcore.Models;
using ORM_EFcore.ViewModels;

namespace ORM_EFcore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ORMEFCoreContext _db;
        public ProductsController(ORMEFCoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listAllData = _db.Products.ToList();
            ViewData["Message"] = TempData["Message"];
            return View(listAllData);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProductVM productVm = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _db.Categories.Select(i=> new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            return View(productVm);
        }

        [HttpPost]
        public IActionResult Create(ProductVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(obj.Product);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            obj = new ProductVM()
            {
                Product = obj.Product,
                CategoryList = _db.Categories.Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            
            return View(obj);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductVM productVm = new ProductVM()
            {
                Product = _db.Products.Find(id),
                CategoryList = _db.Categories.Select(i=> new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            return View(productVm);
        }
        
        [HttpPost]
        public IActionResult Edit(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(productVm.Product);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            productVm = new ProductVM()
            {
                Product = productVm.Product,
                CategoryList = _db.Categories.Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            
            return View(productVm);
        }
        
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            ProductVM productVm = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _db.Categories.Select(i=> new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            
            if (id == null)
            {
                return View(productVm);
            }

            productVm.Product = _db.Products.Find(id);
            
            return View(productVm);
        }
        
        [HttpPost]
        public IActionResult Upsert(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                if (productVm.Product.Id == 0)
                {
                    _db.Products.Add(productVm.Product);
                    _db.SaveChanges();
                    TempData["Message"] = "Success: Add Successfully";
                    return RedirectToAction(nameof(Index));
                }

                _db.Products.Update(productVm.Product);
                _db.SaveChanges();
                TempData["Message"] = "Success: Update Successfully";
                return RedirectToAction(nameof(Index));
            }

            ViewData["Message"] = "Error: Invalid Input, Please Recheck Again";
            productVm.CategoryList = _db.Categories.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            return View(productVm);
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                ViewData["Message"] = "Error: Id input null";
            }
            var productNeedToDelete = _db.Products.Find(id);
            _db.Products.Remove(productNeedToDelete);
            _db.SaveChanges();
            TempData["Message"] = "Success: Delete Successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}