namespace Project
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnAlternative = new System.Windows.Forms.Button();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbQuestionType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cl2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2ChapterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2Chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2QuestionsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2QuestionsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrnd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAcedemicYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.report = new FastReport.Report();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.clChapterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuestionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clChapterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.pnlSol.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(115, 445);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(75, 23);
            this.btnPrepare.TabIndex = 0;
            this.btnPrepare.Text = "Prepare";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnAlternative
            // 
            this.btnAlternative.Location = new System.Drawing.Point(34, 445);
            this.btnAlternative.Name = "btnAlternative";
            this.btnAlternative.Size = new System.Drawing.Size(75, 23);
            this.btnAlternative.TabIndex = 0;
            this.btnAlternative.Text = "All Chapter";
            this.btnAlternative.UseVisualStyleBackColor = true;
            this.btnAlternative.Click += new System.EventHandler(this.btnAlternative_Click);
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.groupBox4);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 34);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(381, 583);
            this.pnlSol.TabIndex = 79;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDept);
            this.groupBox4.Controls.Add(this.cbDept);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnStore);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.cbChapter);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbQuestionType);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.txtrnd);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbAcedemicYear);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.btnReport);
            this.groupBox4.Controls.Add(this.btnAlternative);
            this.groupBox4.Controls.Add(this.btnPrepare);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbCourse);
            this.groupBox4.Location = new System.Drawing.Point(12, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 526);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(276, 445);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 102;
            this.btnStore.Text = "Save Paper";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 101;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 100;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbChapter
            // 
            this.cbChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Location = new System.Drawing.Point(106, 111);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(251, 21);
            this.cbChapter.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Chapter :";
            // 
            // cbQuestionType
            // 
            this.cbQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionType.FormattingEnabled = true;
            this.cbQuestionType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbQuestionType.Items.AddRange(new object[] {
            "Classic",
            "Multiple choice",
            "T/F"});
            this.cbQuestionType.Location = new System.Drawing.Point(106, 138);
            this.cbQuestionType.Name = "cbQuestionType";
            this.cbQuestionType.Size = new System.Drawing.Size(251, 21);
            this.cbQuestionType.TabIndex = 99;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Exam Type :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl2Id,
            this.cl2CourseId,
            this.cl2ChapterId,
            this.cl2Type,
            this.cl2Course,
            this.cl2Chapter,
            this.cl2QuestionsType,
            this.cl2QuestionsCount});
            this.dataGridView2.Location = new System.Drawing.Point(19, 201);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(337, 112);
            this.dataGridView2.TabIndex = 95;
            // 
            // cl2Id
            // 
            this.cl2Id.DataPropertyName = "Id";
            this.cl2Id.HeaderText = "Id";
            this.cl2Id.Name = "cl2Id";
            this.cl2Id.ReadOnly = true;
            this.cl2Id.Visible = false;
            // 
            // cl2CourseId
            // 
            this.cl2CourseId.DataPropertyName = "CourseId";
            this.cl2CourseId.HeaderText = "CourseId";
            this.cl2CourseId.Name = "cl2CourseId";
            this.cl2CourseId.Visible = false;
            // 
            // cl2ChapterId
            // 
            this.cl2ChapterId.DataPropertyName = "ChapterId";
            this.cl2ChapterId.HeaderText = "ChapterId";
            this.cl2ChapterId.Name = "cl2ChapterId";
            this.cl2ChapterId.Visible = false;
            // 
            // cl2Type
            // 
            this.cl2Type.DataPropertyName = "Type";
            this.cl2Type.HeaderText = "Type";
            this.cl2Type.Name = "cl2Type";
            this.cl2Type.Visible = false;
            // 
            // cl2Course
            // 
            this.cl2Course.DataPropertyName = "Course";
            this.cl2Course.HeaderText = "Course";
            this.cl2Course.Name = "cl2Course";
            // 
            // cl2Chapter
            // 
            this.cl2Chapter.DataPropertyName = "Chapter";
            this.cl2Chapter.HeaderText = "Chapter";
            this.cl2Chapter.Name = "cl2Chapter";
            // 
            // cl2QuestionsType
            // 
            this.cl2QuestionsType.DataPropertyName = "QuestionsType";
            this.cl2QuestionsType.HeaderText = "Type";
            this.cl2QuestionsType.Name = "cl2QuestionsType";
            // 
            // cl2QuestionsCount
            // 
            this.cl2QuestionsCount.DataPropertyName = "QuestionsCount";
            this.cl2QuestionsCount.HeaderText = "Count";
            this.cl2QuestionsCount.Name = "cl2QuestionsCount";
            // 
            // txtrnd
            // 
            this.txtrnd.Location = new System.Drawing.Point(112, 167);
            this.txtrnd.Name = "txtrnd";
            this.txtrnd.Size = new System.Drawing.Size(68, 20);
            this.txtrnd.TabIndex = 94;
            this.txtrnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtrnd.Click += new System.EventHandler(this.txtrnd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(212, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Ex: 90 min.";
            // 
            // cbAcedemicYear
            // 
            this.cbAcedemicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcedemicYear.FormattingEnabled = true;
            this.cbAcedemicYear.Location = new System.Drawing.Point(106, 29);
            this.cbAcedemicYear.Name = "cbAcedemicYear";
            this.cbAcedemicYear.Size = new System.Drawing.Size(251, 21);
            this.cbAcedemicYear.TabIndex = 92;
            this.cbAcedemicYear.SelectedIndexChanged += new System.EventHandler(this.cbAcedemicYear_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "Exam Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Random Questions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Select Exam Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Academc Year :";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Final",
            "Midterm",
            "Quiz"});
            this.comboBox4.Location = new System.Drawing.Point(106, 407);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(251, 21);
            this.comboBox4.TabIndex = 87;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 76;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(195, 445);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Course :";
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(106, 84);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(251, 21);
            this.cbCourse.TabIndex = 63;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // report
            // 
            this.report.ReportResourceString = resources.GetString("report.ReportResourceString");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 34);
            this.panel1.TabIndex = 81;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.del,
            this.clChapterId,
            this.clQuestionTypeId,
            this.clCh,
            this.clChapterName,
            this.clTypeName,
            this.clName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(381, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.Size = new System.Drawing.Size(603, 583);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            this.clId.Width = 60;
            // 
            // del
            // 
            this.del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.del.HeaderText = "Delete";
            this.del.Image = global::Project.Properties.Resources.deles;
            this.del.Name = "del";
            this.del.Width = 44;
            // 
            // clChapterId
            // 
            this.clChapterId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clChapterId.DataPropertyName = "ChapterId";
            this.clChapterId.HeaderText = "ChapterId";
            this.clChapterId.Name = "clChapterId";
            this.clChapterId.ReadOnly = true;
            this.clChapterId.Visible = false;
            this.clChapterId.Width = 6;
            // 
            // clQuestionTypeId
            // 
            this.clQuestionTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clQuestionTypeId.DataPropertyName = "QuestionTypeId";
            this.clQuestionTypeId.HeaderText = "QuestionTypeId";
            this.clQuestionTypeId.Name = "clQuestionTypeId";
            this.clQuestionTypeId.ReadOnly = true;
            this.clQuestionTypeId.Visible = false;
            this.clQuestionTypeId.Width = 60;
            // 
            // clCh
            // 
            this.clCh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clCh.DataPropertyName = "Ch";
            this.clCh.FalseValue = "false";
            this.clCh.HeaderText = "Choosen";
            this.clCh.Name = "clCh";
            this.clCh.TrueValue = "true";
            this.clCh.Width = 80;
            // 
            // clChapterName
            // 
            this.clChapterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clChapterName.DataPropertyName = "ChapterName";
            this.clChapterName.HeaderText = "Chapter";
            this.clChapterName.Name = "clChapterName";
            this.clChapterName.ReadOnly = true;
            this.clChapterName.Width = 150;
            // 
            // clTypeName
            // 
            this.clTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clTypeName.DataPropertyName = "TypeName";
            this.clTypeName.HeaderText = "Type";
            this.clTypeName.Name = "clTypeName";
            this.clTypeName.ReadOnly = true;
            this.clTypeName.Width = 80;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Question";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::Project.Properties.Resources.deles;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 111;
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(105, 57);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(251, 21);
            this.cbDept.TabIndex = 104;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(30, 57);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(65, 13);
            this.lblDept.TabIndex = 105;
            this.lblDept.Text = "Department:";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 617);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReports";
            this.Text = "Create Question Paper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReports_Load);
            this.pnlSol.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnAlternative;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Button btnReport;
        private FastReport.Report report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAcedemicYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown txtrnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbChapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbQuestionType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2ChapterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2Chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2QuestionsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2QuestionsCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChapterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuestionTypeId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChapterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Label lblDept;
    }
}