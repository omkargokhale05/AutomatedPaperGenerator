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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();


        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from COURSES", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        public Login frm1 { get; set; }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "Select...";
            this.Close();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

            listele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].HeaderText = "Course Name";
            dataGridView1.Columns[3].HeaderText = "Description";
            DataGridViewColumn columns = dataGridView1.Columns[3];
            columns.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;





            comboBox1.Items.Clear();
            bag.Open();
            SqlCommand cmd = bag.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select DepID,Department from DEPARTMENTS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ComboboxItem c = new ComboboxItem
                {
                    Value = dr["DepID"].ToString(),
                    Text = dr["Department"].ToString()
                };
                comboBox1.Items.Add(c);
            }

            bag.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "Select...";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                tablo.Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("Select * from COURSES where course like '%" + textBox3.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("Please enter COURSES Name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    ComboboxItem c = comboBox1.SelectedItem as ComboboxItem;

                    bag.Open();
                    SqlCommand kmt = new SqlCommand("INSERT INTO COURSES(DepartmentId,course,description) VALUES (" + c.Value + ",'" + textBox1.Text + "','" + textBox2.Text + "') ", bag);
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                   
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                    comboBox1.Text = "Select...";
                    listele();

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE courses SET DepartmentId=" + comboBox1.Text + ",course='" + textBox1.Text + "',description='" + textBox2.Text + "' WHERE courseid=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", bag);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    
                    listele();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.Text = "Select...";

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please choose course");
            }
            else
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand("Delete from COURSES where courseid=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", bag);
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    listele();
                    
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.Text = "Select...";

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            //comboBox1.SelectedIndex = -1;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button8;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }
    }
}
