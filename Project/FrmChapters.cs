using Project.DAL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class FrmChapters : Form
    {
        public Login frm1;
        public FrmChapters()
        {
            InitializeComponent();
            foreach (DataRow r in DbProcess.GetDepartments().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["DepID"].ToString(), Text = r["Department"].ToString() };
                cbDepartments.Items.Add(c);
            }


        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourses.Items.Clear();
            int deptId = int.Parse((cbDepartments.SelectedItem as ComboboxItem).Value.ToString());
            foreach (DataRow r in DbProcess.GetCoursesWithDeptId(deptId).Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["courseid"].ToString(), Text = r["course"].ToString() };
                cbCourses.Items.Add(c);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            cbDepartments.Text = "Select...";
            cbCourses.Text = "Select...";
            txtChapterNo.Value = 0;
            txtChapter.Text = "";
            

            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;
            dt.Clear();
            

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int cId = int.Parse((cbCourses.SelectedItem as ComboboxItem).Value.ToString());
            DbProcess.ChapterInsert(cId, int.Parse(txtChapterNo.Value.ToString()), txtChapter.Text);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            int cId = 0;
            try
            {
                cId = int.Parse((cbCourses.SelectedItem as ComboboxItem).Value.ToString());
            }
            catch (Exception) { }
            dataGridView1.DataSource = DbProcess.ChapterList(cId);
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DbProcess.ChapterDelete(id);
            RefreshGrid();
        }

        private void FrmChapters_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            
            
        }

        private void txtChapter_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbDepartments.Text == "" || cbCourses.Text == "")
            {
                MessageBox.Show("Please choose Teacher than Fill in the blanks!");
            }
            else
            {
                
                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE Chapters SET ChapterNo='" + txtChapterNo.Text + "',ChapterName='" + txtChapter.Text +  "' WHERE Id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    RefreshGrid();
                  
                }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChapterNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtChapter.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void cbDepartments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbCourses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
