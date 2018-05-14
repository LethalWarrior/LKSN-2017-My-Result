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
    public partial class FrInputScore : Form
    {
        public FrInputScore(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        Teacher teacher;
        Class kelas;
        Subject subject;
        Student student;
        DetailScore selecteddetail;

        private void GetComboboxList()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = from ds in db.DetailSchedules
                           join hs in db.HeaderSchedules
                           on ds.ScheduleId equals hs.ScheduleId
                           join s in db.Subjects
                           on ds.SubjectId equals s.SubjectId
                           where ds.TeacherId == teacher.TeacherId && hs.Finalize == 1
                           select new
                           {
                               s.SubjectId,
                               s.Name,
                               hs.ClassName,
                           };

                foreach (var l in List)
                {
                    string subject = string.Format("{0} - {1}", l.SubjectId, l.Name);
                    string kelas = l.ClassName;

                    CbxSubject.Items.Add(subject);
                    CbxClass.Items.Add(kelas);

                }
            }
        }

        public void RefreshDGV()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVStudents.DataSource = from dsc in db.DetailScores
                                         join ds in db.DetailSchedules
                                         on dsc.DetailId equals ds.DetailId
                                         join s in db.Students
                                         on dsc.StudentId equals s.StudentId
                                         join hs in db.HeaderSchedules
                                         on ds.ScheduleId equals hs.ScheduleId
                                         where ds.TeacherId == teacher.TeacherId && hs.ClassName == kelas.ClassName
                                         select new
                                         {
                                             s.StudentId,
                                             s.Name,
                                             dsc.Assignment,
                                             dsc.MidExam,
                                             dsc.FinalExam
                                         };
                                         
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ShowPercentage()
        {
            LblAssignment.Text = subject.Assignment + "%";
            LblAssignment.Visible = true;
            LblMid.Text = subject.MidExam + "%";
            LblMid.Visible = true;
            LblFinal.Text = subject.FinalExam + "%";
            LblFinal.Visible = true;

        }

        private void FrInputScore_Load(object sender, EventArgs e)
        {
            GetComboboxList();
            CbxClass.SelectedItem = CbxClass.Items[0];
            CbxSubject.SelectedItem = CbxSubject.Items[0];
            
        }

        private void CbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                string subject = GlobalUse.GetFirstString(CbxSubject.SelectedItem.ToString());
                this.subject = db.Subjects.Where(s => s.SubjectId == subject).FirstOrDefault();
                ShowPercentage();
            }
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                kelas = db.Classes.Where(c => c.ClassName == CbxClass.SelectedItem.ToString()).FirstOrDefault();
                RefreshDGV();
            }
        }

        private void DGVStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVStudents.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    student = db.Students.Where(s => s.StudentId == row.Cells["StudentId"].Value.ToString()).FirstOrDefault();
                    selecteddetail = db.DetailScores.Where(ds => ds.StudentId == student.StudentId).FirstOrDefault();
                }
            }
        }

        private void BtnEntry_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count > 0)
            {
                FrEntryScore entry = new FrEntryScore(this.student, this.selecteddetail, this);
                entry.Show();
            }
            else GlobalUse.GetErrorMessage("Please choose an entry!");
        }

        private void DGVStudents_Click(object sender, EventArgs e)
        {
            
        }
    }
}
