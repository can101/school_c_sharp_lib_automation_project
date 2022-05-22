using library_automation.Entities.Concrete;
using library_automation.EntityFramework;
using library_automation.EntityFramework.Concrete;
using library_automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation
{
    public class FormManager
    {
        public static Book _book;
        public static User _user;
        public static Deposit _deposit;
        public static Worker _worker;
        //global veriables begin
        private Panel _panel = null;
        private Form _form = null;
        //global veriables end
        //constructor begin
        public FormManager(Panel panel, Form frm)
        {
            _panel = panel;
            _form = frm;
        }
        //constructor end
        //form print the panel method begin
        private void CallForm(Form frm)
        {
            _panel.Controls.Clear();
            frm.MdiParent = _form;
            frm.FormBorderStyle = FormBorderStyle.None;
            _panel.Controls.Add(frm);
            frm.Show();
        }
        //form print the panel method end
        public void FormAddToPanel(string frm_name)
        {
            switch (frm_name)
            {
                case "useradd":
                    UserAdd userAdd = new UserAdd();
                    CallForm(userAdd);
                    break;
                case "useredit":
                    UserEdit userEdit = new UserEdit(_user);
                    CallForm(userEdit);
                    break;
                case "userlist":
                    UserList userlist = new UserList();
                    CallForm(userlist);
                    break;
                case "depositadd":
                    DepositTab addDeposit = new DepositTab();
                    CallForm(addDeposit);
                    break;
                case "depositlist":
                    DepositList depositList = new DepositList();
                    CallForm(depositList);
                    break;
                case "depositedit":
                    DepositEdit depositEdit = new DepositEdit(_deposit);
                    CallForm(depositEdit);
                    break;
                case "bookadd":
                    AddBook book = new AddBook();
                    CallForm(book);
                    break;
                case "bookedit":
                    EditBook bookEdit = new EditBook(_book);
                    CallForm(bookEdit);
                    break;
                case "booklist":
                    BookList bookList = new BookList();
                    CallForm(bookList);
                    break;
                case "workeradd":
                    WorkerAdd workeradd = new WorkerAdd();
                    CallForm(workeradd);
                    break;
                case "workerlist":
                    WorkerList workerlist = new WorkerList();
                    CallForm(workerlist);
                    break;
                case "workeredit":
                    WorkerEdit workerEdit = new WorkerEdit(_worker);
                    CallForm(workerEdit);
                    break;
                default:
                    Home home = new Home();
                    CallForm(home);
                    break;
            }
        }
    }
}
