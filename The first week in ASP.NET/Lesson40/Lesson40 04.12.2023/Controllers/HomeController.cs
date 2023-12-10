using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson40_04._12._2023.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    } 
}