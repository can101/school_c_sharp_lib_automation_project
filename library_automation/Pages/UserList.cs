using library_automation.Entities.Concrete;
using library_automation.EntityFramework;
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
using System.IO;
using library_automation.FormProperties;

namespace library_automation
{
    public partial class UserList : Form
    {
        private FormManager _formManager;
        private UserDal _userDal;
        private FormImageUpload _formImageUpload;
        public UserList()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _userDal = new UserDal();
            _formImageUpload = new FormImageUpload();
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            dataGridViewUserList.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewUserList.Visible = true;
            pictureBox1.Visible = false;
            timer1.Stop();
            dataGridViewUserList.DataSource = _userDal.GetList();
        }

        private void dataGridViewUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanelED.Visible = true;
            dataGridViewUserList.CurrentRow.Selected = true;
        }

        private void pbxDelBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this row?";
            string title = "Delete the row";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var delPath = (string)dataGridViewUserList.CurrentRow.Cells[6].Value.ToString();
                _formImageUpload.deleteFile(delPath);
                var _user = new User()
                {
                    Id = (int)dataGridViewUserList.CurrentRow.Cells[0].Value,
                    FirstName = (string)dataGridViewUserList.CurrentRow.Cells[1].Value,
                    LastName = (string)dataGridViewUserList.CurrentRow.Cells[2].Value,
                    PhoneNumber = (string)dataGridViewUserList.CurrentRow.Cells[3].Value,
                    Email = (string)dataGridViewUserList.CurrentRow.Cells[4].Value,
                    Address = (string)dataGridViewUserList.CurrentRow.Cells[5].Value,
                    User_Img = (string)dataGridViewUserList.CurrentRow.Cells[6].Value,
                    CreatedAt = (DateTime)dataGridViewUserList.CurrentRow.Cells[7].Value,
                };
                _userDal.Delete(_user);
                timer1.Start();
                flowLayoutPanelED.Visible = false;
                dataGridViewUserList.CurrentRow.Selected = false;
            }
        }

        private void pbxEditBtn_Click(object sender, EventArgs e)
        {
            var _user = new User()
            {
                Id = (int)dataGridViewUserList.CurrentRow.Cells[0].Value,
                FirstName = (string)dataGridViewUserList.CurrentRow.Cells[1].Value,
                LastName = (string)dataGridViewUserList.CurrentRow.Cells[2].Value,
                PhoneNumber = (string)dataGridViewUserList.CurrentRow.Cells[3].Value,
                Email = (string)dataGridViewUserList.CurrentRow.Cells[4].Value,
                Address = (string)dataGridViewUserList.CurrentRow.Cells[5].Value,
                User_Img = (string)dataGridViewUserList.CurrentRow.Cells[6].Value,
                CreatedAt = (DateTime)dataGridViewUserList.CurrentRow.Cells[7].Value,
            };
            FormManager._user = _user;
            _formManager.FormAddToPanel("useredit");
            flowLayoutPanelED.Visible = false;
            dataGridViewUserList.CurrentRow.Selected = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelED.Visible = false;
            dataGridViewUserList.CurrentRow.Selected = false;
        }
    }
}
