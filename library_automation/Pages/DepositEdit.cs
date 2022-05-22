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

namespace library_automation.Pages
{
    public partial class DepositEdit : Form
    {
        private Deposit _deposit;
        private DepositDal _depositDal;
        private FormManager _formManager;
        public DepositEdit(Deposit deposit)
        {
            InitializeComponent();
            _deposit = deposit;
            _depositDal = new DepositDal();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
        }

        private void btnGiveDepositBookBtn_Click(object sender, EventArgs e)
        {
            var _Udeposit = new Deposit()
            {
                Id = (int)_deposit.Id,
                BookNo = (int)tbxBookNo.Value,
                UserNo = (int)tbxUserNo.Value,
                DepositNote = rchtbxDepositNote.Text,
                BackDate = dtpbxBackDate.Value,
                IsDepositDelivered = chkbxIsDepositDelivered.Checked ? true.ToString() : false.ToString(),
                UpdatedAt = DateTime.Now,
                CreatedAt = Convert.ToDateTime(_deposit.CreatedAt),
            };
            _depositDal.Update(_Udeposit);
            _formManager.FormAddToPanel("depositlist");
            tbxBookNo.Value = 0;
            tbxUserNo.Value = 0;
            rchtbxDepositNote.Text = "";
            dtpbxBackDate.Value = DateTime.Now;
        }

        private void DepositEdit_Load(object sender, EventArgs e)
        {
            tbxBookNo.Value = Convert.ToInt32(_deposit.BookNo);
            tbxUserNo.Value = Convert.ToInt32(_deposit.UserNo);
            rchtbxDepositNote.Text = _deposit.DepositNote;
            dtpbxBackDate.Value = _deposit.BackDate;
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }
    }
}
