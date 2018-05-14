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
    public partial class FrTeachingSchedule : Form
    {
        public FrTeachingSchedule(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        Teacher teacher;
        Class kelas;

        private void RefreshDGVSchedule()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVSchedule.DataSource = from ds in db.DetailSchedules
                                         join hs in db.HeaderSchedules
                                         on ds.ScheduleId equals hs.ScheduleId
                                         join s in db.Subjects
                                         on ds.SubjectId equals s.SubjectId
                                         join sh in db.Shifts
                                         on ds.ShiftId equals sh.ShiftId
                                         join t in db.Teachers
                                         on ds.TeacherId equals t.TeacherId
                                         where t.TeacherId == teacher.TeacherId && hs.Finalize == 1
                                         select new
                                         {
                                             s.SubjectId,
                                             Subject = s.Name,
                                             hs.ClassName,
                                             ds.Day,
                                             sh.Time
                                         };
            }
        }

        private void RefreshDGVStudent()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DGVStudent.DataSource = from dc in db.DetailClasses
                                        join c in db.Classes
                                        on dc.ClassName equals c.ClassName
                                        join s in db.Students
                                        on dc.StudentId equals s.StudentId
                                        where c.ClassName == kelas.ClassName
                                        select new
                                        {
                                            s.StudentId,
                                            s.Name,
                                            s.Gender
                                        };
            }
                                        
        }

        private void FrTeachingSchedule_Load(object sender, EventArgs e)
        {
            RefreshDGVSchedule();
        }

        private void DGVSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVSchedule.Rows[e.RowIndex];
                    kelas = db.Classes.Where(c => c.ClassName == row.Cells["ClassName"].Value.ToString())
                        .FirstOrDefault();
                    RefreshDGVStudent();
                }
            }
        }
    }
}
