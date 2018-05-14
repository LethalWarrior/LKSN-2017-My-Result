using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SMK_Nusantara.Classes
{
    class Validation
    {
        Control.ControlCollection conn;
        ErrorProvider Eprof;

        public Validation(Control.ControlCollection coll, ErrorProvider eprof)
        {
            this.conn = coll;
            this.Eprof = eprof;
        }
        public void Clear()
        {
            foreach (Control c in this.conn)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
                else if(c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)c).SelectedItem = null;
                }
                else if(c.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)c).Value = DateTime.Today;
                }
                else if(c.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)c).Checked = false;
                }
                else if(c.GetType() == typeof(ListBox))
                {
                    ((ListBox)c).Items.Clear();
                }
            }
        }

        public void EnableAllControls()
        {
            foreach (Control c in this.conn)
            {
                if(c.GetType() != typeof(Label))
                c.Enabled = true;
            }
        }

        public void DisableAllControls()
        {
            foreach (Control c in this.conn)
            {
                if (c.GetType() != typeof(Label))
                    c.Enabled = false;
            }
        }
              
        public bool ValidateEmpty()
        {
            foreach (Control c in this.conn)
            {
                if (c.Enabled == true)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        if (string.IsNullOrEmpty(c.Text))
                        {
                            GlobalUse.GetErrorMessage("There is invalid input !");
                            Eprof.SetError(c, "This must be filled!");
                            return false;
                        }
                        else Eprof.SetError(c, "");
                    }
                    else if (c.GetType() == typeof(ComboBox))
                    {
                        if (((ComboBox)c).SelectedItem == null)
                        {
                            GlobalUse.GetErrorMessage("There is invalid input !");
                            Eprof.SetError(c, "Choose one!");
                            return false;
                        }
                        else Eprof.SetError(c, "");
                    }
                    else if(c.GetType() == typeof(ListBox))
                    {
                        if (((ListBox)c).Items.Count == 0)
                        {
                            GlobalUse.GetErrorMessage("There is invalid input !");
                            Eprof.SetError(c, "Must Fill at least one!");
                            return false;
                        }
                        else Eprof.SetError(c, "");
                    }
                   
                    
                }
            }
            return true;
        }

        public bool ValidateName(TextBox tbx)
        {
            if (!(tbx.Text.Length >= 3 && tbx.Text.Length <= 20))
            {
                GlobalUse.GetErrorMessage("There is invalid input !");
                Eprof.SetError(tbx, "Name must be 3 - 20 character!");
                return false;
            }
            else Eprof.SetError(tbx, "");
            return true;
            
        }

        public bool ValidatePhoneNumber(TextBox tbx)
        {
            Regex regex = new Regex("(08)(\\d{9}|\\d{10})");
            if (!(regex.IsMatch(tbx.Text)))
            {
                GlobalUse.GetErrorMessage("There is invalid input !");
                Eprof.SetError(tbx, "Phone must be 11 - 12 digit and start with 08");
                return false;
            }
            else Eprof.SetError(tbx, "");
            return true;


        }

       

        public bool ValidateAge(DateTimePicker dtp, int agemin, int agemax)
        {
            int age = DateTime.Today.Year - dtp.Value.Date.Year;
            if(!(age >= agemin && age <= agemax))
            {
                GlobalUse.GetErrorMessage("There is invalid input !");
                Eprof.SetError(dtp, string.Format("Age must be between {0} and {1}", agemin, agemax));
                return false;
            }
            else Eprof.SetError(dtp, "");
            return true;

           

        }


    }
}
