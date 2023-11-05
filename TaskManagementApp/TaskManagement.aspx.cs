using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaskManagementApp.DAL;

namespace TaskManagementApp
{
    public partial class TaskManagement : Page
    {
        datalayer dl;
        private readonly DAL.Interfaces.ITaskService _taskService;

        public TaskManagement()
        {
            _taskService = new DAL.Services.TaskService(new DAL.Services.TaskRepository(new TaskManagementApp.DAL.TaskDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = _taskService.GetAll();
            dl = new datalayer();
            dl.fillgridView(query, gv);

        }
        static string Id;
        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = gv.SelectedRow.Cells[1].Text.ToString();
            txtTitle.Text = gv.SelectedRow.Cells[2].Text.ToString();
            txtIsCompleted.Text = gv.SelectedRow.Cells[3].Text.ToString();
            txtDueDate.Text = gv.SelectedRow.Cells[4].Text.ToString();
           
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            var query = _taskService.Add();
            string qry = query + txtTitle.Text + "','" + txtIsCompleted.Text + "','" + txtDueDate.Text + "')";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);

            
            txtTitle.Text = "";
            txtIsCompleted.Text = "";
            txtDueDate.Text = "";
        
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            var query = _taskService.Update();
            string qry = query + txtTitle.Text + "',IsCompleted='" + txtIsCompleted.Text + "',DueDate='" + txtDueDate.Text;
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
            txtTitle.Text = "";
            txtIsCompleted.Text = "";
            txtDueDate.Text = "";
        
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            var query = _taskService.Delete();
            string qry = query + Id + "'";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
        }
    }
}