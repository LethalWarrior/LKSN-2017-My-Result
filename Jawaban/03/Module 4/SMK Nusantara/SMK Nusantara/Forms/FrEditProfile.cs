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
using SMK_Nusantara.Forms;
using System.IO;

namespace SMK_Nusantara.Forms
{
    public partial class FrEditProfile : Form
    {
        public FrEditProfile(Teacher teacher, FrTeacherNav teacherfr)
        {
            InitializeComponent();
            va = new Validation(this.Controls, EValidation);
            this.teacher = teacher;
            this.teachernav = teacherfr;
         
        }

        public FrEditProfile(Student student, FrStudentNav studentnav)
        {
            InitializeComponent();
            va = new Validation(this.Controls, EValidation);
            this.student = student;
            this.studentnav = studentnav;
     
        }

        Student student;
        Teacher teacher;
        FrTeacherNav teachernav;
        FrStudentNav studentnav;
        FrChangePassword change;

        string path;
        string newpath;
        string filename;
        string Oldfilename;

        Validation va;
        ErrorProvider EValidation = new ErrorProvider();

        private void GetEntry()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if(student != null)
                {
                    TbxID.Text = student.StudentId;
                    TbxName.Text = student.Name;
                    TbxPhone.Text = student.PhoneNumber;
                    TbxAddress.Text = student.Address;
                    if(student.Photo != null)
                    {
                        PbxPicture.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + student.Photo);
                        Oldfilename = student.Photo;
                    }
                    
                }
                else if(teacher != null)
                {
                    TbxID.Text = teacher.TeacherId;
                    TbxName.Text = teacher.Name;
                    TbxPhone.Text = teacher.PhoneNumber;
                    TbxAddress.Text = teacher.Address;
                    if (teacher.Photo != null)
                    {
                        PbxPicture.Image = Image.FromFile(Application.StartupPath + "\\Images\\" +teacher.Photo);
                        Oldfilename = teacher.Photo;
                    }
                    
                }
            }
        }

        private string GetTimestamp()
        {
            return DateTime.Now.ToString("ddMMyyhhmmss");
        }

        private void SavePicture()
        {
            if (path != null)
            {
                filename = GetTimestamp() + Path.GetExtension(path);
                newpath = Application.StartupPath + "\\Images\\" + filename;
                File.Copy(path, newpath);
            }
        }

        private void DeleteCurrent()
        {
            if(Oldfilename != null)
            {
                File.Delete(Application.StartupPath + "\\Images\\" + Oldfilename);
            }
        }

        private void UpdateProfile()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if (this.student != null)
                {
                    Student student = db.Students.Where(s => s.StudentId == this.student.StudentId)
                        .FirstOrDefault();
                    student.Name = TbxName.Text;
                    student.PhoneNumber = TbxPhone.Text;
                    student.Address = TbxAddress.Text;
                    if (newpath != null)
                    {
                        student.Photo = filename;
                    }
                    this.student = student;
                    db.SubmitChanges();
                }
                else if(this.teacher != null)
                {
                    Teacher teacher = db.Teachers.Where(t => t.TeacherId == this.teacher.TeacherId)
                        .FirstOrDefault();
                    teacher.Name = TbxName.Text;
                    teacher.PhoneNumber = TbxPhone.Text;
                    teacher.Address = TbxAddress.Text;
                    if (newpath != null)
                    {
                        teacher.Photo = filename;
                    }
                    this.teacher = teacher;
                    db.SubmitChanges();
                }
            
            }
        }

        private void FrEditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                GetEntry();
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }

        private void PbxPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG Files|*.png|JPEG Files|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    PbxPicture.Image = Image.FromFile(path);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (va.ValidateEmpty() == false) return;
                if(GlobalUse.GetChoiceMessage("Are you sure with these data??") == true)
                {
                    if (va.ValidateEmpty() == false) return;
                    SavePicture();
                    UpdateProfile();
                    GlobalUse.GetInfoMessage("Successfully updating profile!");
                    
                }
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(student != null)
            {
                studentnav.student = this.student;
                studentnav.Show();
                if (change != null) change.Close();
                this.Close();
            }
            else if(teacher != null)
            {
                teachernav.teacher = this.teacher;
                teachernav.Show();
                if (change != null) change.Close();
                this.Close();
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if(student != null)
            {
                change = new FrChangePassword(this.student);
                change.Show();

            }
            else
            {
                change = new FrChangePassword(this.teacher);
                change.Show();
            }
        }
    }
}
