using library_automation.Entities.Concrete;
using library_automation.EntityFramework.Concrete;
using library_automation.FormProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation.Pages
{
    public partial class WorkerAdd : Form
    {
        private FormManager _formManager;
        private WorkerDal _workerDal;
        private FormImageUpload _formImageUpload;
        private InputController _inputController;
        public WorkerAdd()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _workerDal = new WorkerDal();
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
        }
        private void pbxUploadImage_Click(object sender, EventArgs e)
        {
            _formImageUpload.ImageUpload(pbxUploadImage);
        }



        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            var imgUrl = _formImageUpload.CreateImageThenReturnUrl("worker");
            var _worker = new Worker()
            {
                Address = tbxUserAdress.Text,
                CreatedAt = DateTime.Now,
                Email = tbxUserMail.Text,
                FirstName = tbxUserName.Text,
                LastName = tbxUserSurname.Text,
                Worker_Img = imgUrl,
                PhoneNumber = tbxUserPhoneNo.Text
            };
            _workerDal.Add(_worker);
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
