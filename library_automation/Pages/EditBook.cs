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
    public partial class EditBook : Form
    {
        private Book _book;
        private FormManager _formManager;
        private BookDal _bookDal;
        private FormImageUpload _formImageUpload;
        private InputController _inputController;

        public EditBook(Book book)
        {
            InitializeComponent();
            _book = book;
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _bookDal = new BookDal();
            _formImageUpload = new FormImageUpload();
            _inputController = new InputController();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            tbxBookName.Text = _book.Name;
            tbxBookAuthor.Text = _book.Author;
            tbxBookAbstract.Text = _book.Abstract;
            tbxBookSheetCount.Value = Convert.ToInt32(_book.PageSheetCount);
            tbxPrintYear.Value = Convert.ToInt32(_book.PrintYear);
            tbxPrintHouse.Text = _book.PrintHouse;
            cbxBookLangugae.Text = _book.Language;
            pbxUploadImage.ImageLocation = _book.Book_Img;
        }
        private new void Update()
        {
            var _Ubook = new Book()
            {
                Id = (int)_book.Id,
                Name = _inputController.inputDataIsChange(_book.Name, tbxBookName.Text),
                Author = _inputController.inputDataIsChange(_book.Author, tbxBookAuthor.Text),
                Abstract = _inputController.inputDataIsChange(_book.Abstract, tbxBookAbstract.Text),
                Language = _inputController.inputDataIsChange(_book.Language, cbxBookLangugae.Text.ToString()),
                PageSheetCount = Convert.ToInt32(_inputController.inputDataIsChange(_book.PageSheetCount.ToString(), tbxBookSheetCount.Value.ToString())),
                PrintHouse = _inputController.inputDataIsChange(_book.PrintHouse, tbxPrintHouse.Text),
                PrintYear = Convert.ToInt32(_inputController.inputDataIsChange(_book.PrintYear.ToString(), tbxPrintYear.Value.ToString())),
                Book_Img = _book.Book_Img,
                CreatedAt = _book.CreatedAt,
                UpdatedAt = DateTime.Now
            };
            _bookDal.Update(_Ubook);
            _formManager.FormAddToPanel("booklist");
            tbxBookName.Text = "";
            tbxBookAuthor.Text = "";
            tbxBookAbstract.Text = "";
            cbxBookLangugae.Text = "";
            tbxBookSheetCount.Value = 0;
            tbxPrintHouse.Text = "";
            tbxPrintYear.Value = DateTime.Now.Year;
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void tbxBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
        private void tbxPrintHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }

        private void tbxBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputController.inputOnlyTextWithoutChractersWithWitheSpace(e);
        }
    }
}
