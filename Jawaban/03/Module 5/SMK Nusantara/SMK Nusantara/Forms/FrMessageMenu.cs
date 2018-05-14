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
    public partial class FrMessageMenu : Form
    {
        public FrMessageMenu(User user, FrTeacherNav teachernav)
        {
            InitializeComponent();
            this.user = user;
            this.teachernav = teachernav;
        }

        public FrMessageMenu(User user, FrStudentNav studentnav)
        {
            InitializeComponent();
            this.user = user;
            this.studentnav = studentnav;
        }

        User user;
        FrTeacherNav teachernav;
        FrStudentNav studentnav;


        private void FrMessageMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrNewMessage newm = new FrNewMessage(this.user);
            newm.Show();
        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            FrInbox inbox = new FrInbox(this.user);
            inbox.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if(studentnav != null)
            {
                studentnav.Show();
                this.Close();
            }
            else if(teachernav != null)
            {
                teachernav.Show();
                this.Close();
            }
        }

        private void BtnSentItems_Click(object sender, EventArgs e)
        {
            FrSentItems sent = new FrSentItems(this.user);
            sent.Show();
        }
    }
}
