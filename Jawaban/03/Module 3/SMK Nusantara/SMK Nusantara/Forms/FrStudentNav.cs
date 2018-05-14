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
    public partial class FrStudentNav : Form
    {
        public FrStudentNav(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        public Student student;

        private void FrStudentNav_Load(object sender, EventArgs e)
        {
            LblStudent.Text = "Welcome," + student.Name;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (GlobalUse.GetChoiceMessage("Are you sure you want to logout??") == true)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrEditProfile edit = new FrEditProfile(this.student, this);
            edit.Show();
            this.Hide();
        }
    }
}
