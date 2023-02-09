using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using progetto_0.Models.Services.Application;
using progetto_0.Models.ViewModels;

namespace progetto_0.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            CourseService service = new CourseService();
            // var service = new CourseService(); -> è uguale a quello sopra
            List<CourseViewModel> courses = CourseService.GetServices();
            return View(courses );
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}
