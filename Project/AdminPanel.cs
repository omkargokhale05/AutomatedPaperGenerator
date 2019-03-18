using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class AdminPanel : Form
    {
        public Login frm1;
        public AdminPanel()
        {
            InitializeComponent();
        }
        bool dragging;
        Point offset;
        
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();
        DataTable tablo1 = new DataTable();

        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from personnel", bag);
            adtr.Fill(tablo);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            label1.Text = Login.gondirilecekveri;
        }

        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label9.Text = dt.ToLongDateString();
            label10.Text = dt.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.newupdper.ShowDialog();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.adddep.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm1.addcourse.ShowDialog();
        }

        private void managerTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.newupdper.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.adddep.ShowDialog();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.addcourse.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frm1.smester.ShowDialog();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.smester.ShowDialog();
        }

        private void btnPersonelsCourses_Click(object sender, EventArgs e)
        {
            frm1.pcourses.ShowDialog();
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            frm1.pchapters.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.abou.ShowDialog();
        }

        private void addCoursesTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.pcourses.ShowDialog();
        }

        private void chaptersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.pchapters.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\New folder\Project\Project\bin\Debug\Helpadmin.docx");
        }
    }
}
