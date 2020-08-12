using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOrganizer.UI.Proxy.Entities;

namespace TaskOrganizer.UI.Proxy
{
    public class TaskProxy : ITaskProxy
    {
        private readonly ITaskService _taskService;

        public TaskProxy(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public List<ApiTaskResponse> GetAllTasks()
        {
            return _taskService.GetAllTasks();
        }
    }
}