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

namespace SMK_Nusantara.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            va = new Validation(this.Controls, Eva);
        }

        Validation va;
        ErrorProvider Eva = new ErrorProvider();

        User user;
        Student student;
        Teacher teacher;
        
        private bool CheckStudent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Student student = db.Students.Where(s => s.StudentId == user.username)
                    .FirstOrDefault();
                this.student = student;

                if (this.student != null)
                {
                    return true;
                }
                return false;
            }
        }

        private bool CheckTeacner()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Teacher teacher = db.Teachers.Where(s => s.TeacherId == user.username)
                    .FirstOrDefault();

                this.teacher = teacher;

                if (this.teacher != null)
                {
                    return true;
                }
                return false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    if (va.ValidateEmpty() == false) return;
                    user = db.Users.Where(u => u.username == TbxUsername.Text && u.password == TbxPassword.Text)
                        .FirstOrDefault();
                    if(user != null)
                    {
                        if(CheckStudent() == true)
                        {
                            FrStudentNav studentnav = new FrStudentNav(student);
                            studentnav.Show();
                            this.Hide();
                        }
                        else if(CheckTeacner() == true)
                        {
                            FrTeacherNav teachernav = new FrTeacherNav(this.teacher);
                            teachernav.Show();
                            this.Hide();
                        }
                    }
                    else if(TbxUsername.Text == "admin" && TbxPassword.Text == "admin")
                    {

                        FrAdminNav adminnav = new FrAdminNav();
                        adminnav.Show();
                        this.Hide();
                    }
                    else
                    {
                        GlobalUse.GetErrorMessage("Wrong username or password!");
                        va.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }
    }
}
