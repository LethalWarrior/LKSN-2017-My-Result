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
    public partial class FrViewSchedule : Form
    {
        public FrViewSchedule(Student student)
        {
            InitializeComponent();
            this.student = student;
            GetClass();
            
        }

        Student student;
        DetailClass detail;

        private void GetClass()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                detail = db.DetailClasses.Where(dc => dc.StudentId == student.StudentId).FirstOrDefault();

            }
        }
        
        private void RefreshDGV()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVSchedule.DataSource = from ds in db.DetailSchedules
                                         join s in db.Subjects
                                         on ds.SubjectId equals s.SubjectId
                                         join sh in db.Shifts
                                         on ds.ShiftId equals sh.ShiftId
                                         join t in db.Teachers
                                         on ds.TeacherId equals t.TeacherId
                                         join hs in db.HeaderSchedules
                                         on ds.ScheduleId equals hs.ScheduleId
                                         where hs.ClassName == detail.ClassName && ds.Day == CbxDay.SelectedItem.ToString()
                                         select new
                                         {
                                             s.SubjectId,
                                             Subject = s.Name,
                                             ds.Day,
                                             sh.Time,
                                             t.Name
                                         };
                                         
            }
        }

        private void FrViewSchedule_Load(object sender, EventArgs e)
        {
            LblClass.Text = detail.ClassName;
            CbxDay.SelectedItem = CbxDay.Items[0];
            RefreshDGV();
        }

        private void CbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDGV();
        }
    }
}
