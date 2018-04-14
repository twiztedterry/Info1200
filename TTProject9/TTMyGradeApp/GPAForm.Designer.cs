namespace TTMyGradeApp
{
    partial class GPAForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxGPA = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Current GPA is:";
            // 
            // txtboxGPA
            // 
            this.txtboxGPA.Enabled = false;
            this.txtboxGPA.Location = new System.Drawing.Point(133, 23);
            this.txtboxGPA.Name = "txtboxGPA";
            this.txtboxGPA.Size = new System.Drawing.Size(55, 20);
            this.txtboxGPA.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(75, 71);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 29);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // GPAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 115);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.txtboxGPA);
            this.Controls.Add(this.label1);
            this.Name = "GPAForm";
            this.ShowIcon = false;
            this.Text = "G.P.A. Calculator";
            this.Load += new System.EventHandler(this.GPAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxGPA;
        private System.Windows.Forms.Button buttonClose;
    }
}