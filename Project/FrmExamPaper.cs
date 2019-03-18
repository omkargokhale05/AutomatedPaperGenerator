using Project.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class FrmExamPaper : Form
    {
        public FrmExamPaper()
        {
            InitializeComponent();
        }

       
        public Login frm1 { get; set; }




        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExamPaper_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbProcess.ExamPapers(this.frm1.PersonelId);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            byte[] b = (byte[])dataGridView1.SelectedRows[0].Cells[2].Value;
            if (File.Exists("exam.pdf"))
                File.Delete("exam.pdf");
            File.WriteAllBytes(@"exam.pdf", b);
            System.Diagnostics.Process.Start(@"exam.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DbProcess.ExamPaperss(id);
            dataGridView1.DataSource = DbProcess.ExamPapers(this.frm1.PersonelId);
        }

      
    }
}
