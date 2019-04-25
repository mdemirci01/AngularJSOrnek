using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student { FirstName = "Neslihan", LastName = "Kalyoncu", Phone = "5550000", Salary = 2200 });
            students.Add(new Student { FirstName = "Engin", LastName = "Karabudak", Phone = "5550000", Salary = 2100 });
            return Json(students);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
