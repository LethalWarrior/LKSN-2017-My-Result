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
    public partial class FrAdminNav : Form
    {
        public FrAdminNav()
        {
            InitializeComponent();
        }

        private void FrAdminNav_Load(object sender, EventArgs e)
        {

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

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            FrManageTeacher teacher = new FrManageTeacher();
            teacher.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            FrManageStudent student = new FrManageStudent();
            student.Show();
        }
    }
}
