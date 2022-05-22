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
using System.IO;
using library_automation.FormProperties;

namespace library_automation
{
    public partial class AddBook : Form
    {
        private FormManager _formManager;
        private BookDal _bookDal;
        private FormImageUpload _formImageUpload;
        private InputController _inputController;
        public AddBook()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _bookDal = new BookDal();
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
        }
        private void pictureBtnBack_Click_1(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }
        private void Add()
        {
            var imgUrl = _formImageUpload.CreateImageThenReturnUrl("book");
            var _book = new Book()
            {
                Name = tbxBookName.Text.Trim(),
                Author = tbxBookAuthor.Text.Trim(),
                Abstract = tbxBookAbstract.Text.Trim(),
                Language = cbxBookLangugae.SelectedItem.ToString(),
                PageSheetCount = Convert.ToInt32(tbxBookSheetCount.Value),
                PrintHouse = tbxPrintHouse.Text.Trim(),
                PrintYear = (int)tbxPrintYear.Value,
                Book_Img = imgUrl,
                CreatedAt = DateTime.Now
            };
            _bookDal.Add(_book);
            _formManager.FormAddToPanel("booklist");
            tbxBookName.Text = "";
            tbxBookAuthor.Text = "";
            tbxBookAbstract.Text = "";
            cbxBookLangugae.Text = "choose langugae";
            tbxBookSheetCount.Value = 0;
            tbxPrintHouse.Text = "";
        }
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxBookName.Text.Trim()) || string.IsNullOrWhiteSpace(tbxBookAuthor.Text.Trim()) || string.IsNullOrWhiteSpace(tbxBookAbstract.Text.Trim()) || string.IsNullOrWhiteSpace(cbxBookLangugae.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(tbxBookSheetCount.Value.ToString()) || string.IsNullOrWhiteSpace(tbxPrintHouse.Text.Trim()) || string.IsNullOrWhiteSpace(tbxPrintYear.Value.ToString()))
            {
                MessageBox.Show("Lüfen tüm analanları doldurunuz! ^_^", "Bu bir uyarıdır.", MessageBoxButtons.OK);
            }
            else
            {
                Add();
            }
        }

        private void pbxUploadImage_Click(object sender, EventArgs e)
        {
            _formImageUpload.ImageUpload(pbxUploadImage);
        }

        private void tbxBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxPrintHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
    }
}
