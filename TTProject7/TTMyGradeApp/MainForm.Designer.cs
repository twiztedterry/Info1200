namespace TTMyGradeApp
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoringMethods = new System.Windows.Forms.Button();
            this.btnLetterGrade = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnStudyLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Trevor\'s Grades";
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(15, 42);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "&Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(100, 42);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(75, 23);
            this.btnWelcome.TabIndex = 2;
            this.btnWelcome.Text = "&Welcome";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(96, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoringMethods
            // 
            this.btnScoringMethods.Location = new System.Drawing.Point(12, 158);
            this.btnScoringMethods.Name = "btnScoringMethods";
            this.btnScoringMethods.Size = new System.Drawing.Size(156, 23);
            this.btnScoringMethods.TabIndex = 4;
            this.btnScoringMethods.Text = "&Scoring Methods";
            this.btnScoringMethods.UseVisualStyleBackColor = true;
            this.btnScoringMethods.Click += new System.EventHandler(this.btnScoringMethods_Click);
            // 
            // btnLetterGrade
            // 
            this.btnLetterGrade.Location = new System.Drawing.Point(15, 129);
            this.btnLetterGrade.Name = "btnLetterGrade";
            this.btnLetterGrade.Size = new System.Drawing.Size(75, 23);
            this.btnLetterGrade.TabIndex = 5;
            this.btnLetterGrade.Text = "&Letter Grade";
            this.btnLetterGrade.UseVisualStyleBackColor = true;
            this.btnLetterGrade.Click += new System.EventHandler(this.btnLetterGrade_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(15, 71);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 6;
            this.btnTimer.Text = "&Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnStudyLog
            // 
            this.btnStudyLog.Location = new System.Drawing.Point(15, 100);
            this.btnStudyLog.Name = "btnStudyLog";
            this.btnStudyLog.Size = new System.Drawing.Size(75, 23);
            this.btnStudyLog.TabIndex = 7;
            this.btnStudyLog.Text = "St&udy Log";
            this.btnStudyLog.UseVisualStyleBackColor = true;
            this.btnStudyLog.Click += new System.EventHandler(this.btnStudyLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 222);
            this.Controls.Add(this.btnStudyLog);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnLetterGrade);
            this.Controls.Add(this.btnScoringMethods);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "My Grade App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoringMethods;
        private System.Windows.Forms.Button btnLetterGrade;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnStudyLog;
    }
}

