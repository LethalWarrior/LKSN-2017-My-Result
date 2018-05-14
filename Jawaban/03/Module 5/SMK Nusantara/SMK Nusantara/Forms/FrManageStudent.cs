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
    public partial class FrManageStudent : Form
    {
        public FrManageStudent()
        {
            InitializeComponent();
            va = new Validation(this.Controls, EVAlidation);
        }

        Validation va;
        ErrorProvider EVAlidation = new ErrorProvider();

        Student student;

        private void StateBegin()
        {
            va.Clear();
            va.DisableAllControls();
            RefreshTable();
            BtnInsert.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Visible = false;
            BtnCancel.Visible = false;
            TbxSearch.Enabled = true;
            Datatable.Enabled = true;
        }

        private void StateInput()
        {
            va.EnableAllControls();
            BtnSave.Visible = true;
            BtnCancel.Visible = true;
            BtnInsert.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            TbxID.Enabled = false;
        }
        
        private void RefreshTable()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Datatable.DataSource = db.Students.Select(s => new
                {
                    s.StudentId,
                    s.Name,
                    s.Address,
                    s.Gender,
                    s.DateofBirth,
                    s.PhoneNumber
                });
            }
        }

        private void SearchByID()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Students
                    .Where(s => SqlMethods.Like(s.StudentId, "%" + TbxSearch.Text + "%"))
                    .Select(s => new
                     {
                         s.StudentId,
                         s.Name,
                         s.Address,
                         s.Gender,
                         s.DateofBirth,
                         s.PhoneNumber
                     });
                Datatable.DataSource = List;
            }
        }

        private void SearchByName()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Students
                    .Where(s => SqlMethods.Like(s.Name, "%" + TbxSearch.Text + "%"))
                .Select(s => new
                 {
                     s.StudentId,
                     s.Name,
                     s.Address,
                     s.Gender,
                     s.DateofBirth,
                     s.PhoneNumber
                 });
                Datatable.DataSource = List;
            }
        }

        private void SearchByAddress()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Students
                    .Where(s => SqlMethods.Like(s.Address, "%" + TbxSearch.Text + "%"))
                .Select(s => new
                 {
                     s.StudentId,
                     s.Name,
                     s.Address,
                     s.Gender,
                     s.DateofBirth,
                     s.PhoneNumber
                 });
                Datatable.DataSource = List;
            }
        }

        private void SearchByPhone()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var List = db.Students
                    .Where(s => SqlMethods.Like(s.PhoneNumber, "%" + TbxSearch.Text + "%"))
                .Select(s => new
                 {
                     s.StudentId,
                     s.Name,
                     s.Address,
                     s.Gender,
                     s.DateofBirth,
                     s.PhoneNumber
                 });
                Datatable.DataSource = List;
            }
        }

        private bool CheckDataTable()
        {
            if(Datatable.RowCount > 0)
            {
                return true;
            }
            return false;
        }

        private void InsertData()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                db.Students.InsertOnSubmit(new Student
                {
                    StudentId = TbxID.Text,
                    Name = TbxName.Text,
                    Address = TbxAddress.Text,
                    Gender = GetGender(),
                    DateofBirth = dtpBirth.Value.Date,
                    PhoneNumber = TbxPhone.Text
                });
                db.SubmitChanges();
                RefreshTable();
            }
        }

        private void UpdateData()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Student student = db.Students.Where(s => s.StudentId == this.student.StudentId)
                    .FirstOrDefault();
                student.Name = TbxName.Text;
                student.Address = TbxAddress.Text;
                student.Gender = GetGender();
                student.DateofBirth = dtpBirth.Value.Date;
                student.PhoneNumber = TbxPhone.Text;
                db.SubmitChanges();
            }
        }

        private string GetGender()
        {
            if (RBtnMale.Checked == true) return "Male";
            else return "Female";
        }

        private void GetEntry()
        {
            TbxID.Text = student.StudentId;
            TbxName.Text = student.Name;
            TbxAddress.Text = student.Address;
            if (student.Gender == "Male") RBtnMale.Checked = true;
            else if (student.Gender == "Female") RBtnFemale.Checked = true;
            dtpBirth.Value = student.DateofBirth.Value;
            TbxPhone.Text = student.PhoneNumber;
        }

        private void FrManageStudent_Load(object sender, EventArgs e)
        {
            StateBegin();
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TbxSearch.Text != "")
                {
                    SearchByID();
                    if (CheckDataTable() == false)
                    {
                        SearchByName();
                        if (CheckDataTable() == false)
                        {
                            SearchByAddress();
                            if (CheckDataTable() == false)
                            {
                                SearchByPhone();
                            }
                        }
                    }
                }
                else RefreshTable();
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error !" + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StateBegin();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(student == null)
                {
                    if (va.ValidateEmpty() == false) return;
                    if (va.ValidateAge(dtpBirth, 15, 21) == false) return;
                    if (va.ValidateName(TbxName) == false) return;
                    if (va.ValidatePhoneNumber(TbxPhone) == false) return;
                    if (RBtnMale.Checked == false && RBtnFemale.Checked == false) { GlobalUse.GetErrorMessage("Must choose a gender!"); return; }
                    if (GlobalUse.GetChoiceMessage("Are you sure with these data?") == false) return;
                    InsertData();
                    GlobalUse.GetInfoMessage("Successfully inserting entry!");
                    StateBegin();
                }
                else if(student != null)
                {
                    if (va.ValidateEmpty() == false) return;
                    if (va.ValidateAge(dtpBirth, 15, 21) == false) return;
                    if (va.ValidateName(TbxName) == false) return;
                    if (va.ValidatePhoneNumber(TbxPhone) == false) return;
                    if (RBtnMale.Checked == false && RBtnFemale.Checked == false) { GlobalUse.GetErrorMessage("Must choose a gender!"); return; }
                    if (GlobalUse.GetChoiceMessage("Are you sure with these data?") == false) return;
                    UpdateData();
                    GlobalUse.GetInfoMessage("Successfully updating entry!");
                    StateBegin();
                }
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error! " + ex.Message);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            va.Clear();
            StateInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Datatable.SelectedRows.Count > 0)
                StateInput();
            else GlobalUse.GetErrorMessage("Please select an entry to update!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Datatable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Datatable.Rows[e.RowIndex];
                using (SampleDataContext db = new SampleDataContext())
                {
                    student = db.Students.Where(s => s.StudentId == row.Cells["StudentId"].Value.ToString())
                        .FirstOrDefault();
                    GetEntry();
                }
            }
        }

        private void TbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
