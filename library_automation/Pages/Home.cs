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
    public partial class Home : Form
    {
        private FormManager _formManager;
        public Home()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
        } 

        private void BookAdd_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("bookadd");
        }

        private void bookList_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("booklist");
        }

        private void addDeposit_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("depositadd");
        }

        private void depositList_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("depositlist");
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("useradd");
        }

        private void workeradd_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("workeradd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("workerlist");
        }

        private void userList_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("userlist");
        }
    }
}
