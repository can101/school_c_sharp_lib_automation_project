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
    public partial class UserEdit : Form
    {
        private FormImageUpload _formImageUpload;
        private InputController _inputController;
        private FormManager _formManager;
        private UserDal _userDal;
        private User _user;
        public UserEdit(User user)
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
            _userDal = new UserDal();
            _user = user;
        }

        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            var _Uuser = new User()
            {
                Id = (int)_user.Id,
                Address = _inputController.inputDataIsChange(_user.Address, tbxUserAdress.Text),
                Email = _inputController.inputDataIsChange(_user.Email, tbxUserMail.Text),
                FirstName = _inputController.inputDataIsChange(_user.FirstName, tbxUserName.Text),
                LastName = _inputController.inputDataIsChange(_user.LastName, tbxUserSurname.Text),
                PhoneNumber = _inputController.inputDataIsChange(_user.PhoneNumber, tbxUserPhoneNo.Text),
                User_Img = _user.User_Img,
                CreatedAt = _user.CreatedAt,
                UpdatedAt = DateTime.Now,
            };
            _userDal.Update(_Uuser);
            _formManager.FormAddToPanel("userlist");
            tbxUserAdress.Text = "";
            tbxUserMail.Text = "";
            tbxUserName.Text = "";
            tbxUserSurname.Text = "";
            tbxUserPhoneNo.Text = "";
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            tbxUserAdress.Text = _user.Address;
            tbxUserMail.Text = _user.Email;
            tbxUserName.Text = _user.FirstName;
            tbxUserPhoneNo.Text = _user.PhoneNumber;
            tbxUserSurname.Text = _user.LastName;
            pbxUploadImage.ImageLocation = _user.User_Img;
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
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

        private void pbxUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
