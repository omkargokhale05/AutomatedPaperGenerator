using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Project.DAL;

namespace Project
{
    public partial class AddQusetion : Form
    {
        public Login frm1;
        public AddQusetion()
        {
            InitializeComponent();
            tcSorular.Appearance = TabAppearance.FlatButtons;
            tcSorular.ItemSize = new Size(0, 1);
            tcSorular.SizeMode = TabSizeMode.Fixed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cbChapter.Text = "Select..";
            cbCourse.Text = "Select..";
            cbQuestionType.Text = "Select..";
            txtClassicAnswer.Clear();
            txtQuestion.Clear();
            txtMultiA.Clear();
            txtMultiC.Clear();
            txtMultiB.Clear();
            txtMultiD.Clear();
            this.Close();
        }

        private void AddQusetion_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            cbAcedemicYear.Items.Clear();
            foreach (DataRow r in DbProcess.GetSemesters().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["id"].ToString(), Text = r["semester"].ToString() };
                cbAcedemicYear.Items.Add(c);
            }
            cbAcedemicYear.SelectedIndex = 0;
            foreach (DataRow r in DbProcess.GetDepartments().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["DepID"].ToString(), Text = r["Department"].ToString() };
                cbDept.Items.Add(c);
            }
        }

        //private void RefreshGrid()
        //{
        //    int cId = 0;
        //    int chId = 0;
        //    int typeId = 0;
        //    try
        //    {
        //        cId = int.Parse((cbCourse.SelectedItem as ComboboxItem).Value.ToString());
        //        chId = int.Parse((cbChapter.SelectedItem as ComboboxItem).Value.ToString());
        //        typeId = int.Parse((cbQuestionType.SelectedItem as ComboboxItem).Value.ToString());
        //    }
        //    catch (Exception) { }
        //    DGQuestions.DataSource = DbProcess.GetQuestion3(frm1.PersonelId, cId,chId,typeId);
        //}
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlQuestion.Visible = true;
            tcSorular.SelectedIndex = cbQuestionType.SelectedIndex;
            if (cbQuestionType.Text == "Classic")
            {
                txtQuestion.Text = "";
                panel3.Visible = true;
                panel2.Visible = false;
                panel4.Visible = false;


            }
            if (cbQuestionType.Text == "T/F")
            {
                txtQuestion.Text = "";
                panel3.Visible = false;
                panel2.Visible = true;
                panel4.Visible = false;
            }

            if (cbQuestionType.Text == "Multiple choice")
            {

                txtQuestion.Text = "";
                panel3.Visible = false;
                panel2.Visible = false;
                panel4.Visible = true;
            }
          //  RefreshGrid();
        }

        private void btnMultiInsert_Click(object sender, EventArgs e)
        {


            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    int courseId = int.Parse(((ComboboxItem)cbChapter.SelectedItem).Value.ToString());
                    int id = DbProcess.QuestionsInsert(courseId, cbQuestionType.SelectedIndex + 1, txtQuestion.Text);
                    switch ((sender as Button).Tag.ToString())
                    {
                        case "1":
                            DbProcess.AnswerInser(id, txtClassicAnswer.Text, false);
                            break;
                        case "2":
                            DbProcess.AnswerInser(id, txtMultiA.Text, cbMultiA.Checked);
                            DbProcess.AnswerInser(id, txtMultiB.Text, cbMultiB.Checked);
                            DbProcess.AnswerInser(id, txtMultiC.Text, cbMultiC.Checked);
                            DbProcess.AnswerInser(id, txtMultiD.Text, cbMultiD.Checked);
                            break;
                        case "3":
                            DbProcess.AnswerInser(id, rdTrue.Checked.ToString(), rdTrue.Checked);
                            break;
                    }
                    
                    txtQuestion.Clear(); txtClassicAnswer.Clear();
                    txtMultiA.Text = "a)"; txtMultiB.Text = "b)"; txtMultiC.Text = "c)"; txtMultiD.Text = "d)";

                }
              //  RefreshGrid();
            }


            
            
            
            //int courseId = int.Parse(((ComboboxItem)cbChapter.SelectedItem).Value.ToString());
            //int id = DbProcess.QuestionsInsert(courseId, cbQuestionType.SelectedIndex + 1, txtQuestion.Text);
            //switch ((sender as Button).Tag.ToString())
            //{
            //    case "1":
            //        DbProcess.AnswerInser(id, txtClassicAnswer.Text, false);
            //        break;
            //    case "2":
            //        DbProcess.AnswerInser(id, txtMultiA.Text, cbMultiA.Checked);
            //        DbProcess.AnswerInser(id, txtMultiB.Text, cbMultiB.Checked);
            //        DbProcess.AnswerInser(id, txtMultiC.Text, cbMultiC.Checked);
            //        DbProcess.AnswerInser(id, txtMultiD.Text, cbMultiD.Checked);
            //        break;
            //    case "3":
            //        DbProcess.AnswerInser(id, rdTrue.Checked.ToString(), rdTrue.Checked);
            //        break;
            //}
            //MessageBox.Show("Ok");
            //txtQuestion.Clear(); txtClassicAnswer.Clear();
            //txtMultiA.Text = "a)"; txtMultiB.Text = "b)"; txtMultiC.Text = "c)"; txtMultiD.Text = "d)";
        }

        private void cbAcedemicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.Items.Clear();
            int sItem = int.Parse(((ComboboxItem)cbAcedemicYear.SelectedItem).Value.ToString());
            foreach (DataRow r in DbProcess.PersonelCourseList1(frm1.PersonelId, sItem).Rows)
            {
                ComboboxItem item = new ComboboxItem
                {
                    Text = r["course"].ToString(),
                    Value = r["CourseId"].ToString()
                };
                cbCourse.Items.Add(item);
            }
            if (cbCourse.SelectedIndex != -1)
                cbCourse.SelectedIndex = 0;
           
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChapter.Items.Clear();
            int cItem = int.Parse(((ComboboxItem)cbCourse.SelectedItem).Value.ToString());
            foreach (DataRow r in DbProcess.ChapterList(cItem).Rows)
            {
                ComboboxItem c = new ComboboxItem
                {
                    Text = r["ChapterName"].ToString(),
                    Value = r["Id"].ToString()
                };
                cbChapter.Items.Add(c);
            }
         //   RefreshGrid();
        }

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.Items.Clear();
            int deptId = int.Parse((cbDept.SelectedItem as ComboboxItem).Value.ToString());
            foreach (DataRow r in DbProcess.GetCoursesWithDeptId(deptId).Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["courseid"].ToString(), Text = r["course"].ToString() };
                cbCourse.Items.Add(c);
            }
         //   RefreshGrid();
        }

        private void DGQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
