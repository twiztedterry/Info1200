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
            this.grpBoxAcademic = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpboxStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtboxGradYear = new System.Windows.Forms.TextBox();
            this.lblGradYear = new System.Windows.Forms.Label();
            this.btnPicSwitch = new System.Windows.Forms.Button();
            this.pictureboxRight = new System.Windows.Forms.PictureBox();
            this.pictureboxLeft = new System.Windows.Forms.PictureBox();
            this.grpBoxAcademic.SuspendLayout();
            this.grpboxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(9, 33);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(122, 20);
            this.txtboxFName.TabIndex = 1;
            // 
            // txtboxLName
            // 
            this.txtboxLName.Location = new System.Drawing.Point(137, 32);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(122, 20);
            this.txtboxLName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(134, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(9, 72);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(250, 20);
            this.txtboxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Preferred Email:";
            // 
            // txtboxMajor
            // 
            this.txtboxMajor.Location = new System.Drawing.Point(9, 34);
            this.txtboxMajor.Name = "txtboxMajor";
            this.txtboxMajor.Size = new System.Drawing.Size(250, 20);
            this.txtboxMajor.TabIndex = 7;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(6, 16);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(36, 13);
            this.lblMajor.TabIndex = 6;
            this.lblMajor.Text = "Major:";
            // 
            // grpBoxAcademic
            // 
            this.grpBoxAcademic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpBoxAcademic.Controls.Add(this.lblGradYear);
            this.grpBoxAcademic.Controls.Add(this.txtboxGradYear);
            this.grpBoxAcademic.Controls.Add(this.lblMajor);
            this.grpBoxAcademic.Controls.Add(this.txtboxMajor);
            this.grpBoxAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAcademic.Location = new System.Drawing.Point(12, 134);
            this.grpBoxAcademic.Name = "grpBoxAcademic";
            this.grpBoxAcademic.Size = new System.Drawing.Size(271, 105);
            this.grpBoxAcademic.TabIndex = 10;
            this.grpBoxAcademic.TabStop = false;
            this.grpBoxAcademic.Text = "Academic Information";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(464, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpboxStudentInfo
            // 
            this.grpboxStudentInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpboxStudentInfo.Controls.Add(this.lblFirstName);
            this.grpboxStudentInfo.Controls.Add(this.txtboxEmail);
            this.grpboxStudentInfo.Controls.Add(this.txtboxFName);
            this.grpboxStudentInfo.Controls.Add(this.lblEmail);
            this.grpboxStudentInfo.Controls.Add(this.lblLastName);
            this.grpboxStudentInfo.Controls.Add(this.txtboxLName);
            this.grpboxStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.grpboxStudentInfo.Name = "grpboxStudentInfo";
            this.grpboxStudentInfo.Size = new System.Drawing.Size(271, 106);
            this.grpboxStudentInfo.TabIndex = 13;
            this.grpboxStudentInfo.TabStop = false;
            this.grpboxStudentInfo.Text = "Student Information";
            // 
            // txtboxGradYear
            // 
            this.txtboxGradYear.Location = new System.Drawing.Point(9, 72);
            this.txtboxGradYear.Name = "txtboxGradYear";
            this.txtboxGradYear.Size = new System.Drawing.Size(250, 20);
            this.txtboxGradYear.TabIndex = 8;
            // 
            // lblGradYear
            // 
            this.lblGradYear.AutoSize = true;
            this.lblGradYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradYear.Location = new System.Drawing.Point(6, 56);
            this.lblGradYear.Name = "lblGradYear";
            this.lblGradYear.Size = new System.Drawing.Size(84, 13);
            this.lblGradYear.TabIndex = 9;
            this.lblGradYear.Text = "Graduation Year";
            // 
            // btnPicSwitch
            // 
            this.btnPicSwitch.Location = new System.Drawing.Point(381, 184);
            this.btnPicSwitch.Name = "btnPicSwitch";
            this.btnPicSwitch.Size = new System.Drawing.Size(77, 28);
            this.btnPicSwitch.TabIndex = 16;
            this.btnPicSwitch.Text = "Use Photo 2";
            this.btnPicSwitch.UseVisualStyleBackColor = true;
            this.btnPicSwitch.Click += new System.EventHandler(this.btnPicSwitch_Click);
            // 
            // pictureboxRight
            // 
            this.pictureboxRight.Image = global::TTMyGradeApp.Properties.Resources.Picture1;
            this.pictureboxRight.Location = new System.Drawing.Point(368, 28);
            this.pictureboxRight.Name = "pictureboxRight";
            this.pictureboxRight.Size = new System.Drawing.Size(100, 150);
            this.pictureboxRight.TabIndex = 15;
            this.pictureboxRight.TabStop = false;
            this.pictureboxRight.Visible = false;
            // 
            // pictureboxLeft
            // 
            this.pictureboxLeft.Image = global::TTMyGradeApp.Properties.Resources._970558_10151463193441966_1762102111_n;
            this.pictureboxLeft.Location = new System.Drawing.Point(368, 28);
            this.pictureboxLeft.Name = "pictureboxLeft";
            this.pictureboxLeft.Size = new System.Drawing.Size(100, 150);
            this.pictureboxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxLeft.TabIndex = 14;
            this.pictureboxLeft.TabStop = false;
            // 
            // studentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 252);
            this.Controls.Add(this.btnPicSwitch);
            this.Controls.Add(this.pictureboxRight);
            this.Controls.Add(this.pictureboxLeft);
            this.Controls.Add(this.grpboxStudentInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxAcademic);
            this.Name = "studentProfileForm";
            this.Text = "Student Profile";
            this.grpBoxAcademic.ResumeLayout(false);
            this.grpBoxAcademic.PerformLayout();
            this.grpboxStudentInfo.ResumeLayout(false);
            this.grpboxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLeft)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBoxAcademic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpboxStudentInfo;
        private System.Windows.Forms.Label lblGradYear;
        private System.Windows.Forms.TextBox txtboxGradYear;
        private System.Windows.Forms.PictureBox pictureboxLeft;
        private System.Windows.Forms.PictureBox pictureboxRight;
        private System.Windows.Forms.Button btnPicSwitch;
    }
}