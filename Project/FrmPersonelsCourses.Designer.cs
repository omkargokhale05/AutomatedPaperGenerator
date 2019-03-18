namespace Project
{
    partial class FrmPersonelsCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 34);
            this.panel1.TabIndex = 55;
            // 
            // button6
            // 
            this.button6.Image = global::Project.Properties.Resources.back;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 29);
            this.button6.TabIndex = 46;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Location = new System.Drawing.Point(391, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 102);
            this.panel3.TabIndex = 56;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Project.Properties.Resources.ic_update_black_48dp_1x;
            this.btnUpdate.Location = new System.Drawing.Point(106, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 58);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::Project.Properties.Resources.ic_delete_forever_black_48dp_1x;
            this.button5.Location = new System.Drawing.Point(196, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 58);
            this.button5.TabIndex = 47;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Image = global::Project.Properties.Resources.ic_save_black_48dp_1x;
            this.btnInsert.Location = new System.Drawing.Point(14, 23);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(59, 58);
            this.btnInsert.TabIndex = 46;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 166);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(922, 317);
            this.panel4.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clsemester,
            this.clCourse,
            this.clDescription});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(902, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clId.DataPropertyName = "id";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // clsemester
            // 
            this.clsemester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clsemester.DataPropertyName = "semester";
            this.clsemester.HeaderText = "Semester";
            this.clsemester.Name = "clsemester";
            this.clsemester.ReadOnly = true;
            this.clsemester.Width = 300;
            // 
            // clCourse
            // 
            this.clCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clCourse.DataPropertyName = "course";
            this.clCourse.HeaderText = "Course";
            this.clCourse.Name = "clCourse";
            this.clCourse.ReadOnly = true;
            // 
            // clDescription
            // 
            this.clDescription.DataPropertyName = "description";
            this.clDescription.HeaderText = "Description";
            this.clDescription.Name = "clDescription";
            this.clDescription.ReadOnly = true;
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(115, 16);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(258, 21);
            this.cbSemester.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Semester :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Teacher Name :";
            // 
            // cbPersonels
            // 
            this.cbPersonels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonels.FormattingEnabled = true;
            this.cbPersonels.Location = new System.Drawing.Point(115, 43);
            this.cbPersonels.Name = "cbPersonels";
            this.cbPersonels.Size = new System.Drawing.Size(258, 21);
            this.cbPersonels.TabIndex = 59;
            this.cbPersonels.SelectedIndexChanged += new System.EventHandler(this.cbPersonels_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Department :";
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(115, 70);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(258, 21);
            this.cbDepartments.TabIndex = 59;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Course :";
            // 
            // cbCourses
            // 
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(115, 97);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(258, 21);
            this.cbCourses.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSemester);
            this.panel2.Controls.Add(this.cbCourses);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbDepartments);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbPersonels);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 132);
            this.panel2.TabIndex = 60;
            // 
            // FrmPersonelsCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 483);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonelsCourses";
            this.Text = "Teachers Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdate;
    }
}