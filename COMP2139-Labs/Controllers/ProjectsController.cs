using Microsoft.AspNetCore.Mvc;
using COMP2139_Labs.Models;

namespace COMP2139_Labs.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project { ProjectId = 1, Name = "Project 1", Description = "First Project" },
            new Project { ProjectId = 2, Name = "Project 2", Description = "Second Project" }

        };
            return View(projects);
        }

        public IActionResult Details()
        {
            
            return View();
        }

        public IActionResult Create()
        {
            
            return View();
        }

    }
}
