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
    public partial class FrNewMessage : Form
    {
        public FrNewMessage(User user)
        {
            InitializeComponent();
            this.user = user;
            contentva = new Validation(this.Controls, EValidation);
            destva = new Validation(groupBox1.Controls, EValidation);
        }

        User user;
        Validation contentva;
        Validation destva;
        ErrorProvider EValidation = new ErrorProvider();
        
        private void GetStudent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = from u in db.Users
                           join s in db.Students
                           on u.username equals s.StudentId
                           where (u.userid != user.userid)
                           select new
                           {
                               s.StudentId,
                               s.Name,
                           };
                foreach (var l in List)
                {
                    CbxStudent.Items.Add(string.Format("{0} - {1}", l.StudentId, l.Name));
                }
            }
        }

        private void GetTeacher()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = from u in db.Users
                           join s in db.Teachers
                           on u.username equals s.TeacherId
                           where (u.userid != user.userid)
                           select new
                           {
                               s.TeacherId,
                               s.Name,
                           };
                foreach (var l in List)
                {
                    CbxTeacher.Items.Add(string.Format("{0} - {1}", l.TeacherId, l.Name));
                }
            }
        }

        private List<User> GetUserList()
        {
            List<User> users = new List<User>();
            using (SampleDataContext db = new SampleDataContext())
            {
                foreach (var l in LbxDestination.Items)
                {
                    User user = db.Users.Where(u => u.username == l.ToString()).FirstOrDefault();
                    users.Add(user);
                }
                return users;
            }
        }

        private void FrNewMessage_Load(object sender, EventArgs e)
        {
            GetStudent(); GetTeacher();
        }

        private void SavetoDatabase()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if (LbxDestination.Items.Count > 0)
                {
                    List<User> users = GetUserList();
                    foreach (User u in users)
                    {
                        db.Messages.InsertOnSubmit(new Database.Message
                        {
                            Title = TbxTitle.Text,
                            RecipientId = u.userid,
                            AuthorId = this.user.userid,
                            Content = TbxContent.Text,
                            SentDate = DateTime.Now,
                        });
                    }
                    db.SubmitChanges();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxStudent.SelectedItem != null)
            {
                LbxDestination.Items.Add(GlobalUse.GetFirstString(CbxStudent.SelectedItem.ToString()));
        
            }
        }

        private void CbxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxTeacher.SelectedItem != null)
            {
                LbxDestination.Items.Add(GlobalUse.GetFirstString(CbxTeacher.SelectedItem.ToString()));


            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentva.ValidateEmpty() == false) return;
                if (GlobalUse.GetChoiceMessage("You will sent this message to the recipients. Are you sure?") == false) return;
                SavetoDatabase();
                GlobalUse.GetInfoMessage("Success!");
                contentva.Clear();
                destva.Clear();

            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }
    }
}
