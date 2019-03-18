using Project.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmPersonelsCourses : Form
    {
        public Login frm1;
        public FrmPersonelsCourses()
        {
            InitializeComponent();

            foreach (DataRow r in DbProcess.GetSemesters().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["id"].ToString(), Text = r["semester"].ToString() };
                cbSemester.Items.Add(c);
            }

            foreach (DataRow r in DbProcess.GetPersonelsWithFullName().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["id"].ToString(), Text = r["FullName"].ToString() };
                cbPersonels.Items.Add(c);
            }

            foreach (DataRow r in DbProcess.GetDepartments().Rows)
            {
                ComboboxItem c = new ComboboxItem { Value = r["DepID"].ToString(), Text = r["Department"].ToString() };
                cbDepartments.Items.Add(c);
            }
            RefreshGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            
           
            this.Close();
        }

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

        private void RefreshGrid()
        {
            int pId = 0;
            try
            {
                pId = int.Parse((cbPersonels.SelectedItem as ComboboxItem).Value.ToString());
            }
            catch (Exception) { }
            dataGridView1.DataSource = DbProcess.PersonelsCoursesList(pId);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (cbSemester.Text == "" || cbPersonels.Text == "" || cbDepartments.Text == "" || cbCourses.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {
                
               

                    int semesterId = int.Parse((cbSemester.SelectedItem as ComboboxItem).Value.ToString());
                    int personelId = int.Parse((cbPersonels.SelectedItem as ComboboxItem).Value.ToString());
                    int courseId = int.Parse((cbCourses.SelectedItem as ComboboxItem).Value.ToString());
                    DbProcess.PersonelCoursesInsert(semesterId, personelId, courseId);
                    RefreshGrid();

                

            }

        }

        private void cbPersonels_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (cbSemester.Text == "" || cbPersonels.Text == "")
            {
                MessageBox.Show("Please choose course!");
            }
            else
            {


                if (dataGridView1.SelectedRows.Count == 0)
                    return;
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DbProcess.PersonelCoursesDelete(id);
                RefreshGrid();



            }


            
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (cbSemester.Text == "" || cbPersonels.Text == "" || cbDepartments.Text == "" || cbCourses.Text == "")
            {
                MessageBox.Show("Please choose Course than Fill in the blanks!");
            }
            else
            {



                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int semesterId = int.Parse((cbSemester.SelectedItem as ComboboxItem).Value.ToString());
                int courseId = int.Parse((cbCourses.SelectedItem as ComboboxItem).Value.ToString());
                DbProcess.PersonelCoursesUpdate(id, semesterId, courseId);
                RefreshGrid();



            }
                     
            
           
        }

    }
}
