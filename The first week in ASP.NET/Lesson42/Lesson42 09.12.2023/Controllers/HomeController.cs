using Lesson40_04._12._2023.DAL;
using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson40_04._12._2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appContext;
        public readonly DbConfig _dbConfig;
        public readonly IServiceProvider _serviceProvider;
        public HomeController(AppDbContext appContext,DbConfig dbConfig, IServiceProvider serviceProvider)
        {
            _dbConfig = dbConfig;
            _serviceProvider = serviceProvider;
            _appContext = appContext;
        }


        public IActionResult About()
        {
           ViewBag.TestData = _serviceProvider.GetService<DbConfig>().GuidId;
           return View(_dbConfig);
        }

        public IActionResult Services()
        {
            List<Students> students = _appContext.Students.ToList();
            return View(students);
        }

    } 
}