namespace TTMyGradeApp
{
    partial class LetterGradeForm
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
            this.btnGradeCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtboxProject1 = new System.Windows.Forms.TextBox();
            this.txtboxQuiz1 = new System.Windows.Forms.TextBox();
            this.txtboxExam1 = new System.Windows.Forms.TextBox();
            this.lblProject1 = new System.Windows.Forms.Label();
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.lblMaxProject1 = new System.Windows.Forms.Label();
            this.lblMaxQuiz = new System.Windows.Forms.Label();
            this.lblMaxExam1 = new System.Windows.Forms.Label();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtboxFinalGrade = new System.Windows.Forms.TextBox();
            this.lblGradeLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGradeCalculate
            // 
            this.btnGradeCalculate.Location = new System.Drawing.Point(79, 257);
            this.btnGradeCalculate.Name = "btnGradeCalculate";
            this.btnGradeCalculate.Size = new System.Drawing.Size(113, 23);
            this.btnGradeCalculate.TabIndex = 1;
            this.btnGradeCalculate.Text = "Calculate My &Grade";
            this.btnGradeCalculate.UseVisualStyleBackColor = true;
            this.btnGradeCalculate.Click += new System.EventHandler(this.btnGradeCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(191, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtboxProject1
            // 
            this.txtboxProject1.Location = new System.Drawing.Point(12, 59);
            this.txtboxProject1.Name = "txtboxProject1";
            this.txtboxProject1.Size = new System.Drawing.Size(118, 20);
            this.txtboxProject1.TabIndex = 4;
            // 
            // txtboxQuiz1
            // 
            this.txtboxQuiz1.Location = new System.Drawing.Point(12, 106);
            this.txtboxQuiz1.Name = "txtboxQuiz1";
            this.txtboxQuiz1.Size = new System.Drawing.Size(118, 20);
            this.txtboxQuiz1.TabIndex = 5;
            // 
            // txtboxExam1
            // 
            this.txtboxExam1.Location = new System.Drawing.Point(12, 153);
            this.txtboxExam1.Name = "txtboxExam1";
            this.txtboxExam1.Size = new System.Drawing.Size(118, 20);
            this.txtboxExam1.TabIndex = 6;
            // 
            // lblProject1
            // 
            this.lblProject1.AutoSize = true;
            this.lblProject1.Location = new System.Drawing.Point(12, 40);
            this.lblProject1.Name = "lblProject1";
            this.lblProject1.Size = new System.Drawing.Size(52, 13);
            this.lblProject1.TabIndex = 7;
            this.lblProject1.Text = "Project 1:";
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.AutoSize = true;
            this.lblQuiz1.Location = new System.Drawing.Point(13, 90);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(40, 13);
            this.lblQuiz1.TabIndex = 8;
            this.lblQuiz1.Text = "Quiz 1:";
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Location = new System.Drawing.Point(13, 137);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(45, 13);
            this.lblExam1.TabIndex = 9;
            this.lblExam1.Text = "Exam 1:";
            // 
            // lblMaxProject1
            // 
            this.lblMaxProject1.AutoSize = true;
            this.lblMaxProject1.Location = new System.Drawing.Point(223, 62);
            this.lblMaxProject1.Name = "lblMaxProject1";
            this.lblMaxProject1.Size = new System.Drawing.Size(19, 13);
            this.lblMaxProject1.TabIndex = 11;
            this.lblMaxProject1.Text = "50";
            // 
            // lblMaxQuiz
            // 
            this.lblMaxQuiz.AutoSize = true;
            this.lblMaxQuiz.Location = new System.Drawing.Point(223, 109);
            this.lblMaxQuiz.Name = "lblMaxQuiz";
            this.lblMaxQuiz.Size = new System.Drawing.Size(19, 13);
            this.lblMaxQuiz.TabIndex = 12;
            this.lblMaxQuiz.Text = "15";
            // 
            // lblMaxExam1
            // 
            this.lblMaxExam1.AutoSize = true;
            this.lblMaxExam1.Location = new System.Drawing.Point(217, 156);
            this.lblMaxExam1.Name = "lblMaxExam1";
            this.lblMaxExam1.Size = new System.Drawing.Size(25, 13);
            this.lblMaxExam1.TabIndex = 13;
            this.lblMaxExam1.Text = "100";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(207, 9);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(58, 13);
            this.lblMaxScore.TabIndex = 10;
            this.lblMaxScore.Text = "Max Score";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(9, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(92, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter your scores:";
            // 
            // txtboxFinalGrade
            // 
            this.txtboxFinalGrade.Location = new System.Drawing.Point(12, 200);
            this.txtboxFinalGrade.Name = "txtboxFinalGrade";
            this.txtboxFinalGrade.ReadOnly = true;
            this.txtboxFinalGrade.Size = new System.Drawing.Size(244, 20);
            this.txtboxFinalGrade.TabIndex = 14;
            // 
            // lblGradeLetter
            // 
            this.lblGradeLetter.AutoSize = true;
            this.lblGradeLetter.Location = new System.Drawing.Point(110, 184);
            this.lblGradeLetter.Name = "lblGradeLetter";
            this.lblGradeLetter.Size = new System.Drawing.Size(64, 13);
            this.lblGradeLetter.TabIndex = 15;
            this.lblGradeLetter.Text = "Final Grade:";
            // 
            // LetterGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 318);
            this.Controls.Add(this.lblGradeLetter);
            this.Controls.Add(this.txtboxFinalGrade);
            this.Controls.Add(this.lblMaxExam1);
            this.Controls.Add(this.lblMaxQuiz);
            this.Controls.Add(this.lblMaxProject1);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.lblExam1);
            this.Controls.Add(this.lblQuiz1);
            this.Controls.Add(this.lblProject1);
            this.Controls.Add(this.txtboxExam1);
            this.Controls.Add(this.txtboxQuiz1);
            this.Controls.Add(this.txtboxProject1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGradeCalculate);
            this.Controls.Add(this.lblInstructions);
            this.Name = "LetterGradeForm";
            this.Text = "Letter Grade Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGradeCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtboxProject1;
        private System.Windows.Forms.TextBox txtboxQuiz1;
        private System.Windows.Forms.TextBox txtboxExam1;
        private System.Windows.Forms.Label lblProject1;
        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.Label lblMaxProject1;
        private System.Windows.Forms.Label lblMaxQuiz;
        private System.Windows.Forms.Label lblMaxExam1;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtboxFinalGrade;
        private System.Windows.Forms.Label lblGradeLetter;

    }
}