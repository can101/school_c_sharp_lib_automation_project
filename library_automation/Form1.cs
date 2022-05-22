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
    public partial class Form1 : Form
    {
        private DragDropProperties _dragDropProperties;
        private FormManager _formManager;
        public static Panel _pnlMainContainer;
        public static Form _frm;
        public Form1()
        {
            InitializeComponent();
            _dragDropProperties = new DragDropProperties();
            _formManager = new FormManager(pnlMainContainer, this);
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            _pnlMainContainer = pnlMainContainer;
            _frm = this;
            _formManager.FormAddToPanel("");
            _dragDropProperties.default_form(this);
        }
        // form minimize and exit click event begin
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            _dragDropProperties.minimize_form(this);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _dragDropProperties.exit_form(this);
        }
        // form minimize and exit click event end
        // form dragdrop click event begin
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Move(this);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Down(this);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Up();
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Move(this);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Down(this);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragDropProperties.Up();
        }
        // form dragdrop click event end 
        // form event begin
        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("bookadd");
        }
        private void kitapListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("booklist");
        }
        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("useradd");
        }
        private void üyeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("userlist");
        }
        private void emanetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("depositadd");
        }
        private void emanetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("depositlist");
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("workeradd");
        }

        private void çalışanListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("workerlist");
        }
        // form event end
    }
}
