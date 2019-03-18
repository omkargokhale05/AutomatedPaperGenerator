namespace Project
{
    partial class AddQusetion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClassicInsert = new System.Windows.Forms.Button();
            this.txtClassicAnswer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTrueFalseInsert = new System.Windows.Forms.Button();
            this.cbQuestionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnMultiInsert = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMultiD = new System.Windows.Forms.TextBox();
            this.txtMultiB = new System.Windows.Forms.TextBox();
            this.txtMultiC = new System.Windows.Forms.TextBox();
            this.txtMultiA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbAcedemicYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nboxOrder = new System.Windows.Forms.NumericUpDown();
            this.cbMultiD = new System.Windows.Forms.RadioButton();
            this.cbMultiC = new System.Windows.Forms.RadioButton();
            this.cbMultiB = new System.Windows.Forms.RadioButton();
            this.cbMultiA = new System.Windows.Forms.RadioButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.tcSorular = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.DGQuestions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboxOrder)).BeginInit();
            this.tcSorular.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlSol.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 34);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Course :";
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(87, 83);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(251, 21);
            this.cbCourse.TabIndex = 63;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Answer";
            // 
            // btnClassicInsert
            // 
            this.btnClassicInsert.Location = new System.Drawing.Point(17, 141);
            this.btnClassicInsert.Name = "btnClassicInsert";
            this.btnClassicInsert.Size = new System.Drawing.Size(75, 23);
            this.btnClassicInsert.TabIndex = 72;
            this.btnClassicInsert.Tag = "1";
            this.btnClassicInsert.Text = "Insert";
            this.btnClassicInsert.UseVisualStyleBackColor = true;
            this.btnClassicInsert.Click += new System.EventHandler(this.btnMultiInsert_Click);
            // 
            // txtClassicAnswer
            // 
            this.txtClassicAnswer.Location = new System.Drawing.Point(11, 32);
            this.txtClassicAnswer.Multiline = true;
            this.txtClassicAnswer.Name = "txtClassicAnswer";
            this.txtClassicAnswer.Size = new System.Drawing.Size(351, 103);
            this.txtClassicAnswer.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Answer";
            // 
            // btnTrueFalseInsert
            // 
            this.btnTrueFalseInsert.Location = new System.Drawing.Point(30, 54);
            this.btnTrueFalseInsert.Name = "btnTrueFalseInsert";
            this.btnTrueFalseInsert.Size = new System.Drawing.Size(75, 23);
            this.btnTrueFalseInsert.TabIndex = 75;
            this.btnTrueFalseInsert.Tag = "3";
            this.btnTrueFalseInsert.Text = "Insert";
            this.btnTrueFalseInsert.UseVisualStyleBackColor = true;
            this.btnTrueFalseInsert.Click += new System.EventHandler(this.btnMultiInsert_Click);
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
            this.cbQuestionType.Location = new System.Drawing.Point(87, 137);
            this.cbQuestionType.Name = "cbQuestionType";
            this.cbQuestionType.Size = new System.Drawing.Size(251, 21);
            this.cbQuestionType.TabIndex = 69;
            this.cbQuestionType.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Exam Type :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Answer";
            // 
            // btnMultiInsert
            // 
            this.btnMultiInsert.Location = new System.Drawing.Point(29, 197);
            this.btnMultiInsert.Name = "btnMultiInsert";
            this.btnMultiInsert.Size = new System.Drawing.Size(71, 23);
            this.btnMultiInsert.TabIndex = 76;
            this.btnMultiInsert.Tag = "2";
            this.btnMultiInsert.Text = "Insert";
            this.btnMultiInsert.UseVisualStyleBackColor = true;
            this.btnMultiInsert.Click += new System.EventHandler(this.btnMultiInsert_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Question";
            // 
            // txtMultiD
            // 
            this.txtMultiD.Location = new System.Drawing.Point(29, 158);
            this.txtMultiD.Name = "txtMultiD";
            this.txtMultiD.Size = new System.Drawing.Size(287, 20);
            this.txtMultiD.TabIndex = 4;
            this.txtMultiD.Text = "d)";
            // 
            // txtMultiB
            // 
            this.txtMultiB.Location = new System.Drawing.Point(29, 77);
            this.txtMultiB.Name = "txtMultiB";
            this.txtMultiB.Size = new System.Drawing.Size(286, 20);
            this.txtMultiB.TabIndex = 2;
            this.txtMultiB.Tag = "";
            this.txtMultiB.Text = "b)";
            // 
            // txtMultiC
            // 
            this.txtMultiC.Location = new System.Drawing.Point(29, 116);
            this.txtMultiC.Name = "txtMultiC";
            this.txtMultiC.Size = new System.Drawing.Size(287, 20);
            this.txtMultiC.TabIndex = 3;
            this.txtMultiC.Text = "c)";
            // 
            // txtMultiA
            // 
            this.txtMultiA.Location = new System.Drawing.Point(29, 35);
            this.txtMultiA.Name = "txtMultiA";
            this.txtMultiA.Size = new System.Drawing.Size(286, 20);
            this.txtMultiA.TabIndex = 1;
            this.txtMultiA.Text = "a)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDept);
            this.groupBox4.Controls.Add(this.cbDept);
            this.groupBox4.Controls.Add(this.cbAcedemicYear);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbChapter);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbCourse);
            this.groupBox4.Controls.Add(this.cbQuestionType);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 199);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(18, 56);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(68, 13);
            this.lblDept.TabIndex = 96;
            this.lblDept.Text = "Department :";
            // 
            // cbDept
            // 
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(87, 56);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(250, 21);
            this.cbDept.TabIndex = 95;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // cbAcedemicYear
            // 
            this.cbAcedemicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcedemicYear.FormattingEnabled = true;
            this.cbAcedemicYear.Location = new System.Drawing.Point(87, 29);
            this.cbAcedemicYear.Name = "cbAcedemicYear";
            this.cbAcedemicYear.Size = new System.Drawing.Size(251, 21);
            this.cbAcedemicYear.TabIndex = 94;
            this.cbAcedemicYear.SelectedIndexChanged += new System.EventHandler(this.cbAcedemicYear_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Academc Year :";
            // 
            // cbChapter
            // 
            this.cbChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Location = new System.Drawing.Point(87, 110);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(251, 21);
            this.cbChapter.TabIndex = 56;
            this.cbChapter.SelectedIndexChanged += new System.EventHandler(this.cbChapter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Chapter :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdFalse);
            this.panel2.Controls.Add(this.rdTrue);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnTrueFalseInsert);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 88);
            this.panel2.TabIndex = 74;
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Location = new System.Drawing.Point(95, 31);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(58, 17);
            this.rdFalse.TabIndex = 82;
            this.rdFalse.Text = "FALSE";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Location = new System.Drawing.Point(30, 31);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(55, 17);
            this.rdTrue.TabIndex = 81;
            this.rdTrue.Text = "TRUE";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtClassicAnswer);
            this.panel3.Controls.Add(this.btnClassicInsert);
            this.panel3.Location = new System.Drawing.Point(16, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 180);
            this.panel3.TabIndex = 75;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nboxOrder);
            this.panel4.Controls.Add(this.cbMultiD);
            this.panel4.Controls.Add(this.cbMultiC);
            this.panel4.Controls.Add(this.cbMultiB);
            this.panel4.Controls.Add(this.cbMultiA);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.btnMultiInsert);
            this.panel4.Controls.Add(this.txtMultiA);
            this.panel4.Controls.Add(this.txtMultiC);
            this.panel4.Controls.Add(this.txtMultiB);
            this.panel4.Controls.Add(this.txtMultiD);
            this.panel4.Location = new System.Drawing.Point(6, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 253);
            this.panel4.TabIndex = 76;
            // 
            // nboxOrder
            // 
            this.nboxOrder.Location = new System.Drawing.Point(126, 200);
            this.nboxOrder.Name = "nboxOrder";
            this.nboxOrder.Size = new System.Drawing.Size(60, 20);
            this.nboxOrder.TabIndex = 81;
            this.nboxOrder.Visible = false;
            // 
            // cbMultiD
            // 
            this.cbMultiD.AutoSize = true;
            this.cbMultiD.Location = new System.Drawing.Point(329, 159);
            this.cbMultiD.Name = "cbMultiD";
            this.cbMultiD.Size = new System.Drawing.Size(33, 17);
            this.cbMultiD.TabIndex = 80;
            this.cbMultiD.Text = "D";
            this.cbMultiD.UseVisualStyleBackColor = true;
            // 
            // cbMultiC
            // 
            this.cbMultiC.AutoSize = true;
            this.cbMultiC.Location = new System.Drawing.Point(329, 117);
            this.cbMultiC.Name = "cbMultiC";
            this.cbMultiC.Size = new System.Drawing.Size(32, 17);
            this.cbMultiC.TabIndex = 79;
            this.cbMultiC.Text = "C";
            this.cbMultiC.UseVisualStyleBackColor = true;
            // 
            // cbMultiB
            // 
            this.cbMultiB.AutoSize = true;
            this.cbMultiB.Location = new System.Drawing.Point(329, 79);
            this.cbMultiB.Name = "cbMultiB";
            this.cbMultiB.Size = new System.Drawing.Size(32, 17);
            this.cbMultiB.TabIndex = 78;
            this.cbMultiB.Text = "B";
            this.cbMultiB.UseVisualStyleBackColor = true;
            // 
            // cbMultiA
            // 
            this.cbMultiA.AutoSize = true;
            this.cbMultiA.Location = new System.Drawing.Point(329, 37);
            this.cbMultiA.Name = "cbMultiA";
            this.cbMultiA.Size = new System.Drawing.Size(32, 17);
            this.cbMultiA.TabIndex = 77;
            this.cbMultiA.Text = "A";
            this.cbMultiA.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(33, 43);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(351, 69);
            this.txtQuestion.TabIndex = 0;
            // 
            // tcSorular
            // 
            this.tcSorular.Controls.Add(this.tabPage1);
            this.tcSorular.Controls.Add(this.tabPage2);
            this.tcSorular.Controls.Add(this.tabPage3);
            this.tcSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSorular.Location = new System.Drawing.Point(596, 129);
            this.tcSorular.Name = "tcSorular";
            this.tcSorular.SelectedIndex = 0;
            this.tcSorular.Size = new System.Drawing.Size(417, 499);
            this.tcSorular.TabIndex = 77;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Classic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Choose";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(624, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "True False";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.pnlGrid);
            this.pnlSol.Controls.Add(this.groupBox4);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(596, 628);
            this.pnlSol.TabIndex = 78;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.DGQuestions);
            this.pnlGrid.Location = new System.Drawing.Point(0, 227);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1009, 401);
            this.pnlGrid.TabIndex = 76;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.tcSorular);
            this.pnlOrta.Controls.Add(this.pnlQuestion);
            this.pnlOrta.Controls.Add(this.pnlSol);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 34);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1013, 628);
            this.pnlOrta.TabIndex = 78;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.txtQuestion);
            this.pnlQuestion.Controls.Add(this.label13);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestion.Location = new System.Drawing.Point(596, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(417, 129);
            this.pnlQuestion.TabIndex = 79;
            this.pnlQuestion.Visible = false;
            // 
            // DGQuestions
            // 
            this.DGQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGQuestions.Location = new System.Drawing.Point(0, 0);
            this.DGQuestions.Name = "DGQuestions";
            this.DGQuestions.Size = new System.Drawing.Size(596, 401);
            this.DGQuestions.TabIndex = 0;
            // 
            // AddQusetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1013, 662);
            this.ControlBox = false;
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.panel1);
            this.Name = "AddQusetion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQusetion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddQusetion_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboxOrder)).EndInit();
            this.tcSorular.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlOrta.ResumeLayout(false);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbQuestionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassicAnswer;
        private System.Windows.Forms.Button btnClassicInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMultiD;
        private System.Windows.Forms.TextBox txtMultiB;
        private System.Windows.Forms.TextBox txtMultiC;
        private System.Windows.Forms.TextBox txtMultiA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTrueFalseInsert;
        private System.Windows.Forms.Button btnMultiInsert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdFalse;
        private System.Windows.Forms.RadioButton rdTrue;
        private System.Windows.Forms.RadioButton cbMultiD;
        private System.Windows.Forms.RadioButton cbMultiC;
        private System.Windows.Forms.RadioButton cbMultiB;
        private System.Windows.Forms.RadioButton cbMultiA;
        private System.Windows.Forms.TabControl tcSorular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.NumericUpDown nboxOrder;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.ComboBox cbChapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAcedemicYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView DGQuestions;
    }
}