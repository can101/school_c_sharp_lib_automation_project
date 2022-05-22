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

namespace library_automation.Pages
{
    public partial class UserAdd : Form
    {
        private UserDal _userDal;
        private FormManager _formManager;
        private FormImageUpload _formImageUpload;
        private InputController _inputController;
        public UserAdd()
        {
            InitializeComponent();
            _userDal = new UserDal();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            var imgUrl = _formImageUpload.CreateImageThenReturnUrl("user");
            var _user = new User()
            {
                Address = tbxUserAdress.Text,
                CreatedAt = DateTime.Now,
                Email = tbxUserMail.Text,
                FirstName = tbxUserName.Text,
                LastName = tbxUserSurname.Text,
                User_Img = imgUrl,
                PhoneNumber = tbxUserPhoneNo.Text
            };
            _userDal.Add(_user);
            _formManager.FormAddToPanel("userlist");
            tbxUserAdress.Text = "";
            tbxUserMail.Text = "";
            tbxUserName.Text = "";
            tbxUserSurname.Text = "";
            tbxUserPhoneNo.Text = "";
        }
        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void pbxUploadImage_Click(object sender, EventArgs e)
        {
            _formImageUpload.ImageUpload(pbxUploadImage);
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxUserSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxUserPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyWithoutTextAndChractersAndWithWitheSpaceWithNumber(e);
        }

        private void tbxUserAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
    }
}
