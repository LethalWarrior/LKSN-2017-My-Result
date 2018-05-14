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
using System.Data.Linq.SqlClient;

namespace SMK_Nusantara.Forms
{
    public partial class FrSentItems : Form
    {
        public FrSentItems(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        Database.Message selectedMessage;

        private void RefreshDGVMesage()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVMessage.DataSource = from m in db.Messages
                                        join u in db.Users
                                        on m.RecipientId equals u.userid
                                        where m.AuthorId == user.userid
                                        select new
                                        {
                                            m.MessageId,
                                            To = u.username,
                                            m.Title,
                                            m.SentDate
                                        };
                DGVMessage.Columns["MessageId"].Visible = false;
            }
        }

        private void SearchByTitle()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                
                    DGVMessage.DataSource = from m in db.Messages
                                            join u in db.Users
                                            on m.RecipientId equals u.userid
                                            where m.AuthorId == user.userid && SqlMethods.Like(m.Title, "%"+ TbxSearch.Text +"%")
                                            select new
                                            {
                                                m.MessageId,
                                                To = u.username,
                                                m.Title,
                                                m.SentDate
                                            };
                    DGVMessage.Columns["MessageId"].Visible = false;
                   
                
            }
        }

        private void SearchByContent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {

                DGVMessage.DataSource = from m in db.Messages
                                        join u in db.Users
                                        on m.RecipientId equals u.userid
                                        where m.AuthorId == user.userid && SqlMethods.Like(m.Content,"%" + TbxSearch.Text +"%")
                                        select new
                                        {
                                            m.MessageId,
                                            To = u.username,
                                            m.Title,
                                            m.SentDate
                                        };
                DGVMessage.Columns["MessageId"].Visible = false;


            }
        }

        private bool CheckStudent(string username)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Student student = db.Students.Where(s => s.StudentId == username).FirstOrDefault();
                if (student != null) return true;
                return false;
            }
        }

        private bool CheckTeacher(string username)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Teacher teacher = db.Teachers.Where(s => s.TeacherId == username).FirstOrDefault();
                if (teacher != null) return true;
                return false;
            }
        }

        private void SearchByNameStudent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {

                DGVMessage.DataSource = from m in db.Messages
                                        join u in db.Users
                                        on m.RecipientId equals u.userid
                                        join st in db.Students
                                        on u.username equals st.StudentId
                                        where m.AuthorId == user.userid && SqlMethods.Like(st.Name, "%" + TbxSearch.Text + "%")
                                        select new
                                        {
                                            m.MessageId,
                                            To = u.username,
                                            m.Title,
                                            m.SentDate

                                        };
                DGVMessage.Columns["MessageId"].Visible = false;


            }
        }

        private void SearchByNameTeacher()
        {
            using (SampleDataContext db = new SampleDataContext())
            {

                DGVMessage.DataSource = from m in db.Messages
                                        join u in db.Users
                                        on m.RecipientId equals u.userid
                                        join t in db.Teachers
                                        on u.username equals t.TeacherId
                                        where m.AuthorId == user.userid && SqlMethods.Like(t.Name, "%" + TbxSearch.Text + "%")
                                        select new
                                        {
                                            m.MessageId,
                                            To = u.username,
                                            m.Title,
                                            m.SentDate

                                        };
                DGVMessage.Columns["MessageId"].Visible = false;


            }
        }

        private void DeleteFromDatabase()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Database.Message message = db.Messages.Where(m => m.MessageId == selectedMessage.MessageId).FirstOrDefault();
                db.Messages.DeleteOnSubmit(message);
                db.SubmitChanges();
            }
        }


        private bool CheckDGV()
        {
            if (DGVMessage.Rows.Count > 0) return true;
            return false;
        }

        private void FrInbox_Load(object sender, EventArgs e)
        {
            RefreshDGVMesage();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if(selectedMessage != null)
            {
                FrMessageDetail detail = new FrMessageDetail(this.selectedMessage);
                detail.Show();
            }
        }

        private void DGVMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVMessage.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    selectedMessage = db.Messages.Where(m => m.MessageId == Convert.ToInt32(row.Cells["MessageId"].Value.ToString())).FirstOrDefault();
                }
            }
        }

        private void DGVMessage_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(TbxSearch.Text != "")
            {
                SearchByTitle();
                if (CheckDGV() == false)
                {
                    SearchByContent();
                    if (CheckDGV() == false)
                    {
                        SearchByNameStudent();
                        if (CheckDGV() == false)
                        {
                            SearchByNameTeacher();
                        }
                    }
                }
                
            }
            else RefreshDGVMesage();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUse.GetChoiceMessage("Are you sure you want to delete this message?") == false) return;
                DeleteFromDatabase();
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }
    }
}
