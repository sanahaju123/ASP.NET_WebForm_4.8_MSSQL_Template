using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL.Interfaces
{
    public interface ITaskService
    {
        Model.TaskModel GetById(int id);
        List<Model.TaskModel> GetAll();
        void Add(Model.TaskModel task);
        void Update(Model.TaskModel task);
        void Delete(int id);
    }
}
