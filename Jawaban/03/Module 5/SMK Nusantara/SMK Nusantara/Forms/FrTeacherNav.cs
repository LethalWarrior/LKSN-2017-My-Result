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
        public FrTeacherNav(Teacher teacher, User user)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.user = user;
        }

        public Teacher teacher;
        User user;

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

        private void BtnTeaching_Click(object sender, EventArgs e)
        {
            FrTeachingSchedule schedule = new FrTeachingSchedule(this.teacher);
            schedule.Show();
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            FrInputScore score = new FrInputScore(this.teacher);
            score.Show();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            FrMessageMenu message = new FrMessageMenu(this.user, this);
            message.Show();
            this.Hide();
        }
    }
}
