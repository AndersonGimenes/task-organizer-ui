using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskOrganizer.UI.Models;
using TaskOrganizer.UI.Proxy;

namespace TaskOrganizer.UI.Controllers
{
    public class TaskController : Controller
    {
        private readonly ILogger<TaskController> _logger;
        private readonly ITaskProxy _taskProxy;
        private readonly IMapper _mapper;

        public TaskController(ILogger<TaskController> logger, ITaskProxy taskProxy, IMapper mapper)
        {
            _logger = logger;
            _taskProxy = taskProxy;
            _mapper = mapper;
        }

        public IActionResult GetAllTasks()
        {   
            var taskModels = _mapper.Map<List<TaskModel>>(_taskProxy.GetAllTasks());
                       
            return View(taskModels);
        }

        [HttpPost]
        public IActionResult CreateTask(TaskModel taskModel)
        {
             
            // here call service(proxy) to chance status task
            // tasksTestMock = client.GetAllTasks();

            // taskModel.CreateDate = DateTime.Now;

            // tasksTestMock.Add(taskModel);
                        
            return RedirectToAction("GetAllTasks");
        }

        private List<TaskModel> Test(TaskModel task)
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
