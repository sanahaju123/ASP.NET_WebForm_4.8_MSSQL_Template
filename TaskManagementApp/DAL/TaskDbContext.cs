using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Model.TaskModel> TaskModels { get; set; }

        public TaskDbContext() : base("YourConnectionStringName")
        {
        }
    }
}