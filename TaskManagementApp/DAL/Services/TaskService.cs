using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaskManagementApp.DAL.Interfaces;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL.Services
{
    public class TaskService : Interfaces.ITaskService
    {
        private Interfaces.ITaskRepository _repository;

        public TaskService(Interfaces.ITaskRepository repository)
        {
            _repository = repository;
        }

        public Model.TaskModel GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Model.TaskModel> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Model.TaskModel task)
        {
            _repository.Add(task);
        }

        public void Update(Model.TaskModel task)
        {
            _repository.Update(task);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}