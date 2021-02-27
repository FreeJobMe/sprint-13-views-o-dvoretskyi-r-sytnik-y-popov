using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            ViewBag.Value = "C# Marathon!";
            ViewBag.Greeting = "Welcome to our project!";
            return View();
        }
    }
}
