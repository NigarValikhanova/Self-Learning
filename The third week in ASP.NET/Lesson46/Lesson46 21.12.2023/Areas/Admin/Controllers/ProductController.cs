using Lesson40_04._12._2023.DAL;
using Lesson40_04._12._2023.Extensions;
using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson40_04._12._2023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _appContext;
        public ProductController(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public IActionResult Index()
        {
            var products = _appContext.Products.Include(x=>x.Category).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = _appContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Create(Product product)
        {
            ViewBag.Category = _appContext.Categories.ToList();
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            if (FileExtensions.IsImage(product.File))
            {
               string ad = await FileExtensions.SaveAsync(product.File, "products");
                product.ImageUrl = ad;
                _appContext.Products.Add(product);
                _appContext.SaveChanges();
            }
            else
            {
                ModelState.AddModelError("Error", "Shekil formati duzgun deyil");
                return View();
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editProduct = _appContext.Products.Find(id);
            ViewBag.Category = _appContext.Categories.ToList();

            if (editProduct != null)
            {
                return View(editProduct);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var oldProduct = _appContext.Products.Find(product.Id);

            if (oldProduct != null)
            {
                oldProduct.Name = product.Name;
                oldProduct.Price = product.Price;
                oldProduct.CategoryId = product.CategoryId;
                _appContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var currentCategory = _appContext.Categories.Find(id);
            if (currentCategory != null)
            {
                _appContext.Categories.Remove(currentCategory);
                _appContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
