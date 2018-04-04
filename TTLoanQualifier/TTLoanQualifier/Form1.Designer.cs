namespace TTLoanQualifier
{
    partial class Form1
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
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tenureLabel = new System.Windows.Forms.Label();
            this.txtboxTenure = new System.Windows.Forms.TextBox();
            this.txtboxDecision = new System.Windows.Forms.TextBox();
            this.lblDecision = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.Location = new System.Drawing.Point(128, 34);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.Size = new System.Drawing.Size(100, 20);
            this.txtboxSalary.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(47, 37);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(75, 13);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Annual Salary:";
            // 
            // tenureLabel
            // 
            this.tenureLabel.AutoSize = true;
            this.tenureLabel.Location = new System.Drawing.Point(20, 63);
            this.tenureLabel.Name = "tenureLabel";
            this.tenureLabel.Size = new System.Drawing.Size(102, 13);
            this.tenureLabel.TabIndex = 3;
            this.tenureLabel.Text = "Years at current job:";
            // 
            // txtboxTenure
            // 
            this.txtboxTenure.Location = new System.Drawing.Point(128, 60);
            this.txtboxTenure.Name = "txtboxTenure";
            this.txtboxTenure.Size = new System.Drawing.Size(100, 20);
            this.txtboxTenure.TabIndex = 2;
            // 
            // txtboxDecision
            // 
            this.txtboxDecision.Location = new System.Drawing.Point(12, 112);
            this.txtboxDecision.Name = "txtboxDecision";
            this.txtboxDecision.ReadOnly = true;
            this.txtboxDecision.Size = new System.Drawing.Size(248, 20);
            this.txtboxDecision.TabIndex = 4;
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Location = new System.Drawing.Point(12, 96);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(78, 13);
            this.lblDecision.TabIndex = 5;
            this.lblDecision.Text = "Loan Decision:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 145);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 145);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(78, 36);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check &Qualifications";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.txtboxDecision);
            this.Controls.Add(this.tenureLabel);
            this.Controls.Add(this.txtboxTenure);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtboxSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label tenureLabel;
        private System.Windows.Forms.TextBox txtboxTenure;
        private System.Windows.Forms.TextBox txtboxDecision;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;

    }
}

