namespace TTMyGradeApp
{
    partial class AddCourse
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
            this.txtboxCourseName = new System.Windows.Forms.TextBox();
            this.txtboxInstructor = new System.Windows.Forms.TextBox();
            this.txtboxSemester = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblTitleAddCourse = new System.Windows.Forms.Label();
            this.lblTitleMyCourses = new System.Windows.Forms.Label();
            this.listboxCourses = new System.Windows.Forms.ListBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxCourseName
            // 
            this.txtboxCourseName.Location = new System.Drawing.Point(90, 34);
            this.txtboxCourseName.Name = "txtboxCourseName";
            this.txtboxCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtboxCourseName.TabIndex = 0;
            // 
            // txtboxInstructor
            // 
            this.txtboxInstructor.Location = new System.Drawing.Point(90, 86);
            this.txtboxInstructor.Name = "txtboxInstructor";
            this.txtboxInstructor.Size = new System.Drawing.Size(100, 20);
            this.txtboxInstructor.TabIndex = 2;
            // 
            // txtboxSemester
            // 
            this.txtboxSemester.Location = new System.Drawing.Point(90, 60);
            this.txtboxSemester.Name = "txtboxSemester";
            this.txtboxSemester.Size = new System.Drawing.Size(100, 20);
            this.txtboxSemester.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(13, 37);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 9;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(13, 63);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSemester.TabIndex = 8;
            this.lblSemester.Text = "Semester:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(13, 89);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(54, 13);
            this.lblInstructor.TabIndex = 7;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblTitleAddCourse
            // 
            this.lblTitleAddCourse.AutoSize = true;
            this.lblTitleAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddCourse.Location = new System.Drawing.Point(13, 9);
            this.lblTitleAddCourse.Name = "lblTitleAddCourse";
            this.lblTitleAddCourse.Size = new System.Drawing.Size(102, 16);
            this.lblTitleAddCourse.TabIndex = 10;
            this.lblTitleAddCourse.Text = "Add a Course";
            // 
            // lblTitleMyCourses
            // 
            this.lblTitleMyCourses.AutoSize = true;
            this.lblTitleMyCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMyCourses.Location = new System.Drawing.Point(13, 184);
            this.lblTitleMyCourses.Name = "lblTitleMyCourses";
            this.lblTitleMyCourses.Size = new System.Drawing.Size(93, 16);
            this.lblTitleMyCourses.TabIndex = 6;
            this.lblTitleMyCourses.Text = "My Courses:";
            // 
            // listboxCourses
            // 
            this.listboxCourses.FormattingEnabled = true;
            this.listboxCourses.Location = new System.Drawing.Point(16, 203);
            this.listboxCourses.Name = "listboxCourses";
            this.listboxCourses.Size = new System.Drawing.Size(252, 56);
            this.listboxCourses.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(90, 131);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(100, 29);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Save and Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 307);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.listboxCourses);
            this.Controls.Add(this.lblTitleMyCourses);
            this.Controls.Add(this.lblTitleAddCourse);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtboxSemester);
            this.Controls.Add(this.txtboxInstructor);
            this.Controls.Add(this.txtboxCourseName);
            this.Name = "AddCourse";
            this.Text = "Add a Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCourseName;
        private System.Windows.Forms.TextBox txtboxInstructor;
        private System.Windows.Forms.TextBox txtboxSemester;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblTitleAddCourse;
        private System.Windows.Forms.Label lblTitleMyCourses;
        private System.Windows.Forms.ListBox listboxCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;
    }
}