using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOrganizer.UI.Proxy.Entities;

namespace TaskOrganizer.UI.Proxy
{
    public interface ITaskProxy
    {
        List<ApiTaskResponse> GetAllTasks();
    }
}