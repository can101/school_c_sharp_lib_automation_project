using library_automation.Entities.Concrete;
using library_automation.EntityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation
{
    public partial class DepositList : Form
    {
        private FormManager _formManager;
        private DepositDal _depositDal;
        public DepositList()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _depositDal = new DepositDal();
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void DepositList_Load(object sender, EventArgs e)
        {
            dataGridViewDepositList.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewDepositList.Visible = true;
            pictureBox1.Visible = false;
            dataGridViewDepositList.DataSource = _depositDal.GetList();
            timer1.Stop();
        }

        private void dataGridViewDepositList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel.Visible = true;
            dataGridViewDepositList.CurrentRow.Selected = true;
        }

        private void pbxDelBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this row?";
            string title = "Delete the row";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var _deposit = new Deposit()
                {
                    Id = Convert.ToInt32(dataGridViewDepositList.CurrentRow.Cells[0].Value),

                };
                _depositDal.Delete(_deposit);
                timer1.Start();
                flowLayoutPanel.Visible = false;
                dataGridViewDepositList.CurrentRow.Selected = false;
            }
        }

        private void pbxEditBtn_Click(object sender, EventArgs e)
        {
            var _deposit = new Deposit()
            {
                Id = (int)dataGridViewDepositList.CurrentRow.Cells[0].Value,
                UserNo = (int)dataGridViewDepositList.CurrentRow.Cells[1].Value,
                BookNo = (int)dataGridViewDepositList.CurrentRow.Cells[2].Value,
                DepositNote = (string)dataGridViewDepositList.CurrentRow.Cells[3].Value,
                IsDepositDelivered = (string)dataGridViewDepositList.CurrentRow.Cells[4].Value,
                BackDate = (DateTime)dataGridViewDepositList.CurrentRow.Cells[5].Value,
                CreatedAt = DateTime.Now,
            };
            FormManager._deposit = _deposit;
            _formManager.FormAddToPanel("depositedit");
            flowLayoutPanel.Visible = false;
            dataGridViewDepositList.CurrentRow.Selected = false;
        }

        private void pbxCancelBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Visible = false;
            dataGridViewDepositList.CurrentRow.Selected = false;
        }
    }
}
