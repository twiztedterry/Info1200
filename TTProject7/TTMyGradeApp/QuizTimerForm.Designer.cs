namespace TTMyGradeApp
{
    partial class QuizTimerForm
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
            this.grpboxCountDirection = new System.Windows.Forms.GroupBox();
            this.radiobtnDown = new System.Windows.Forms.RadioButton();
            this.radiobtnUp = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblSecondBox = new System.Windows.Forms.Label();
            this.chkboxAlarm = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxSeconds = new System.Windows.Forms.TextBox();
            this.grpboxCountDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxCountDirection
            // 
            this.grpboxCountDirection.Controls.Add(this.radiobtnDown);
            this.grpboxCountDirection.Controls.Add(this.radiobtnUp);
            this.grpboxCountDirection.Location = new System.Drawing.Point(12, 89);
            this.grpboxCountDirection.Name = "grpboxCountDirection";
            this.grpboxCountDirection.Size = new System.Drawing.Size(98, 88);
            this.grpboxCountDirection.TabIndex = 4;
            this.grpboxCountDirection.TabStop = false;
            this.grpboxCountDirection.Text = "Count Direction:";
            // 
            // radiobtnDown
            // 
            this.radiobtnDown.AutoSize = true;
            this.radiobtnDown.Location = new System.Drawing.Point(6, 56);
            this.radiobtnDown.Name = "radiobtnDown";
            this.radiobtnDown.Size = new System.Drawing.Size(53, 17);
            this.radiobtnDown.TabIndex = 0;
            this.radiobtnDown.Text = "Down";
            this.radiobtnDown.UseVisualStyleBackColor = true;
            // 
            // radiobtnUp
            // 
            this.radiobtnUp.AutoSize = true;
            this.radiobtnUp.Checked = true;
            this.radiobtnUp.Location = new System.Drawing.Point(6, 23);
            this.radiobtnUp.Name = "radiobtnUp";
            this.radiobtnUp.Size = new System.Drawing.Size(39, 17);
            this.radiobtnUp.TabIndex = 1;
            this.radiobtnUp.TabStop = true;
            this.radiobtnUp.Text = "Up";
            this.radiobtnUp.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(126, 30);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 24);
            this.lblTimer.TabIndex = 5;
            // 
            // lblSecondBox
            // 
            this.lblSecondBox.AutoSize = true;
            this.lblSecondBox.Location = new System.Drawing.Point(17, 16);
            this.lblSecondBox.Name = "lblSecondBox";
            this.lblSecondBox.Size = new System.Drawing.Size(93, 13);
            this.lblSecondBox.TabIndex = 6;
            this.lblSecondBox.Text = "Time: (in seconds)";
            // 
            // chkboxAlarm
            // 
            this.chkboxAlarm.AutoSize = true;
            this.chkboxAlarm.Location = new System.Drawing.Point(19, 59);
            this.chkboxAlarm.Name = "chkboxAlarm";
            this.chkboxAlarm.Size = new System.Drawing.Size(86, 17);
            this.chkboxAlarm.TabIndex = 7;
            this.chkboxAlarm.Text = "Sound Alarm";
            this.chkboxAlarm.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(116, 95);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(116, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(116, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxSeconds
            // 
            this.txtboxSeconds.Location = new System.Drawing.Point(12, 32);
            this.txtboxSeconds.Name = "txtboxSeconds";
            this.txtboxSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtboxSeconds.TabIndex = 0;
            // 
            // QuizTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 196);
            this.Controls.Add(this.txtboxSeconds);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkboxAlarm);
            this.Controls.Add(this.lblSecondBox);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.grpboxCountDirection);
            this.Name = "QuizTimerForm";
            this.Text = "Quiz Timer";
            this.grpboxCountDirection.ResumeLayout(false);
            this.grpboxCountDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxCountDirection;
        private System.Windows.Forms.RadioButton radiobtnDown;
        private System.Windows.Forms.RadioButton radiobtnUp;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblSecondBox;
        private System.Windows.Forms.CheckBox chkboxAlarm;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxSeconds;
    }
}