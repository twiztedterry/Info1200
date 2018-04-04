namespace TTPayroll
{
    partial class Payroll
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxHoursWorked = new System.Windows.Forms.TextBox();
            this.txtboxPayRate = new System.Windows.Forms.TextBox();
            this.txtboxGrossPay = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblOvertimeRate = new System.Windows.Forms.Label();
            this.comboOvertimeRate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxHoursWorked
            // 
            this.txtboxHoursWorked.Location = new System.Drawing.Point(197, 12);
            this.txtboxHoursWorked.Name = "txtboxHoursWorked";
            this.txtboxHoursWorked.Size = new System.Drawing.Size(75, 20);
            this.txtboxHoursWorked.TabIndex = 3;
            // 
            // txtboxPayRate
            // 
            this.txtboxPayRate.Location = new System.Drawing.Point(197, 38);
            this.txtboxPayRate.Name = "txtboxPayRate";
            this.txtboxPayRate.Size = new System.Drawing.Size(75, 20);
            this.txtboxPayRate.TabIndex = 4;
            // 
            // txtboxGrossPay
            // 
            this.txtboxGrossPay.Location = new System.Drawing.Point(197, 91);
            this.txtboxGrossPay.Name = "txtboxGrossPay";
            this.txtboxGrossPay.ReadOnly = true;
            this.txtboxGrossPay.Size = new System.Drawing.Size(75, 20);
            this.txtboxGrossPay.TabIndex = 5;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(112, 15);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 6;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(104, 41);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(87, 13);
            this.lblHourlyRate.TabIndex = 7;
            this.lblHourlyRate.Text = "Hourly Pay Rate:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(133, 94);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(58, 13);
            this.lblGrossPay.TabIndex = 8;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblOvertimeRate
            // 
            this.lblOvertimeRate.AutoSize = true;
            this.lblOvertimeRate.Location = new System.Drawing.Point(116, 67);
            this.lblOvertimeRate.Name = "lblOvertimeRate";
            this.lblOvertimeRate.Size = new System.Drawing.Size(78, 13);
            this.lblOvertimeRate.TabIndex = 9;
            this.lblOvertimeRate.Text = "Overtime Rate:";
            // 
            // comboOvertimeRate
            // 
            this.comboOvertimeRate.FormattingEnabled = true;
            this.comboOvertimeRate.Items.AddRange(new object[] {
            "Time + 1/2",
            "Time * 2",
            "Time * 3"});
            this.comboOvertimeRate.Location = new System.Drawing.Point(197, 64);
            this.comboOvertimeRate.Name = "comboOvertimeRate";
            this.comboOvertimeRate.Size = new System.Drawing.Size(76, 21);
            this.comboOvertimeRate.TabIndex = 10;
            // 
            // Payroll
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.comboOvertimeRate);
            this.Controls.Add(this.lblOvertimeRate);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.txtboxGrossPay);
            this.Controls.Add(this.txtboxPayRate);
            this.Controls.Add(this.txtboxHoursWorked);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Payroll";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxHoursWorked;
        private System.Windows.Forms.TextBox txtboxPayRate;
        private System.Windows.Forms.TextBox txtboxGrossPay;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblOvertimeRate;
        private System.Windows.Forms.ComboBox comboOvertimeRate;
        

    }
}

