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
    public partial class FrManageClass : Form
    {
        public FrManageClass()
        {
            InitializeComponent();

        }

        Class kelas;
        Student selectedstudent;
        Student selectedparticipate;

        private void GetClass()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Classes.Select(s => s.ClassName);

                foreach (var l in List)
                {
                    CbxClass.Items.Add(l);
                }
                CbxClass.SelectedItem = CbxClass.Items[0];                
            }
        }

        private void AddColumn()
        {
            DataGridViewColumn StudentId = new DataGridViewColumn() { HeaderText = "StudentId"};
            DataGridViewColumn Name = new DataGridViewColumn() { HeaderText = "Name" };
            DGVStudent.Columns.Add(StudentId);
            DGVStudent.Columns.Add(Name);
        }

        private void FrManageClass_Load(object sender, EventArgs e)
        {
            GetClass();
            RefreshDGVStudent();
        }

        private bool CheckStudent(Student student)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DetailClass detailclass = db.DetailClasses.Where(dc => dc.StudentId == student.StudentId)
                    .FirstOrDefault();
                if (detailclass != null) return true;
                return false;
            }
        }

        private void RefreshDGVParticipate()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVParticipate.DataSource = from dc in db.DetailClasses
                                            join c in db.Classes
                                            on dc.ClassName equals c.ClassName
                                            join s in db.Students
                                            on dc.StudentId equals s.StudentId
                                            where c.ClassName == kelas.ClassName
                                            select new
                                            {
                                                s.StudentId,
                                                s.Name
                                            };
            }
        }

        private List<Student> GetStudentList()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                return db.Students.ToList();
            }
        }

        private void RefreshDGVStudent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                List<Student> list = GetStudentList();
                foreach (Student s in list)
                {
                    if (CheckStudent(s) == false)
                    {
                        DGVStudent.Rows.Add(s.StudentId, s.Name);
                    }
                }
            }
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    kelas = db.Classes.Where(c => c.ClassName == CbxClass.SelectedItem.ToString())
                        .FirstOrDefault();
                    RefreshDGVParticipate();
                }
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }

        private void DGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVStudent.Rows[e.RowIndex];
                using(SampleDataContext db = new SampleDataContext())
                {
                    selectedstudent = db.Students.Where(s => s.StudentId == row.Cells["StudentID"].Value.ToString())
                        .FirstOrDefault();
                }
            }
        }

        private void BtnInclude_Click(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if (DGVStudent.SelectedRows.Count > 0)
                {
                    DetailClass detail = db.DetailClasses.Where(dc => dc.StudentId == selectedstudent.StudentId)
                        .FirstOrDefault();
                    if(detail == null)
                    {
                        db.DetailClasses.InsertOnSubmit(new DetailClass { ClassName = CbxClass.SelectedItem.ToString(), StudentId = selectedstudent.StudentId });
                        db.SubmitChanges();
                        RefreshDGVStudent();
                        RefreshDGVParticipate();
                        
                    }
                    else if(detail != null)
                    {
                        db.DetailClasses.DeleteOnSubmit(detail);
                        db.DetailClasses.InsertOnSubmit(new DetailClass { ClassName = CbxClass.SelectedItem.ToString(), StudentId = selectedstudent.StudentId });
                        db.SubmitChanges();
                        RefreshDGVStudent();
                        RefreshDGVParticipate();
                        
                    }
                }
            }
        }

        private void DGVParticipate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVParticipate.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    selectedparticipate = db.Students.Where(s => s.StudentId == row.Cells["StudentId"].Value.ToString())
                        .FirstOrDefault();
                }
            }
        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if (DGVParticipate.SelectedRows.Count > 0)
                {
                    DetailClass detail = db.DetailClasses.Where(dc => dc.StudentId == selectedparticipate.StudentId)
                        .FirstOrDefault();
                    
                        db.DetailClasses.DeleteOnSubmit(detail);
                        db.SubmitChanges();
                        RefreshDGVParticipate();
                        RefreshDGVStudent();
                }
            }
        }
    }
}
