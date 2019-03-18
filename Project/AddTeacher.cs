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
    public partial class AddTeacher : Form
    {
        public Login frm1;
        public AddTeacher()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString);
        DataTable tablo = new DataTable();

        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from personnel", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }


        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    bag.Open();
                    SqlCommand kmt = new SqlCommand("INSERT INTO personnel(name,surname,address,phone,email,password,sq,answer) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "') ", bag);
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                   
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                    maskedTextBox1.Clear(); textBox4.Clear(); textBox5.Clear();
                    textBox6.Clear();
                    textBox10.Clear();
                    label9.Text = "";
                    comboBox1.Text = "Select..";
                    listele();

                }

            }

        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AdmUpdatePersonnel_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Surname";
            dataGridView1.Columns[3].HeaderText = "Address";
            DataGridViewColumn columnss = dataGridView1.Columns[3];
            columnss.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].HeaderText = "Phone";
            dataGridView1.Columns[5].HeaderText = "E-mail";
            DataGridViewColumn column = dataGridView1.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Secret Question";
            DataGridViewColumn columns = dataGridView1.Columns[7];
            columns.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].HeaderText = "Answer";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "Select..";
            textBox6.Clear();
           
            textBox10.Clear();
            label9.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                tablo.Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("Select * from personnel where name like '%" + textBox10.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                MessageBox.Show("Please enter Name");
            } 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button3; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                
             
            
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please choose Teacher than Fill in the blanks!");
            }
            else
            {

                DialogResult answer;
                answer = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE personnel SET name='" + textBox1.Text + "',surname='" + textBox2.Text + "',address='" + textBox3.Text + "',phone='" + maskedTextBox1.Text + "',email='" + textBox4.Text + "',password='" + textBox5.Text + "',sq='" + comboBox1.Text + "',answer='" + textBox6.Text + "' WHERE id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                   
                    listele();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    maskedTextBox1.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    comboBox1.Text = "Select..";
                    textBox6.Clear();
                    label9.Text = "";
                    textBox10.Clear();
                }
            }
        }

       

      

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please choose Teacher!");
            }
            else
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand("Delete from personnel where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    listele();
                   
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    maskedTextBox1.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    comboBox1.Text = "Select..";
                    textBox6.Clear();
                    label9.Text = "";
                    textBox10.Clear();
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "Select..";
            textBox6.Clear();
            label9.Text = "";
            textBox10.Clear();
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_Validated(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            //txtmail is name/object of textbox
            

                //rEMail is object of Regex class located in System.Text.RegularExpressions
                if (!rEMail.IsMatch(textBox4.Text))
                {
                    // MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label9.Text = "Email is incorrect! ";
                    textBox4.SelectAll();

                
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

      


    }
}
