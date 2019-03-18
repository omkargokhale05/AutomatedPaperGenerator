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
    public partial class Semester : Form
    {
        public Semester()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();
        public Login frm1 { get; set; }



        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from semster", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

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
                    SqlCommand kmt = new SqlCommand("INSERT INTO semster(semester) VALUES ('" + textBox1.Text + "') ", bag);
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    
                    textBox1.Clear();
                    listele();

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please choose semester!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE semster SET semester='" + textBox1.Text + "' WHERE id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
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
                MessageBox.Show("Please choose semester!");
            }
            else
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand("Delete from semster where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
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
                SqlDataAdapter adtr = new SqlDataAdapter("Select * from semster where semester like '%" + textBox3.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("Please enter Semester");
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Close();
        }

        private void Semester_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Semester Name";
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
