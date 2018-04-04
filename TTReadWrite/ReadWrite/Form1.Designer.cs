namespace ReadWrite
{
    partial class writeReadForm
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
            this.countryLabel = new System.Windows.Forms.Label();
            this.writeListBox = new System.Windows.Forms.ListBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.readListBox = new System.Windows.Forms.ListBox();
            this.readButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(23, 28);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(135, 13);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Countries of South America";
            // 
            // writeListBox
            // 
            this.writeListBox.FormattingEnabled = true;
            this.writeListBox.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brazil",
            "Chile",
            "Columbia",
            "Ecuador",
            "Falkland Islands",
            "French Guiana",
            "Guyana",
            "Paraguay",
            "Peru",
            "Suriname",
            "Uruguay",
            "Venezuela"});
            this.writeListBox.Location = new System.Drawing.Point(38, 55);
            this.writeListBox.Name = "writeListBox";
            this.writeListBox.Size = new System.Drawing.Size(200, 108);
            this.writeListBox.TabIndex = 5;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(93, 177);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 0;
            this.writeButton.Text = "&Write to File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readListBox
            // 
            this.readListBox.FormattingEnabled = true;
            this.readListBox.Location = new System.Drawing.Point(303, 67);
            this.readListBox.Name = "readListBox";
            this.readListBox.Size = new System.Drawing.Size(170, 95);
            this.readListBox.TabIndex = 6;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(319, 177);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(142, 23);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "&Read from Default File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "Countries.txt";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(342, 206);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "&Select File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // writeReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.readListBox);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.writeListBox);
            this.Controls.Add(this.countryLabel);
            this.Name = "writeReadForm";
            this.Text = "Read and Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ListBox writeListBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.ListBox readListBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}

