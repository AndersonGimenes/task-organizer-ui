using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOrganizer.UI.Proxy.Entities;

namespace TaskOrganizer.UI.Proxy
{
    public interface ITaskService
    {
        List<ApiTaskResponse> GetAllTasks();
    }
}