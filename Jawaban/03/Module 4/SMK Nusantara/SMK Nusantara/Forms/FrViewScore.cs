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
    public partial class FrViewScore : Form
    {
        public FrViewScore(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        Student student;
        Subject subject;

        private void RefreshDGV()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVStudents.DataSource = from dsc in db.DetailScores
                                         join ds in db.DetailSchedules
                                         on dsc.DetailId equals ds.DetailId
                                         join s in db.Subjects
                                         on ds.SubjectId equals s.SubjectId
                                         join st in db.Students
                                         on dsc.StudentId equals st.StudentId
                                         where st.StudentId == this.student.StudentId
                                         select new
                                         {
                                             s.SubjectId,
                                             Subject = s.Name,
                                             dsc.Assignment,
                                             dsc.MidExam,
                                             dsc.FinalExam
                                         };
                //foreach (DataGridViewRow row in DGVStudents.Rows)
                //{
                //    int assignment = Convert.ToInt32(row.Cells["Assignment"].Value.ToString());
                //    int mid = Convert.ToInt32(row.Cells["MidExam"].Value.ToString());
                //    int final = Convert.ToInt32(row.Cells["FinalExam"].Value.ToString());

                //    int? finalscore = ((assignment * subject.Assignment) / 100) + ((mid * subject.MidExam) / 100) + ((final * subject.FinalExam) / 100);
                //    row.Cells["Final"].Value = finalscore;
                //}
            }
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

        private void FrViewScore_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void DGVStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVStudents.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    subject = db.Subjects.Where(s => s.SubjectId == row.Cells["SubjectId"].Value.ToString()).FirstOrDefault();
                    ShowPercentage();
                }
            }
        }
    }
}
