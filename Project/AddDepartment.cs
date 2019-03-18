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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();
        public Login frm1 { get; set; }

         public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from departments", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }





        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Fill in the blank!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    bag.Open();
                    SqlCommand kmt = new SqlCommand("INSERT INTO departments(department) VALUES ('" + textBox1.Text + "') ", bag);
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                   
                    textBox1.Clear();
                    listele();

                }

            }
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE departments SET Department='" + textBox1.Text + "' WHERE DepID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    
                    listele();
                    textBox1.Clear();
                    textBox3.Clear();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please choose department");
            }
            else
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand("Delete from departments where DepID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    listele();
                    
                    textBox1.Clear();
                    
                    textBox3.Clear();
                    

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listele();
            textBox1.Clear();
            textBox3.Clear();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                tablo.Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("Select * from departments where department like '%" + textBox3.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("Please enter Department Name");
            } 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button8; 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
