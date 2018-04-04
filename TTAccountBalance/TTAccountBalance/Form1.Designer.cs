namespace TTAccountBalance
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
            this.lblStartingBalance = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtboxStartingBalance = new System.Windows.Forms.TextBox();
            this.datetimeSave = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalcLog = new System.Windows.Forms.Label();
            this.listboxDetails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStartingBalance
            // 
            this.lblStartingBalance.AutoSize = true;
            this.lblStartingBalance.Location = new System.Drawing.Point(15, 41);
            this.lblStartingBalance.Name = "lblStartingBalance";
            this.lblStartingBalance.Size = new System.Drawing.Size(88, 13);
            this.lblStartingBalance.TabIndex = 0;
            this.lblStartingBalance.Text = "Starting Balance:";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(15, 13);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(338, 13);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "Please enter a starting balance, and select the date you will save until:";
            // 
            // txtboxStartingBalance
            // 
            this.txtboxStartingBalance.Location = new System.Drawing.Point(18, 57);
            this.txtboxStartingBalance.Name = "txtboxStartingBalance";
            this.txtboxStartingBalance.Size = new System.Drawing.Size(100, 20);
            this.txtboxStartingBalance.TabIndex = 2;
            // 
            // datetimeSave
            // 
            this.datetimeSave.Location = new System.Drawing.Point(18, 110);
            this.datetimeSave.Name = "datetimeSave";
            this.datetimeSave.Size = new System.Drawing.Size(183, 20);
            this.datetimeSave.TabIndex = 3;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(18, 91);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(118, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Date you will save until:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(273, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 293);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalcLog
            // 
            this.lblCalcLog.AutoSize = true;
            this.lblCalcLog.Location = new System.Drawing.Point(18, 146);
            this.lblCalcLog.Name = "lblCalcLog";
            this.lblCalcLog.Size = new System.Drawing.Size(97, 13);
            this.lblCalcLog.TabIndex = 9;
            this.lblCalcLog.Text = "Calculation Details:";
            // 
            // listboxDetails
            // 
            this.listboxDetails.FormattingEnabled = true;
            this.listboxDetails.Location = new System.Drawing.Point(12, 163);
            this.listboxDetails.Name = "listboxDetails";
            this.listboxDetails.Size = new System.Drawing.Size(336, 121);
            this.listboxDetails.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 328);
            this.Controls.Add(this.listboxDetails);
            this.Controls.Add(this.lblCalcLog);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.datetimeSave);
            this.Controls.Add(this.txtboxStartingBalance);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblStartingBalance);
            this.Name = "Form1";
            this.Text = "Trevor\'s Account Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartingBalance;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox txtboxStartingBalance;
        private System.Windows.Forms.DateTimePicker datetimeSave;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalcLog;
        private System.Windows.Forms.ListBox listboxDetails;
    }
}

