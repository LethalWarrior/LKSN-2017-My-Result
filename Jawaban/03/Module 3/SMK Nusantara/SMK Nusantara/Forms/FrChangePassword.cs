using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMK_Nusantara.Database;
using SMK_Nusantara.Classes;
using System.Text.RegularExpressions;

namespace SMK_Nusantara.Forms
{
    public partial class FrChangePassword : Form
    {
        public FrChangePassword(Student student)
        {
            InitializeComponent();
            va = new Validation(this.Controls, EValidation);
            this.student = student;
        }

        public FrChangePassword(Teacher teacher)
        {
            InitializeComponent();
            va = new Validation(this.Controls, EValidation);
            this.teacher = teacher;
        }

        Validation va;
        ErrorProvider EValidation = new ErrorProvider();
        Student student;
        Teacher teacher;
        User user;

        private void GetUser()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if(student != null)
                {
                    user = db.Users.Where(u => u.username == student.StudentId)
                        .FirstOrDefault();

                }
                else if(teacher != null)
                {
                    user = db.Users.Where(u => u.username == teacher.TeacherId)
                        .FirstOrDefault();
                }
            }
        }

        private bool CheckOldPassword()
        {
            if (TbxOldPassword.Text == user.password) return true;
            return false;
        }

        private bool CheckNewPassword()
        {
            Regex regex = new Regex("");
            if (regex.IsMatch(TbxNewPassword.Text)) return true;
            return false;//not yet
        }

        private bool CheckConfirmPassword()
        {
            if (TbxConfirmPassword.Text == TbxNewPassword.Text) return true;
            return false;
        }

        private void FrChangePassword_Load(object sender, EventArgs e)
        {
            GetUser();

        }

        private void TbxOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (CheckOldPassword() == false) EValidation.SetError(TbxOldPassword, "Password is not match with old password");
            else EValidation.SetError(TbxOldPassword, "");
        }

        private void TbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (CheckNewPassword() == false) EValidation.SetError(TbxNewPassword, "Password must contains upcase, lowcas, and number");
            else EValidation.SetError(TbxNewPassword, "");
        }

        private void TbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (CheckConfirmPassword() == false) EValidation.SetError(TbxConfirmPassword, "Password must be same with new password");
            else EValidation.SetError(TbxConfirmPassword, "");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                User user = db.Users.Where(s => s.userid == this.user.userid)
                    .FirstOrDefault();
                if (va.ValidateEmpty() == false) return;
                if (GlobalUse.GetChoiceMessage("Are you sure with this data??") == false) return;
                user.password = TbxConfirmPassword.Text;
                db.SubmitChanges();
                GlobalUse.GetInfoMessage("Success !");
                this.Close();
            }
        }
    }
}
