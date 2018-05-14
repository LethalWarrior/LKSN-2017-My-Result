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
    public partial class FrManageSchedule : Form
    {
        public FrManageSchedule()
        {
            InitializeComponent();
            va = new Validation(this.Controls, EVAlidation);
        }

        HeaderSchedule schedule;
        Class kelas;
        Validation va;
        ErrorProvider EVAlidation = new ErrorProvider();
        DetailSchedule ds;

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

        private void GetSubject()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Subjects.Where(s => s.ForGrade == kelas.Grade).ToList();
                foreach (var l in List)
                {
                    CbxSubject.Items.Add(string.Format("{0} - {1}", l.SubjectId, l.Name));
                }
            }
        }

        private void CheckShift(Shift shift)
        {

        }

        private List<Shift> GetShiftList()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                return (from ds in db.DetailSchedules
                        join s in db.Shifts
                        on ds.ShiftId equals s.ShiftId
                        where ds.ShiftId == s.ShiftId
                        select s).ToList();
            }
        }

        private void RefreshDGV()
        {
            if (CbxClass.SelectedItem != null && CbxDay.SelectedItem != null)
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
                                                 where (ds.ScheduleId == schedule.ScheduleId && ds.Day == CbxDay.SelectedItem.ToString())
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

        private void StateBegin()
        {
            va.Clear();
            va.DisableAllControls();

            BtnInsert.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            CbxDay.Enabled = true;
            CbxClass.Enabled = true;
            DGVSchedule.Enabled = true;
            BtnSave.Visible = false;
            BtnCancel.Visible = false;

        }

        private void StateInput()
        {
            va.EnableAllControls();
            BtnSave.Visible = true;
            BtnCancel.Visible = true;
            BtnInsert.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }


        private void FrManageSchedule_Load(object sender, EventArgs e)
        {
            GetClass();
            StateBegin();
        }

        private void CbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RefreshDGV();
            
            
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxClass.SelectedItem != null)
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    schedule = db.HeaderSchedules.Where(s => s.ClassName == CbxClass.SelectedItem.ToString()).FirstOrDefault();
                    kelas = db.Classes.Where(c => c.ClassName == CbxClass.SelectedItem.ToString()).FirstOrDefault();
                    CbxSubject.Items.Clear();
                    GetSubject();
                }
                if (schedule.Finalize == 1)
                {
                    va.DisableAllControls();
                    CbxClass.Enabled = true;
                    CbxDay.Enabled = true;
                    DGVSchedule.Enabled = true;
                }
                else if (schedule.Finalize == 0)
                {
                    va.EnableAllControls();
                    BtnSave.Visible = false;
                    BtnCancel.Visible = false;
                    CbxShift.Enabled = false;
                    CbxTeacher.Enabled = false;
                    CbxSubject.Enabled = false;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StateBegin();
            DGVSchedule.DataSource = null;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            va.Clear();
            StateInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            StateInput();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalUse.GetChoiceMessage("Are you sure you want to delete this schedule?") == false) return;
            using (SampleDataContext db = new SampleDataContext())
            {
                DetailSchedule ds = db.DetailSchedules.Where(d => d.DetailId == this.ds.DetailId).FirstOrDefault();
                db.DetailSchedules.DeleteOnSubmit(ds);
                db.SubmitChanges();
            }
            RefreshDGV();
        }

        private void GetEntry()
        {
           
        }

        private void DGVSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVSchedule.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    ds = db.DetailSchedules.Where(d => d.DetailId == Convert.ToInt32(row.Cells["DetailId"].Value.ToString())).FirstOrDefault();
                }
            }
        }
    }
}
