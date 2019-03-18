using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Login : Form
    {
        public int PersonelId { get; set; }

        public AddCourse addcourse;
        public AddDepartment adddep;
        public AddQusetion addq;
        public AddTeacher newupdper;
        public AdminPanel newadm;
        public about abou;


        
        public Panel newpanel;
        public ForgetPassword fpass;
        public FrmReports frep;
        public Semester smester;
        public TeacherMenu pmenu;
        public FrmPersonelsCourses pcourses;
        public FrmChapters pchapters;
        public FrmExamPaper fexampaper;

        public Login()
        {
            InitializeComponent();

            addcourse = new AddCourse();
            adddep = new AddDepartment();
            addq = new AddQusetion();
            newupdper = new AddTeacher();
            newadm = new AdminPanel();
            abou = new about();


            
            frep = new FrmReports();
            fpass = new ForgetPassword();
            smester = new Semester();
            pmenu = new TeacherMenu();
            pcourses = new FrmPersonelsCourses();
            pchapters = new FrmChapters();
            fexampaper = new FrmExamPaper();


            abou.frm1 = this;
            addcourse.frm1 = this;
            adddep.frm1 = this;
            addq.frm1 = this;

            newadm.frm1 = this;
            newupdper.frm1 = this;

            fpass.frm1 = this;
            frep.frm1 = this;
            smester.frm1 = this;
            pmenu.frm1 = this;
            pcourses.frm1 = this;
            pchapters.frm1 = this;
            fexampaper.frm1 = this;
        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        OpenFileDialog ac = new OpenFileDialog();
        public static string gondirilecekveri;

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (ActiveForm != null) ActiveForm.AcceptButton = button1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT top 1 * FROM personnel WHERE name='" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", bag);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            //if (dt.Rows[0][0].ToString() == "1")
            {
                PersonelId = int.Parse(dt.Rows[0]["id"].ToString());
                gondirilecekveri = textBox1.Text;
                pmenu.ShowDialog();
                this.Hide();
            }
            else
            {
                label1.Text = "The user name or password is incorrect!";
            }
           
            
            SqlDataAdapter sdaa = new SqlDataAdapter("SELECT top 1 * FROM Admin WHERE UserName='" + textBox1.Text + "' AND Password ='" + textBox2.Text + "'", bag);
            DataTable dtt = new DataTable();
            sdaa.Fill(dtt);
            if (dtt.Rows.Count > 0)
            //if (dtt.Rows[0][0].ToString() == "1")
            {
                PersonelId = int.Parse(dtt.Rows[0]["id"].ToString());
                gondirilecekveri = textBox1.Text;
                newadm.ShowDialog();
                label1.Text = "";
               
                
            }
            else
            {
                label1.Text = "The user name or password is incorrect!";
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "Please enter your Username or Password!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = char.Parse("\0");
            }
            else
            {
                textBox2.PasswordChar = char.Parse("*");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fpass.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
