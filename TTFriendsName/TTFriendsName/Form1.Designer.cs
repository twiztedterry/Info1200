namespace TTFriendsName
{
    partial class formFriendFile
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
            this.txtboxFriendsName = new System.Windows.Forms.TextBox();
            this.lblFriendsName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWriteName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxFriendsName
            // 
            this.txtboxFriendsName.Location = new System.Drawing.Point(132, 14);
            this.txtboxFriendsName.Name = "txtboxFriendsName";
            this.txtboxFriendsName.Size = new System.Drawing.Size(129, 20);
            this.txtboxFriendsName.TabIndex = 0;
            // 
            // lblFriendsName
            // 
            this.lblFriendsName.AutoSize = true;
            this.lblFriendsName.Location = new System.Drawing.Point(17, 17);
            this.lblFriendsName.Name = "lblFriendsName";
            this.lblFriendsName.Size = new System.Drawing.Size(109, 13);
            this.lblFriendsName.TabIndex = 1;
            this.lblFriendsName.Text = "Enter a friend\'s name:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWriteName
            // 
            this.btnWriteName.Location = new System.Drawing.Point(51, 42);
            this.btnWriteName.Name = "btnWriteName";
            this.btnWriteName.Size = new System.Drawing.Size(75, 23);
            this.btnWriteName.TabIndex = 3;
            this.btnWriteName.Text = "&Write Name";
            this.btnWriteName.UseVisualStyleBackColor = true;
            this.btnWriteName.Click += new System.EventHandler(this.btnWriteName_Click);
            // 
            // formFriendFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 68);
            this.Controls.Add(this.btnWriteName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFriendsName);
            this.Controls.Add(this.txtboxFriendsName);
            this.Name = "formFriendFile";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFriendsName;
        private System.Windows.Forms.Label lblFriendsName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWriteName;
    }
}

