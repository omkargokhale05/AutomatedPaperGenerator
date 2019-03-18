using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class ForgetPassword : Form
    {

        public Login frm1;
        public ForgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);

        private void button1_Click(object sender, EventArgs e)
       
        {

            if (textBox1.Text == "" || textBox3.Text == "")
            {
                
                MessageBox.Show("Blank Field");

            }

            else
            {
            
            string name;
            string gizlisoru;
            string address;
            bag.Open();
            SqlCommand adi = new SqlCommand("Select name from personnel where name='" + textBox1.Text + "'", bag);
            SqlCommand gzlsoru = new SqlCommand("Select sq from personnel where name='" + textBox1.Text + "'", bag);
            SqlCommand cvp = new SqlCommand("Select answer from personnel where name='" + textBox1.Text + "'", bag);
            try
            {
                name = adi.ExecuteScalar().ToString();
                gizlisoru = gzlsoru.ExecuteScalar().ToString();
                address = cvp.ExecuteScalar().ToString();
                if (name == textBox1.Text && gizlisoru == comboBox1.Text && address == textBox3.Text)
                {
                    groupBox1.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Nothing Found");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing Found");
            }
            bag.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            textBox3.Clear();
            groupBox1.Visible = false;
            
            textBox5.Clear();
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("blank fields !!!");
            }
            else
            {

                bag.Open();
                SqlCommand sfr = new SqlCommand("update personnel set password='" + textBox5.Text + "' where name='" + textBox1.Text + "'", bag);
                sfr.ExecuteNonQuery();
                bag.Close();

                MessageBox.Show("Password Change Succesfully");
                textBox1.Clear();
               comboBox1.SelectedIndex = 0;
                textBox3.Clear();
                groupBox1.Visible = false;
                
                textBox5.Clear();
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }
    }
}
