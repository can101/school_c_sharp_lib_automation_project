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
    public partial class DepositTab : Form
    {
        private FormManager _formManager;
        private DepositDal _depositDal;
        private UserDal _userDal;
        private BookDal _bookDal;
        private InputController _inputController;
        int idUser, idBook;

        public DepositTab()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _inputController = new InputController();
            _depositDal = new DepositDal();
            _userDal = new UserDal();
            _bookDal = new BookDal();
        }
        private void btnController()
        {
            if (string.IsNullOrWhiteSpace(idBook.ToString()) || string.IsNullOrWhiteSpace(idUser.ToString()))
            {
                btnGiveDepositBookBtn.Visible = true;
            }
        }
        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDepositList.DataSource = _userDal.GetList(p => p.Id == numericUpDown1.Value);
            dataGridViewDepositList.Visible = true;
            idUser = Convert.ToInt32(dataGridViewDepositList.CurrentRow.Cells[0].Value);
            btnController();
        }

        private void btnGiveDepositBookBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var _deposit = new Deposit()
            {
                UserNo = idUser,
                BookNo = idBook,
                BackDate = dtpbxBackDate.Value,
                DepositNote = rchtbxDepositNote.Text,
                IsDepositDelivered = false.ToString(),
                CreatedAt = DateTime.Now,
            };
            _depositDal.Add(_deposit);
            _formManager.FormAddToPanel("depositlist");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookDal.GetList(p => p.Id == numericUpDown2.Value);
            dataGridView1.Visible = true;
            idBook = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            btnController();
        }

        private void DepositTab_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
