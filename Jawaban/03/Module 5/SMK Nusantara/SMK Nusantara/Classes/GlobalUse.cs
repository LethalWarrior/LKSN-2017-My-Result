using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMK_Nusantara.Classes
{
    class GlobalUse
    {
        public static bool GetChoiceMessage(string message)
        {
            if(MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public static void GetInfoMessage(string mesage)
        {
            MessageBox.Show(mesage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void GetErrorMessage(string mesage)
        {
            MessageBox.Show(mesage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string GetFirstString(string str)
        {
            string[] strings = str.Split(' ');
            return strings.First();
        }

        public static string GetLastString(string str)
        {
            string[] strings = str.Split(' ');
            return strings.Last();
        }
    }
}
