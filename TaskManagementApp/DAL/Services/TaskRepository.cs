using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TaskManagementApp.DAL.Interfaces;

namespace TaskManagementApp.DAL.Services
{
    public class TaskRepository : Interfaces.ITaskRepository
    {
        private TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }

        public Model.TaskModel GetById(int id)
        {
            return _context.TaskModels.FirstOrDefault(t => t.Id == id);
        }

        public string GetAll()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}