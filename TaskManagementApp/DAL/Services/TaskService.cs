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