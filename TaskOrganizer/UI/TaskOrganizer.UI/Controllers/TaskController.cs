using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskOrganizer.UI.Mock;
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

        public IActionResult GetAllTasks()
        {
            // test mock
            var tasks = TaskMock.GetTaskMock();
            
            return View(tasks);
        }

        [HttpPost]
        public void CreateTask(TaskModel taskModel)
        {
            // here call service(proxy) to chance status task
            
            RedirectToAction("GetAllTasks");
        }

        private List<TaskModel> test(TaskModel task)
        {
            task.CreateDate = DateTime.Now;
            task.StartDate = DateTime.Now;
            task.Progress = "InProgress";

            return new List<TaskModel>{
                task
            };
        }
    }
}
