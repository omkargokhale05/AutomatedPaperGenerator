using FastReport;
using FastReport.Data;
using Project.DAL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmReports : Form
    {
        public Login frm1 { get; set; }

        public FrmReports()
        {
            InitializeComponent();
        }

        public void PrepairForm()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            btnPrepare.Enabled = false;
            btnAlternative.Enabled = false;
            btnStore.Enabled = false;
            btnReport.Enabled = false;
            cbAcedemicYear.Items.Clear();
            foreach (DataRow r in DbProcess.GetSemesters().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["id"].ToString(), Text = r["semester"].ToString() };
                cbAcedemicYear.Items.Add(c);
            }
            foreach (DataRow r in DbProcess.GetDepartments().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["DepID"].ToString(), Text = r["Department"].ToString() };
                cbDept.Items.Add(c);
            }

            DataGridViewImageColumn dim = new DataGridViewImageColumn();
            dim.Image = Properties.Resources.deles;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            if (cbCourse.Text == "" || dataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("blank fields !!!");
                return;
            }
            DataTable dt = DbProcess.GetQuestion2(frm1.PersonelId, dataGridView2.DataSource as DataTable);
            if (dataGridView1.DataSource == null)
                dataGridView1.DataSource = dt;
            else
                foreach (DataRow r in dt.Rows)
                {
                    (dataGridView1.DataSource as DataTable).Rows.Add(r.ItemArray);
                }
            numaralandir();

        }

        private void btnAlternative_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            if (cbCourse.Text == "")
            {
                MessageBox.Show("blank fields !!!");
                return;
            }
            DataTable dt = DbProcess.GetQuestion(frm1.PersonelId, int.Parse(((ComboboxItem)cbCourse.SelectedItem).Value.ToString()), int.Parse(txtrnd.Value.ToString()));
            if (dataGridView1.DataSource == null)
                dataGridView1.DataSource = dt;
            else
                foreach (DataRow r in dt.Rows)
                {
                    (dataGridView1.DataSource as DataTable).Rows.Add(r.ItemArray);
                }
            numaralandir();
        }

       
        
        
        private void btnReport_Click(object sender, EventArgs e)
        {

            btnStore.Enabled = true;
            if (cbCourse.Text == "")
            {
                MessageBox.Show("blank fields !!!");
            }
            else
            {
                DataBand d1 = null;
                DataBand d2 = null;
                DataSourceBase parentDs = null;
                DataSourceBase childDs = null;
                DataSourceBase customersTable = null;
                DataSourceBase ordersTable = null;
                Relation rel = null;
                report.Dictionary.Clear();

                DataTable dt = dataGridView1.DataSource as DataTable;

                DataView view = new DataView(dt);
                view.RowFilter = "Ch = 1";


                dt = view.ToTable();


                report.RegisterData(dt, "ShowQuestions");
                report.RegisterData(DbProcess.ShowAnswer(), "ShowAnswer");
                report.SetParameterValue("mypara", textBox1.Text);
                //report.SetParameterValue("depar", cbDepartmanlar.Text);
                report.SetParameterValue("course", cbCourse.Text);
                report.SetParameterValue("smester", cbAcedemicYear.Text);
                report.SetParameterValue("exam", comboBox4.Text);
                parentDs = report.GetDataSource("ShowQuestions");
                childDs = report.GetDataSource("ShowAnswer");
                parentDs.Enabled = true;
                childDs.Enabled = true;
                customersTable = report.Dictionary.DataSources.FindByAlias("ShowQuestions");
                ordersTable = report.Dictionary.DataSources.FindByAlias("ShowAnswer");
                rel = new Relation();
                rel.Name = "customersOrders";
                rel.ParentDataSource = customersTable;
                rel.ChildDataSource = ordersTable;
                rel.ParentColumns = new string[] { "Id" };
                rel.ChildColumns = new string[] { "QuestionId" };
                report.Dictionary.Relations.Add(rel);
                report.Dictionary.UpdateRelations();
                d1 = report.FindObject("Data1") as DataBand;
                d1.DataSource = parentDs;
                d2 = report.FindObject("Data2") as DataBand;
                d2.DataSource = childDs;
                report.Show();

                
                
            }
        }

        private void numaralandir()
        {
            if (dataGridView1 != null)
            {
                for (int count = 0; (count <= (dataGridView1.Rows.Count - 1)); count++)
                {
                    dataGridView1.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
            if (cbCourse.Items.Count > 0)
                cbCourse.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnPrepare.Enabled = true;
            if (cbCourse.Text == "" || cbChapter.Text == "" || cbQuestionType.Text == "")
            {
                MessageBox.Show("blank fields !!!");
            }
            else
            {
                DataTable dt = null;
                if (dataGridView2.DataSource == null)
                {
                    dt = new DataTable("Dt");
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Type", typeof(int));
                    dt.Columns.Add("CourseId", typeof(int));
                    dt.Columns.Add("ChapterId", typeof(int));
                    dt.Columns.Add("QuestionsCount", typeof(int));
                    dt.Columns.Add("Course", typeof(string));
                    dt.Columns.Add("Chapter", typeof(string));
                    dt.Columns.Add("QuestionsType", typeof(string));
                    dt.Columns[0].AutoIncrement = true;
                    dataGridView2.DataSource = dt;
                }
                dt = dataGridView2.DataSource as DataTable;
                dt.Rows.Add(1, cbQuestionType.SelectedIndex + 1, int.Parse(((ComboboxItem)cbCourse.SelectedItem).Value.ToString()), int.Parse(((ComboboxItem)cbChapter.SelectedItem).Value.ToString()), int.Parse(txtrnd.Value.ToString()),
               cbCourse.Text, cbChapter.Text, cbQuestionType.Text);
            }
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
            

            //DataTable dt = dataGridView2.DataSource as DataTable;
            //if (dt == null) return;
            //dt.Clear();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            FastReport.Export.Pdf.PDFExport pdfExport = new FastReport.Export.Pdf.PDFExport();
            pdfExport.ShowProgress = true;
            pdfExport.Subject = "Subject";
            pdfExport.Title = "Exam";
            pdfExport.Compressed = true;
            pdfExport.AllowPrint = true;
            pdfExport.EmbeddingFonts = true;
            MemoryStream strm = new MemoryStream();
            report.Prepare();
            report.Export(pdfExport, strm);
            byte[] b = strm.ToArray();
            string title = Microsoft.VisualBasic.Interaction.InputBox("Exam Paper Title", "Save Exam Paper", (cbAcedemicYear.Text) + (cbCourse.Text)+(comboBox4.Text));
            DbProcess.ExamPapersInsert(frm1.PersonelId, title, b);
            MessageBox.Show("Done.");
            
            
            
        }

        private void txtrnd_Click(object sender, EventArgs e)
        {
            btnAlternative.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            cbAcedemicYear.DataSource = null;
            cbCourse.DataSource = null;
            cbQuestionType.SelectedIndex = -1;
            cbChapter.SelectedIndex = -1;
            //cbAcedemicYear.SelectedIndex = -1;
            
            DataTable dt = dataGridView2.DataSource as DataTable;
            if (dt == null) return;
            dt.Clear();
           
            DataTable dtd = dataGridView1.DataSource as DataTable;
            if (dtd == null) return;
            dtd.Clear();

            textBox1.Clear();
            comboBox4.SelectedIndex = -1;
            txtrnd.Value = 1;
            btnPrepare.Enabled = false;
            btnAlternative.Enabled = false;
            btnStore.Enabled = false;
            btnReport.Enabled = false;
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView2.DataSource as DataTable;
            if (dt == null) return;
            dt.Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
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
        }
    }
}
