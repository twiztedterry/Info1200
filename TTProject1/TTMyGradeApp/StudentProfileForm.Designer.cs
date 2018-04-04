namespace TTMyGradeApp
{
    partial class studentProfileForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxFName = new System.Windows.Forms.TextBox();
            this.txtboxLName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxMajor = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.grpBoxStudentName = new System.Windows.Forms.GroupBox();
            this.grpBoxContact = new System.Windows.Forms.GroupBox();
            this.grpBoxDegree = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxStudentName.SuspendLayout();
            this.grpBoxContact.SuspendLayout();
            this.grpBoxDegree.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(1, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First:";
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(4, 33);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(122, 20);
            this.txtboxFName.TabIndex = 1;
            // 
            // txtboxLName
            // 
            this.txtboxLName.Location = new System.Drawing.Point(132, 32);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(122, 20);
            this.txtboxLName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(129, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(30, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(4, 35);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(250, 20);
            this.txtboxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(1, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtboxMajor
            // 
            this.txtboxMajor.Location = new System.Drawing.Point(4, 34);
            this.txtboxMajor.Name = "txtboxMajor";
            this.txtboxMajor.Size = new System.Drawing.Size(250, 20);
            this.txtboxMajor.TabIndex = 7;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(1, 16);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(36, 13);
            this.lblMajor.TabIndex = 6;
            this.lblMajor.Text = "Major:";
            // 
            // grpBoxStudentName
            // 
            this.grpBoxStudentName.Controls.Add(this.lblFirstName);
            this.grpBoxStudentName.Controls.Add(this.txtboxFName);
            this.grpBoxStudentName.Controls.Add(this.lblLastName);
            this.grpBoxStudentName.Controls.Add(this.txtboxLName);
            this.grpBoxStudentName.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudentName.Name = "grpBoxStudentName";
            this.grpBoxStudentName.Size = new System.Drawing.Size(260, 61);
            this.grpBoxStudentName.TabIndex = 8;
            this.grpBoxStudentName.TabStop = false;
            this.grpBoxStudentName.Text = "Student Name";
            // 
            // grpBoxContact
            // 
            this.grpBoxContact.Controls.Add(this.txtboxEmail);
            this.grpBoxContact.Controls.Add(this.lblEmail);
            this.grpBoxContact.Location = new System.Drawing.Point(12, 80);
            this.grpBoxContact.Name = "grpBoxContact";
            this.grpBoxContact.Size = new System.Drawing.Size(260, 61);
            this.grpBoxContact.TabIndex = 9;
            this.grpBoxContact.TabStop = false;
            this.grpBoxContact.Text = "Contact Information";
            // 
            // grpBoxDegree
            // 
            this.grpBoxDegree.Controls.Add(this.lblMajor);
            this.grpBoxDegree.Controls.Add(this.txtboxMajor);
            this.grpBoxDegree.Location = new System.Drawing.Point(12, 148);
            this.grpBoxDegree.Name = "grpBoxDegree";
            this.grpBoxDegree.Size = new System.Drawing.Size(260, 60);
            this.grpBoxDegree.TabIndex = 10;
            this.grpBoxDegree.TabStop = false;
            this.grpBoxDegree.Text = "Degree Information";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // studentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxDegree);
            this.Controls.Add(this.grpBoxContact);
            this.Controls.Add(this.grpBoxStudentName);
            this.Name = "studentProfileForm";
            this.Text = "Student Profile";
            this.grpBoxStudentName.ResumeLayout(false);
            this.grpBoxStudentName.PerformLayout();
            this.grpBoxContact.ResumeLayout(false);
            this.grpBoxContact.PerformLayout();
            this.grpBoxDegree.ResumeLayout(false);
            this.grpBoxDegree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxFName;
        private System.Windows.Forms.TextBox txtboxLName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxMajor;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.GroupBox grpBoxStudentName;
        private System.Windows.Forms.GroupBox grpBoxContact;
        private System.Windows.Forms.GroupBox grpBoxDegree;
        private System.Windows.Forms.Button btnClose;
    }
}