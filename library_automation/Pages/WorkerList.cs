using library_automation.Entities.Concrete;
using library_automation.EntityFramework.Concrete;
using library_automation.FormProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation.Pages
{
    public partial class WorkerList : Form
    {
        private FormManager _formManager;
        private WorkerDal _workerDal;
        private FormImageUpload _formImageUpload;
        public WorkerList()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _workerDal = new WorkerDal();
            _formImageUpload = new FormImageUpload();
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            dataGridViewWorkerList.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewWorkerList.Visible = true;
            pictureBox1.Visible = false;
            timer1.Stop();
            dataGridViewWorkerList.DataSource = _workerDal.GetList();
        }

        private void dataGridViewWorkerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel.Visible = true;
            dataGridViewWorkerList.CurrentRow.Selected = true;
        }

        private void pbxEditBtn_Click(object sender, EventArgs e)
        {
            var _worker = new Entities.Concrete.Worker()
            {
                Id = Convert.ToInt32(dataGridViewWorkerList.CurrentRow.Cells[0].Value),
                FirstName = dataGridViewWorkerList.CurrentRow.Cells[1].Value.ToString(),
                LastName = dataGridViewWorkerList.CurrentRow.Cells[2].Value.ToString(),
                PhoneNumber = dataGridViewWorkerList.CurrentRow.Cells[3].Value.ToString(),
                Email = dataGridViewWorkerList.CurrentRow.Cells[4].Value.ToString(),
                Address = dataGridViewWorkerList.CurrentRow.Cells[5].Value.ToString(),
                Worker_Img = dataGridViewWorkerList.CurrentRow.Cells[6].Value.ToString(),
                CreatedAt = (DateTime)dataGridViewWorkerList.CurrentRow.Cells[7].Value,
            };
            FormManager._worker = _worker;
            _formManager.FormAddToPanel("workeredit");
            flowLayoutPanel.Visible = false;
            dataGridViewWorkerList.CurrentRow.Selected = false;
        }

        private void pbxDelBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this row?";
            string title = "Delete the row";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var deltPath = dataGridViewWorkerList.CurrentRow.Cells[7].Value.ToString();
                _formImageUpload.deleteFile(deltPath);
                var _worker = new Worker()
                {
                    Id = Convert.ToInt32(dataGridViewWorkerList.CurrentRow.Cells[0].Value),
                    FirstName = dataGridViewWorkerList.CurrentRow.Cells[1].Value.ToString(),
                    LastName = dataGridViewWorkerList.CurrentRow.Cells[2].Value.ToString(),
                    PhoneNumber = dataGridViewWorkerList.CurrentRow.Cells[3].Value.ToString(),
                    Email = dataGridViewWorkerList.CurrentRow.Cells[4].Value.ToString(),
                    Address = dataGridViewWorkerList.CurrentRow.Cells[5].Value.ToString(),
                    Worker_Img = dataGridViewWorkerList.CurrentRow.Cells[7].Value.ToString(),
                    CreatedAt = (DateTime)dataGridViewWorkerList.CurrentRow.Cells[8].Value,
                };
                _workerDal.Delete(_worker);
                timer1.Start();
                flowLayoutPanel.Visible = false;
                dataGridViewWorkerList.CurrentRow.Selected = false;
            }
        }

        private void pbxCancelBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Visible = false;
            dataGridViewWorkerList.CurrentRow.Selected = false;
        }
    }
}
