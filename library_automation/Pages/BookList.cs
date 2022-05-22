using library_automation.EntityFramework.Abstract;
using library_automation.EntityFramework.Concrete;
using library_automation.Pages;
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
    public partial class BookList : Form
    {
        private FormManager _formManager;
        private BookDal _bookDal;
        private FormImageUpload _formImageUpload;
        public BookList()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _bookDal = new BookDal();
            _formImageUpload = new FormImageUpload();
        }
        private void pictureBtnBack_Click_1(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            dataGridViewBookList.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewBookList.Visible = true;
            pictureBox1.Visible = false;
            dataGridViewBookList.DataSource = _bookDal.GetList();
            timer1.Stop();
        }

        private void dataGridViewBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel.Visible = true;
            dataGridViewBookList.CurrentRow.Selected = true;
        }

        private void pbxDelBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this row?";
            string title = "Delete the row";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var delPath = dataGridViewBookList.CurrentRow.Cells[8].Value.ToString();
                _formImageUpload.deleteFile(delPath);
                var _book = new Entities.Concrete.Book()
                {
                    Id = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[0].Value),//
                    Name = dataGridViewBookList.CurrentRow.Cells[1].Value.ToString(),//
                    Author = dataGridViewBookList.CurrentRow.Cells[2].Value.ToString(),//
                    PrintYear = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[3].Value),//
                    PageSheetCount = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[4].Value),//
                    PrintHouse = dataGridViewBookList.CurrentRow.Cells[5].Value.ToString(),//
                    Abstract = dataGridViewBookList.CurrentRow.Cells[6].Value.ToString(),
                };
                _bookDal.Delete(_book);
                timer1.Start();
                flowLayoutPanel.Visible = false;
                dataGridViewBookList.CurrentRow.Selected = false;
            }
        }

        private void pbxEditBtn_Click(object sender, EventArgs e)
        {
            var _book = new Entities.Concrete.Book()
            {
                Id = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[0].Value),
                Name = dataGridViewBookList.CurrentRow.Cells[1].Value.ToString(),
                Author = dataGridViewBookList.CurrentRow.Cells[2].Value.ToString(),
                PrintYear = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[3].Value),
                PageSheetCount = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[4].Value),
                PrintHouse = dataGridViewBookList.CurrentRow.Cells[5].Value.ToString(),
                Language = dataGridViewBookList.CurrentRow.Cells[6].Value.ToString(),
                Abstract = dataGridViewBookList.CurrentRow.Cells[7].Value.ToString(),
                Book_Img = dataGridViewBookList.CurrentRow.Cells[8].Value.ToString(),
                CreatedAt = (DateTime)dataGridViewBookList.CurrentRow.Cells[9].Value,
            };
            FormManager._book = _book;
            _formManager.FormAddToPanel("bookedit");
            flowLayoutPanel.Visible = false;
            dataGridViewBookList.CurrentRow.Selected = false;
        }

        private void pbxCancelBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Visible = false;
            dataGridViewBookList.CurrentRow.Selected = false;
        }
    }
}
