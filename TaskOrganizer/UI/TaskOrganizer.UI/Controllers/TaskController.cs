using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskOrganizer.UI.Models;

namespace TaskOrganizer.UI.Controllers
{
    public class TaskController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public TaskController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TaskModel taskModel)
        {
            return View(taskModel);
        }
    }
}
