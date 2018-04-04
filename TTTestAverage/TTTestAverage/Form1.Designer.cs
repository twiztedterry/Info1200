namespace TTTestAverage
{
    partial class formTestAverage
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.txtboxTest1 = new System.Windows.Forms.TextBox();
            this.txtboxTest3 = new System.Windows.Forms.TextBox();
            this.txtboxTest2 = new System.Windows.Forms.TextBox();
            this.txtboxAverageScore = new System.Windows.Forms.TextBox();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(48, 38);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(40, 13);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test 1:";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(48, 61);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(40, 13);
            this.lblTest2.TabIndex = 1;
            this.lblTest2.Text = "Test 2:";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(48, 85);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(40, 13);
            this.lblTest3.TabIndex = 2;
            this.lblTest3.Text = "Test 3:";
            // 
            // txtboxTest1
            // 
            this.txtboxTest1.Location = new System.Drawing.Point(94, 35);
            this.txtboxTest1.Name = "txtboxTest1";
            this.txtboxTest1.Size = new System.Drawing.Size(100, 20);
            this.txtboxTest1.TabIndex = 3;
            // 
            // txtboxTest3
            // 
            this.txtboxTest3.Location = new System.Drawing.Point(94, 82);
            this.txtboxTest3.Name = "txtboxTest3";
            this.txtboxTest3.Size = new System.Drawing.Size(100, 20);
            this.txtboxTest3.TabIndex = 5;
            // 
            // txtboxTest2
            // 
            this.txtboxTest2.Location = new System.Drawing.Point(94, 58);
            this.txtboxTest2.Name = "txtboxTest2";
            this.txtboxTest2.Size = new System.Drawing.Size(100, 20);
            this.txtboxTest2.TabIndex = 4;
            // 
            // txtboxAverageScore
            // 
            this.txtboxAverageScore.Location = new System.Drawing.Point(129, 120);
            this.txtboxAverageScore.Name = "txtboxAverageScore";
            this.txtboxAverageScore.ReadOnly = true;
            this.txtboxAverageScore.Size = new System.Drawing.Size(100, 20);
            this.txtboxAverageScore.TabIndex = 6;
            this.txtboxAverageScore.TabStop = false;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(21, 123);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(102, 13);
            this.lblAverageScore.TabIndex = 7;
            this.lblAverageScore.Text = "Average Test Score";
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(12, 154);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(71, 36);
            this.btnCalculateAverage.TabIndex = 8;
            this.btnCalculateAverage.Text = "&Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(196, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(53, 22);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // formTestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 202);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.txtboxAverageScore);
            this.Controls.Add(this.txtboxTest2);
            this.Controls.Add(this.txtboxTest3);
            this.Controls.Add(this.txtboxTest1);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Name = "formTestAverage";
            this.Text = "Trevor\'s Test Average Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.TextBox txtboxTest1;
        private System.Windows.Forms.TextBox txtboxTest3;
        private System.Windows.Forms.TextBox txtboxTest2;
        private System.Windows.Forms.TextBox txtboxAverageScore;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
    }
}

