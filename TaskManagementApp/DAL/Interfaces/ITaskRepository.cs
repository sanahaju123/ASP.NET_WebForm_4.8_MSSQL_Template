using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL.Interfaces
{
    public interface ITaskRepository
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();
    }
}
