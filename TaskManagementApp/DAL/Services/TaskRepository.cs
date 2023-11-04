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

        public List<Model.TaskModel> GetAll()
        {
            return _context.TaskModels.ToList();
        }

        public void Add(Model.TaskModel task)
        {
            _context.TaskModels.Add(task);
            _context.SaveChanges();
        }

        public void Update(Model.TaskModel task)
        {
            _context.Entry(task).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = GetById(id);
            if (task != null)
            {
                _context.TaskModels.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}