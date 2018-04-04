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
            this.txtboxSemester = new System.Windows.Forms.TextBox();
            this.txtboxInstructor = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblTitleAddCourse = new System.Windows.Forms.Label();
            this.lblTitleMyCourses = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstboxMyCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtboxCourseName
            // 
            this.txtboxCourseName.Location = new System.Drawing.Point(93, 43);
            this.txtboxCourseName.Name = "txtboxCourseName";
            this.txtboxCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtboxCourseName.TabIndex = 0;
            // 
            // txtboxSemester
            // 
            this.txtboxSemester.Location = new System.Drawing.Point(93, 69);
            this.txtboxSemester.Name = "txtboxSemester";
            this.txtboxSemester.Size = new System.Drawing.Size(100, 20);
            this.txtboxSemester.TabIndex = 1;
            // 
            // txtboxInstructor
            // 
            this.txtboxInstructor.Location = new System.Drawing.Point(93, 95);
            this.txtboxInstructor.Name = "txtboxInstructor";
            this.txtboxInstructor.Size = new System.Drawing.Size(100, 20);
            this.txtboxInstructor.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 46);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(12, 72);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "Semester:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(12, 98);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(54, 13);
            this.lblInstructor.TabIndex = 5;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblTitleAddCourse
            // 
            this.lblTitleAddCourse.AutoSize = true;
            this.lblTitleAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddCourse.Location = new System.Drawing.Point(12, 9);
            this.lblTitleAddCourse.Name = "lblTitleAddCourse";
            this.lblTitleAddCourse.Size = new System.Drawing.Size(102, 16);
            this.lblTitleAddCourse.TabIndex = 6;
            this.lblTitleAddCourse.Text = "Add a Course";
            // 
            // lblTitleMyCourses
            // 
            this.lblTitleMyCourses.AutoSize = true;
            this.lblTitleMyCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMyCourses.Location = new System.Drawing.Point(12, 180);
            this.lblTitleMyCourses.Name = "lblTitleMyCourses";
            this.lblTitleMyCourses.Size = new System.Drawing.Size(93, 16);
            this.lblTitleMyCourses.TabIndex = 7;
            this.lblTitleMyCourses.Text = "My Courses:";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(74, 137);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(92, 27);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(82, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstboxMyCourses
            // 
            this.lstboxMyCourses.FormattingEnabled = true;
            this.lstboxMyCourses.Location = new System.Drawing.Point(15, 208);
            this.lstboxMyCourses.Name = "lstboxMyCourses";
            this.lstboxMyCourses.Size = new System.Drawing.Size(206, 82);
            this.lstboxMyCourses.TabIndex = 10;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 331);
            this.Controls.Add(this.lstboxMyCourses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblTitleMyCourses);
            this.Controls.Add(this.lblTitleAddCourse);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtboxInstructor);
            this.Controls.Add(this.txtboxSemester);
            this.Controls.Add(this.txtboxCourseName);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCourseName;
        private System.Windows.Forms.TextBox txtboxSemester;
        private System.Windows.Forms.TextBox txtboxInstructor;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblTitleAddCourse;
        private System.Windows.Forms.Label lblTitleMyCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstboxMyCourses;
    }
}