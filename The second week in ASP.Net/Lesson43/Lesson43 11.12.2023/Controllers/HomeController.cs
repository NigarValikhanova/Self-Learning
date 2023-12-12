using Lesson40_04._12._2023.DAL;
using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lesson40_04._12._2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appContext;
        //public readonly DbConfig _dbConfig;
        //public readonly IServiceProvider _serviceProvider;
        //public HomeController(AppDbContext appContext, DbConfig dbConfig, IServiceProvider serviceProvider)
        //{
        //    _dbConfig = dbConfig;
        //    _serviceProvider = serviceProvider;
        //    _appContext = appContext;
        //}

        public HomeController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            //List<ImagesItem> books = Cards.ImagesItems.ToList();
            //return View(books);
            return View();
        }

        public async Task< IActionResult> Contact()
        {
            List<Product> products = await _appContext.Products.Include(x=>x.Category).Where(z=>z.Category.CategoryName=="Electronics").ToListAsync();
            return View(products);
        }

    } 
}