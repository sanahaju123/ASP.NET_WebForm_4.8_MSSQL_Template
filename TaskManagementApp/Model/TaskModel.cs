using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagementApp.Model
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}