using System;
using System.Web.UI;

namespace TaskManagementApp
{
    public partial class TaskManagement : Page
    {
        private readonly DAL.Interfaces.ITaskService _taskService;

        public TaskManagement()
        {
            _taskService = new DAL.Services.TaskService(new DAL.Services.TaskRepository(new TaskManagementApp.DAL.TaskDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string action = Request.QueryString["action"];
                int taskId = 0;
                if (int.TryParse(Request.QueryString["id"], out taskId))
                {
                    if (action == "edit")
                    {
                        // Load task details for editing
                        Model.TaskModel task = _taskService.GetById(taskId);
                        if (task != null)
                        {
                            txtTitle.Text = task.Title;
                            calDueDate.SelectedDate = task.DueDate;
                            chkIsCompleted.Checked = task.IsCompleted;
                            btnSave.Text = "Update";
                        }
                    }
                    else if (action == "delete")
                    {
                        // Handle the delete action
                        _taskService.Delete(taskId);
                    }
                }

                // Load the list of tasks into GridView1
                GridView1.DataSource = _taskService.GetAll();
                GridView1.DataBind();
            }
        }

        protected void SaveTask(object sender, EventArgs e)
        {
            int taskId = 0;
            if (int.TryParse(Request.QueryString["id"], out taskId))
            {
                // Editing an existing task
                Model.TaskModel task = _taskService.GetById(taskId);
                if (task != null)
                {
                    task.Title = txtTitle.Text;
                    task.DueDate = calDueDate.SelectedDate;
                    task.IsCompleted = chkIsCompleted.Checked;
                    _taskService.Update(task);
                }
            }
            else
            {
                // Adding a new task
                Model.TaskModel newTask = new Model.TaskModel
                {
                    Title = txtTitle.Text,
                    DueDate = calDueDate.SelectedDate,
                    IsCompleted = chkIsCompleted.Checked
                };
                _taskService.Add(newTask);
            }

            // Redirect back to the same page
            Response.Redirect("TaskManagement.aspx");
        }

        protected void CancelTask(object sender, EventArgs e)
        {
            // Redirect back to the same page
            Response.Redirect("TaskManagement.aspx");
        }

        protected void DeleteTask(object sender, EventArgs e)
        {
            // Handle the delete action (This is typically done in the Page_Load method)
        }
    }
}