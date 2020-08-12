using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using TaskOrganizer.UI.Proxy.Entities;
using Newtonsoft.Json;

namespace TaskOrganizer.UI.Proxy
{
    public class TaskService : ITaskService
    {
        public List<ApiTaskResponse> GetAllTasks()
        {
            try
            {
                var client = new RestClient("http://localhost:5000/api/");
                var request = new RestRequest("task", Method.GET);

                var result = client.Get(request);
                return JsonConvert.DeserializeObject<List<ApiTaskResponse>>(result.Content);

            }
            catch(WebException)
            {
                throw;
            }
        }
    }
}