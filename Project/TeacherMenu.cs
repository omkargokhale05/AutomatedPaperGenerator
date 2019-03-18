using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void PersonnelMenu_Load(object sender, EventArgs e)
        {
            label1.Text = Login.gondirilecekveri;
            timer1.Start();
        }

        public Login frm1 { get; set; }

        private void filleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label9.Text = dt.ToLongDateString();
            label10.Text = dt.ToLongTimeString();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.frep = new FrmReports();
            frm1.frep.frm1 = this.frm1;
            frm1.frep.ShowDialog();
            //FrmReports frm1 = new FrmReports();
            //frm1.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.addq.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.addq.ShowDialog();
        }

        private void createPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.frep.ShowDialog();
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            frm1.pchapters.ShowDialog();
        }

        private void btnExamPaper_Click(object sender, EventArgs e)
        {
            frm1.fexampaper.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.abou.ShowDialog();
        }

        private void chaptersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.pchapters.ShowDialog();
        }

        private void showExamPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.fexampaper.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\New folder\Project\Project\bin\Debug\HelpTeacher.docx");
        }
    }
}
