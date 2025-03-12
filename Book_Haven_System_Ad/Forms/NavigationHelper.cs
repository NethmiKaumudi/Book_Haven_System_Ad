using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Forms
{
    internal class NavigationHelper
    {
        public static void OpenForm(Form currentForm, Form newForm, bool closeCurrent = false)
        {
            newForm.Show();

            if (closeCurrent)
            {
                currentForm.Close();
            }
            else
            {
                currentForm.Hide();
            }
        }
    }
}
