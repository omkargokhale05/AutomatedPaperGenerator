using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data.SqlClient;


namespace Project
{
    public partial class Panel : Form
    {
        public Login frm1;
        public Panel()
        {
            InitializeComponent();
        }



        SqlConnection bag = new SqlConnection(@"Data Source=GUNEY\SQL_2014;Initial Catalog=Project;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel_Load(object sender, EventArgs e)
        {

          

            comboBox5.Items.Clear();
            bag.Open();
            SqlCommand cmm = new SqlCommand("Select semester from semster", bag);
            SqlDataReader drrr = cmm.ExecuteReader();

            while (drrr.Read())
            {
                comboBox5.Items.Add(drrr["semester"].ToString());
            }

            bag.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           






        }


        private void button3_Click(object sender, EventArgs e)
        {

        }
     
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dfdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

      
       
    }
}
