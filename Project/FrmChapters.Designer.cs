namespace Project
{
    partial class FrmChapters
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
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChapterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChapterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChapter = new System.Windows.Forms.TextBox();
            this.txtChapterNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChapterNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 34);
            this.panel1.TabIndex = 56;
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
            // cbCourses
            // 
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(96, 46);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(200, 21);
            this.cbCourses.TabIndex = 65;
            this.cbCourses.Text = "Select...";
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.cbCourses_SelectedIndexChanged);
            this.cbCourses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCourses_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Course :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Location = new System.Drawing.Point(326, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 139);
            this.panel3.TabIndex = 60;
            // 
            // button4
            // 
            this.button4.Image = global::Project.Properties.Resources.ic_update_black_48dp_1x;
            this.button4.Location = new System.Drawing.Point(113, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 58);
            this.button4.TabIndex = 75;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::Project.Properties.Resources.ic_delete_forever_black_48dp_1x;
            this.button5.Location = new System.Drawing.Point(216, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 58);
            this.button5.TabIndex = 48;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Image = global::Project.Properties.Resources.ic_save_black_48dp_1x;
            this.btnInsert.Location = new System.Drawing.Point(16, 42);
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
            this.panel4.Location = new System.Drawing.Point(0, 198);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(854, 287);
            this.panel4.TabIndex = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clChapterNo,
            this.clChapterName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // clChapterNo
            // 
            this.clChapterNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clChapterNo.DataPropertyName = "ChapterNo";
            this.clChapterNo.HeaderText = "Chapter No";
            this.clChapterNo.Name = "clChapterNo";
            this.clChapterNo.ReadOnly = true;
            // 
            // clChapterName
            // 
            this.clChapterName.DataPropertyName = "ChapterName";
            this.clChapterName.HeaderText = "Chapter Name";
            this.clChapterName.Name = "clChapterName";
            this.clChapterName.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDepartments);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtChapter);
            this.panel2.Controls.Add(this.txtChapterNo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbCourses);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 164);
            this.panel2.TabIndex = 70;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(96, 19);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(200, 21);
            this.cbDepartments.TabIndex = 69;
            this.cbDepartments.Text = "Select...";
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            this.cbDepartments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDepartments_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Department :";
            // 
            // txtChapter
            // 
            this.txtChapter.Location = new System.Drawing.Point(96, 99);
            this.txtChapter.Multiline = true;
            this.txtChapter.Name = "txtChapter";
            this.txtChapter.Size = new System.Drawing.Size(200, 57);
            this.txtChapter.TabIndex = 67;
            this.txtChapter.Click += new System.EventHandler(this.txtChapter_Click);
            // 
            // txtChapterNo
            // 
            this.txtChapterNo.Location = new System.Drawing.Point(96, 73);
            this.txtChapterNo.Name = "txtChapterNo";
            this.txtChapterNo.Size = new System.Drawing.Size(58, 20);
            this.txtChapterNo.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Chapter :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Chapter No :";
            // 
            // FrmChapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChapters";
            this.Text = "add chapter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChapters_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChapterNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtChapter;
        private System.Windows.Forms.NumericUpDown txtChapterNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChapterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChapterName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}