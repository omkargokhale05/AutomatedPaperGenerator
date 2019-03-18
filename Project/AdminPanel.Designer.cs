namespace Project
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPersonelsCourses = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoursesTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1236, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1081, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "label9";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(24, 664);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 27);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnPersonelsCourses);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(22, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 249);
            this.panel2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::Project.Properties.Resources.seee;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(1079, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 157);
            this.button3.TabIndex = 57;
            this.button3.Text = "Semester";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnPersonelsCourses
            // 
            this.btnPersonelsCourses.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelsCourses.Image = global::Project.Properties.Resources.Personnel_icon;
            this.btnPersonelsCourses.Location = new System.Drawing.Point(311, 45);
            this.btnPersonelsCourses.Name = "btnPersonelsCourses";
            this.btnPersonelsCourses.Size = new System.Drawing.Size(154, 157);
            this.btnPersonelsCourses.TabIndex = 56;
            this.btnPersonelsCourses.Text = "Add Courses Teacher";
            this.btnPersonelsCourses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelsCourses.UseVisualStyleBackColor = true;
            this.btnPersonelsCourses.Click += new System.EventHandler(this.btnPersonelsCourses_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = global::Project.Properties.Resources.te1;
            this.button5.Location = new System.Drawing.Point(70, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 157);
            this.button5.TabIndex = 56;
            this.button5.Text = "Manage Teachers";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = global::Project.Properties.Resources._140;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(559, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 157);
            this.button6.TabIndex = 12;
            this.button6.Text = "Department";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Project.Properties.Resources.fac;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(824, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 157);
            this.button1.TabIndex = 52;
            this.button1.Text = "Course";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Image = global::Project.Properties.Resources.exit__1_;
            this.button4.Location = new System.Drawing.Point(1253, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 41);
            this.button4.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button4, "Log out");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(24, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 59);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Welcome";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(22, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1317, 87);
            this.panel6.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(524, 72);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1530, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerTeachersToolStripMenuItem,
            this.addCoursesTeacherToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.chaptersToolStripMenuItem,
            this.semesterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // managerTeachersToolStripMenuItem
            // 
            this.managerTeachersToolStripMenuItem.Name = "managerTeachersToolStripMenuItem";
            this.managerTeachersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.managerTeachersToolStripMenuItem.Text = "Manager Teachers";
            this.managerTeachersToolStripMenuItem.Click += new System.EventHandler(this.managerTeachersToolStripMenuItem_Click);
            // 
            // addCoursesTeacherToolStripMenuItem
            // 
            this.addCoursesTeacherToolStripMenuItem.Name = "addCoursesTeacherToolStripMenuItem";
            this.addCoursesTeacherToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addCoursesTeacherToolStripMenuItem.Text = "Add Courses Teacher";
            this.addCoursesTeacherToolStripMenuItem.Click += new System.EventHandler(this.addCoursesTeacherToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.chaptersToolStripMenuItem.Text = "Chapters";
            this.chaptersToolStripMenuItem.Click += new System.EventHandler(this.chaptersToolStripMenuItem_Click);
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.semesterToolStripMenuItem.Text = "Semester";
            this.semesterToolStripMenuItem.Click += new System.EventHandler(this.semesterToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 738);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonelsCourses;
        private System.Windows.Forms.ToolStripMenuItem addCoursesTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
    }
}