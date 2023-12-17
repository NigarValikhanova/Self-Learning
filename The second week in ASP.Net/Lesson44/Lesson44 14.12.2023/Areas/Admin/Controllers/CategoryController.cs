using Lesson40_04._12._2023.DAL;
using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson40_04._12._2023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appContext;
        public CategoryController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            return View(_appContext.Categories.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _appContext.Categories.Add(category);
            _appContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

