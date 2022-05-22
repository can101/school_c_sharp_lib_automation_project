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
    public partial class WorkerEdit : Form
    {
        private FormManager _formManager;
        private WorkerDal _workerDal;
        private Worker _worker;
        private FormImageUpload _formImageUpload;
        private InputController _inputController;
        public WorkerEdit(Worker worker)
        {
            InitializeComponent();
            _workerDal = new WorkerDal();
            _worker = worker;
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
        }
        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            tbxUserAdress.Text = _worker.Address;
            tbxUserMail.Text = _worker.Email;
            tbxUserName.Text = _worker.FirstName;
            tbxUserPhoneNo.Text = _worker.PhoneNumber;
            tbxUserSurname.Text = _worker.LastName;
            pbxUploadImage.ImageLocation = _worker.Worker_Img;
        }


        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void btnWorkerUpdate_Click(object sender, EventArgs e)
        {
            var _Uworker = new Worker()
            {
                Id = (int)_worker.Id,
                Address = _inputController.inputDataIsChange(_worker.Address, tbxUserAdress.Text),
                Email = _inputController.inputDataIsChange(_worker.Email, tbxUserMail.Text),
                FirstName = _inputController.inputDataIsChange(_worker.FirstName, tbxUserName.Text),
                LastName = _inputController.inputDataIsChange(_worker.LastName, tbxUserSurname.Text),
                PhoneNumber = _inputController.inputDataIsChange(_worker.PhoneNumber, tbxUserPhoneNo.Text),
                Worker_Img = _worker.Worker_Img,
                CreatedAt = _worker.CreatedAt,
                UpdatedAt = DateTime.Now,
            };
            _workerDal.Update(_Uworker);
            _formManager.FormAddToPanel("workerlist");
            tbxUserAdress.Text = "";
            tbxUserMail.Text = "";
            tbxUserName.Text = "";
            tbxUserSurname.Text = "";
            tbxUserPhoneNo.Text = "";
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxUserSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
        private void tbxUserAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
    }
}
