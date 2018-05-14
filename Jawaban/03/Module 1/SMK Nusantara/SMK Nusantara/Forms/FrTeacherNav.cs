using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMK_Nusantara.Classes;
using SMK_Nusantara.Database;

namespace SMK_Nusantara.Forms
{
    public partial class FrTeacherNav : Form
    {
        public FrTeacherNav(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        public Teacher teacher;

        private void FrTeacherNav_Load(object sender, EventArgs e)
        {
            LblTeacher.Text = "Welcome, " + teacher.Name;
        }

        private void button4_Click(object sender, EventArgs e)
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
            FrEditProfile edit = new FrEditProfile(this.teacher, this);
            edit.Show();
            this.Hide();
        }
    }
}
