using Lesson40_04._12._2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson40_04._12._2023.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           List<ImagesItem> books = Cards.ImagesItems.ToList();
            return View(books);
        }

    } 
}