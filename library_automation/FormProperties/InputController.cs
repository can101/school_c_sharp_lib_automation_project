using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation.FormProperties
{
    public class InputController
    {
        public void inputOnlyTextWithoutChractersWithWitheSpace(KeyPressEventArgs a)
        {
            if (!char.IsControl(a.KeyChar) && !char.IsLetter(a.KeyChar) && !char.IsWhiteSpace(a.KeyChar))
            {
                a.Handled = true;
            }
        }
        public void inputOnlyWithoutTextAndChractersAndWithWitheSpaceWithNumber(KeyPressEventArgs a)
        {
            if (!char.IsControl(a.KeyChar) && !char.IsDigit(a.KeyChar))
            {
                a.Handled = true;
            }
        }
        public string inputDataIsChange(string oldValue, string newValue)
        {
            return oldValue == newValue ? oldValue : newValue;
        }
    }
}
