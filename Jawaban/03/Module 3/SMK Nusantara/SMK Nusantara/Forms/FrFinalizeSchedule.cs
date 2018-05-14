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
    public partial class FrFinalizeSchedule : Form
    {
        public FrFinalizeSchedule()
        {
            InitializeComponent();
        }

        HeaderSchedule schedule;
        Class kelas;

        private void GetClass()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Classes.Select(s => s.ClassName);

                foreach (var l in List)
                {
                    CbxClass.Items.Add(l);
                }
            }
        }

        private void RefreshDGV()
        {
            if (CbxClass.SelectedItem != null)
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    if (schedule != null)
                    {
                        DGVSchedule.DataSource = from ds in db.DetailSchedules
                                                 join hs in db.HeaderSchedules
                                                 on ds.ScheduleId equals hs.ScheduleId
                                                 join s in db.Subjects
                                                 on ds.SubjectId equals s.SubjectId
                                                 join t in db.Teachers
                                                 on ds.TeacherId equals t.TeacherId
                                                 where (ds.ScheduleId == schedule.ScheduleId)
                                                 select new
                                                 {
                                                     s.SubjectId,
                                                     Subject = s.Name,
                                                     t.TeacherId,
                                                     Teacher_Name = t.Name,
                                                     ds.ShiftId,
                                                     ds.DetailId
                                                 };
                        DGVSchedule.Columns["DetailId"].Visible = false;
                    }
                }
            }
        }

        //private bool CheckShift()
        //{
        //    using (SampleDataContext db = new SampleDataContext())
        //    {
        //        var List = from ds in db.DetailSchedules
        //                   join hs in db.HeaderSchedules
        //                   on ds.ScheduleId equals hs.ScheduleId
        //                   join c in db.Classes
        //                   on hs.ClassName equals c.ClassName
        //                   select new {}
        //    }
        //}

        private void FrFinalizeSchedule_Load(object sender, EventArgs e)
        {
            GetClass();
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbxClass.SelectedItem != null)
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    schedule = db.HeaderSchedules.Where(s => s.ClassName == CbxClass.SelectedItem.ToString()).FirstOrDefault();
                    kelas = db.Classes.Where(c => c.ClassName == CbxClass.SelectedItem.ToString()).FirstOrDefault();
                }
               
                RefreshDGV();
                if (schedule.Finalize == 1) BtnFinalize.Enabled = false;
                else if (schedule.Finalize == 0) BtnFinalize.Enabled = true;
            }
        }

        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                HeaderSchedule schedule = db.HeaderSchedules.Where(hs => hs.ScheduleId == this.schedule.ScheduleId).FirstOrDefault();
                if(GlobalUse.GetChoiceMessage("Are you sure you want to finalize?") == true)
                {
                    schedule.Finalize = 1;
                    db.SubmitChanges();
                    if (schedule.Finalize == 1) BtnFinalize.Enabled = false;
                    else if (schedule.Finalize == 0) BtnFinalize.Enabled = true;
                }
            }
        }
    }
}
