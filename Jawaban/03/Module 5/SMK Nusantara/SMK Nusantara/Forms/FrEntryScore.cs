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
    public partial class FrEntryScore : Form
    {
        public FrEntryScore(Student student, DetailScore score, FrInputScore inputscore)
        {
            InitializeComponent();
            this.student = student;
            this.score = score;
            this.inputscore = inputscore;
            va = new Validation(this.Controls, EVAlidation);
        }
        Validation va;

        Student student;
        DetailScore score;
        FrInputScore inputscore;

        ErrorProvider EVAlidation = new ErrorProvider();


        private void UpdateToDatabase()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                DetailScore detail = db.DetailScores.Where(ds => ds.ScoreDetailId == score.ScoreDetailId).FirstOrDefault();
                detail.Assignment = Convert.ToInt32(TbxAssignment.Text);
                detail.MidExam = Convert.ToInt32(TbxMidExam.Text);
                detail.FinalExam = Convert.ToInt32(TbxFinalExam.Text);
                db.SubmitChanges();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (va.ValidateEmpty() == false) return;
                UpdateToDatabase();
                inputscore.RefreshDGV();
                this.Close();
            }
            catch (Exception ex)
            {
                GlobalUse.GetErrorMessage("Error ! " + ex.Message);
            }
        }

        private void FrEntryScore_Load(object sender, EventArgs e)
        {
            LblStudent.Text = string.Format("{0} - {1}", student.StudentId, student.Name);
            TbxAssignment.Text = score.Assignment.ToString();
            TbxMidExam.Text = score.MidExam.ToString();
            TbxFinalExam.Text = score.FinalExam.ToString();
        }

        private void ValidateScore(TextBox tbx)
        {
            if(tbx.Text != "")
            {
                if (Convert.ToInt32(tbx.Text) > 100)
                {
                    EVAlidation.SetError(tbx, "The score must be 0 - 100!");
                }
                else EVAlidation.SetError(tbx, "");
            }
        }

        private void TbxAssignment_TextChanged(object sender, EventArgs e)
        {
            ValidateScore(TbxAssignment);
        }

        private void TbxMidExam_TextChanged(object sender, EventArgs e)
        {
            ValidateScore(TbxMidExam);
        }

        private void TbxFinalExam_TextChanged(object sender, EventArgs e)
        {
            ValidateScore(TbxFinalExam);
        }
    }
}
