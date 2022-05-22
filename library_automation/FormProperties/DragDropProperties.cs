using System;
using System.Drawing;
using System.Windows.Forms;

namespace library_automation
{
    internal class DragDropProperties
    {
        // CURRRENT CLOSE FORM BEGIN ------------------------------------------------------
        public void exit_form(Form frm)
        {
            frm.Close();
            Application.Exit();
        }      
        public void minimize_form(Form frm)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
        // CURRRENT CLOSE FORM END ------------------------------------------------------
        // DRAG DROP VERIABLES BEGIN ------------------------------------------------------
        private bool dragging = false;//Sürükleme özelliğimiz
        private Point dragCursorPoint;
        private Point dragFormPoint;
        // DRAG DROP VERIABLES END -------------------------------------------------------
        // FORM DEFAULT LOAD BEGIN
        public void default_form( Form frm)
        {
            frm.TopMost = true;
            frm.BringToFront();
            frm.Text = String.Empty;
            frm.ControlBox = true;
        }
        // FORM DEFAULT LOAD END
        public void Down(Form frm)
        //Tıkladığımızda mouse tuşu aşağı doğru hareket edince gerçekleşir.
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = frm.Location;
        }
        public void Up()
        //Mouse tuşu yukarı kalktığında gerçekleşecek ifademiz. 
        {
            dragging = false;
        }
        public void Move(Form frm)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                frm.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}