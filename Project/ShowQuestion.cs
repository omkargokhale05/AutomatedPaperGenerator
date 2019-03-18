using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DbSetTableAdapters;

namespace Project
{
    public partial class ShowQuestion : Form
    {
        private List<int> correctAnswerList = null;
        private DbSet.ShowClassicQuestionsDataTable dtQuestionClassic = null;
        private DbSet.ShowMCQuestionsDataTable dtQuestionsMC = null;
        private int currentQuestions = 0;
        public ShowQuestion()
        {
            InitializeComponent();
            tcSorular.Appearance = TabAppearance.FlatButtons;
            tcSorular.ItemSize = new Size(0, 1);
            tcSorular.SizeMode = TabSizeMode.Fixed;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowQuestion_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            DbSet.DepartmentDataTable dataDepartmanlar = new DbSet.DepartmentDataTable();
            new DepartmentTableAdapter().Fill(dataDepartmanlar);
            foreach (DataRow r in dataDepartmanlar.Rows)
            {
                ComboboxItem item = new ComboboxItem
                {
                    Text = r["Name"].ToString(),
                    Value = r["Id"]
                };
                cbDepartmanlar.Items.Add(item);
            }
        }

        private void cbDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.Items.Clear();
            DbSet.CourseDataTable cTable = new DbSet.CourseDataTable();
            ComboboxItem cItem = (ComboboxItem)cbDepartmanlar.SelectedItem;
            new CourseTableAdapter().FillByDepartmanId(cTable, int.Parse(cItem.Value.ToString()));
            foreach (DataRow r in cTable.Rows)
            {
                ComboboxItem item = new ComboboxItem
                {
                    Text = r["Name"].ToString(),
                    Value = r["Id"]
                };
                cbCourse.Items.Add(item);
            }
            cbCourse.SelectedIndex = 0;
        }

        private void cbQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tcSorular.SelectedTab = tbStart;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            correctAnswerList = new List<int>();
            pnlSol.Enabled = false;
            pnlBottom.Visible = true;
            pnlQuestion.Visible = true;
            tcSorular.SelectedIndex = cbQuestionType.SelectedIndex;
            if (cbQuestionType.Text == "Classic")
            {
                panel3.Visible = true;
                panel2.Visible = false;
                panel4.Visible = false;
                dtQuestionClassic = new DbSet.ShowClassicQuestionsDataTable();
                int courseId = int.Parse(((ComboboxItem)cbCourse.SelectedItem).Value.ToString());
                new ShowClassicQuestionsTableAdapter().Fill(dtQuestionClassic, courseId);

            }
            if (cbQuestionType.Text == "T/F")
            {
                panel3.Visible = false;
                panel2.Visible = true;
                panel4.Visible = false;
            }

            if (cbQuestionType.Text == "Multiple choice")
            {
                panel3.Visible = false;
                panel2.Visible = false;
                panel4.Visible = true;
            }
            PrepareQuestion();
        }

        void PrepareQuestion()
        {
            txtClassicAnswer.Clear();
            switch (cbQuestionType.SelectedIndex)
            {
                case 0:
                    txtQuestion.Text = dtQuestionClassic[currentQuestions].Name;
                    break;
                case 1: break;
                case 2: break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (cbQuestionType.SelectedIndex)
            {
                case 0:
                    if (!dtQuestionClassic[currentQuestions].IsAnswerNull() && txtClassicAnswer.Text.ToLower() == dtQuestionClassic[currentQuestions].Answer.ToLower())
                        correctAnswerList.Add(currentQuestions + 1);
                    break;
                case 1: break;
                case 2: break;
            }
            if (currentQuestions == dtQuestionClassic.Count - 1)
            {
                btnNext.Visible = false;
                btnOk.Visible = true;
                return;
            }
            currentQuestions++;
            PrepareQuestion();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tcSorular.SelectedTab = tbSummary;
            pnlQuestion.Visible = false;
            foreach (int i in correctAnswerList)
            {
                if (lblCorrectAnswers.Text.Count() != 0)
                    lblCorrectAnswers.Text += " , ";
                lblCorrectAnswers.Text += i.ToString();
            }
        }
    }
}

