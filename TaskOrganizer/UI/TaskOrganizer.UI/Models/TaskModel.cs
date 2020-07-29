using System;

namespace TaskOrganizer.UI.Models
{
    public class TaskModel
    {
        public int TaskNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }     
        public DateTime EstimatedDate { get; set; }
    }
}