namespace TTMyGradeApp
{
    partial class StudyLog
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.listboxCourses = new System.Windows.Forms.ListBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.textboxMinutes = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblLogEntries = new System.Windows.Forms.Label();
            this.btnAddLogEntry = new System.Windows.Forms.Button();
            this.listboxLogEntries = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtboxNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Today\'s Date";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(216, 9);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(90, 13);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Select Course:";
            // 
            // listboxCourses
            // 
            this.listboxCourses.FormattingEnabled = true;
            this.listboxCourses.Items.AddRange(new object[] {
            "INFO 1200",
            "INFO 2450",
            "MAT 1010",
            "ENG 1010"});
            this.listboxCourses.Location = new System.Drawing.Point(219, 25);
            this.listboxCourses.Name = "listboxCourses";
            this.listboxCourses.Size = new System.Drawing.Size(96, 82);
            this.listboxCourses.TabIndex = 2;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(15, 25);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.ReadOnly = true;
            this.txtboxDate.Size = new System.Drawing.Size(79, 20);
            this.txtboxDate.TabIndex = 3;
            // 
            // textboxMinutes
            // 
            this.textboxMinutes.Location = new System.Drawing.Point(15, 87);
            this.textboxMinutes.Name = "textboxMinutes";
            this.textboxMinutes.Size = new System.Drawing.Size(79, 20);
            this.textboxMinutes.TabIndex = 4;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(12, 71);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(115, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Duration: (Minutes)";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(12, 139);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 13);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Note:";
            // 
            // lblLogEntries
            // 
            this.lblLogEntries.AutoSize = true;
            this.lblLogEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogEntries.Location = new System.Drawing.Point(12, 248);
            this.lblLogEntries.Name = "lblLogEntries";
            this.lblLogEntries.Size = new System.Drawing.Size(123, 13);
            this.lblLogEntries.TabIndex = 9;
            this.lblLogEntries.Text = "Today\'s Log Entries:";
            // 
            // btnAddLogEntry
            // 
            this.btnAddLogEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogEntry.Location = new System.Drawing.Point(214, 155);
            this.btnAddLogEntry.Name = "btnAddLogEntry";
            this.btnAddLogEntry.Size = new System.Drawing.Size(101, 26);
            this.btnAddLogEntry.TabIndex = 10;
            this.btnAddLogEntry.Text = "Add Log Entry";
            this.btnAddLogEntry.UseVisualStyleBackColor = true;
            this.btnAddLogEntry.Click += new System.EventHandler(this.btnAddLogEntry_Click);
            // 
            // listboxLogEntries
            // 
            this.listboxLogEntries.FormattingEnabled = true;
            this.listboxLogEntries.Location = new System.Drawing.Point(12, 264);
            this.listboxLogEntries.Name = "listboxLogEntries";
            this.listboxLogEntries.Size = new System.Drawing.Size(303, 82);
            this.listboxLogEntries.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(214, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 26);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtboxNote
            // 
            this.txtboxNote.Location = new System.Drawing.Point(12, 156);
            this.txtboxNote.Multiline = true;
            this.txtboxNote.Name = "txtboxNote";
            this.txtboxNote.Size = new System.Drawing.Size(177, 89);
            this.txtboxNote.TabIndex = 14;
            // 
            // StudyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 391);
            this.Controls.Add(this.txtboxNote);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listboxLogEntries);
            this.Controls.Add(this.btnAddLogEntry);
            this.Controls.Add(this.lblLogEntries);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.textboxMinutes);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.listboxCourses);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblDate);
            this.Name = "StudyLog";
            this.Text = "StudyLog";
            this.Load += new System.EventHandler(this.StudyLog_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ListBox listboxCourses;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox textboxMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblLogEntries;
        private System.Windows.Forms.Button btnAddLogEntry;
        private System.Windows.Forms.ListBox listboxLogEntries;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtboxNote;
    }
}