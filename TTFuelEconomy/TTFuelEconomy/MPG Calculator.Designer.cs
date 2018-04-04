namespace TTFuelEconomy
{
    partial class formMPG
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
            this.lblMilesTravelled = new System.Windows.Forms.Label();
            this.lblGallonsUsed = new System.Windows.Forms.Label();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxGallons = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateMPG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMilesTravelled
            // 
            this.lblMilesTravelled.AutoSize = true;
            this.lblMilesTravelled.Location = new System.Drawing.Point(12, 46);
            this.lblMilesTravelled.Name = "lblMilesTravelled";
            this.lblMilesTravelled.Size = new System.Drawing.Size(81, 13);
            this.lblMilesTravelled.TabIndex = 0;
            this.lblMilesTravelled.Text = "Miles Travelled:";
            // 
            // lblGallonsUsed
            // 
            this.lblGallonsUsed.AutoSize = true;
            this.lblGallonsUsed.Location = new System.Drawing.Point(113, 46);
            this.lblGallonsUsed.Name = "lblGallonsUsed";
            this.lblGallonsUsed.Size = new System.Drawing.Size(73, 13);
            this.lblGallonsUsed.TabIndex = 1;
            this.lblGallonsUsed.Text = "Gallons Used:";
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Location = new System.Drawing.Point(15, 62);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.Size = new System.Drawing.Size(75, 20);
            this.textBoxMiles.TabIndex = 2;
            // 
            // textBoxGallons
            // 
            this.textBoxGallons.Location = new System.Drawing.Point(116, 63);
            this.textBoxGallons.Name = "textBoxGallons";
            this.textBoxGallons.Size = new System.Drawing.Size(67, 20);
            this.textBoxGallons.TabIndex = 3;
            // 
            // lblMPG
            // 
            this.lblMPG.AutoSize = true;
            this.lblMPG.Location = new System.Drawing.Point(41, 88);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(124, 13);
            this.lblMPG.TabIndex = 4;
            this.lblMPG.Text = "Average Mile Per Gallon:";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(74, 104);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(55, 20);
            this.textBoxResults.TabIndex = 5;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 21);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(111, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateMPG
            // 
            this.btnCalculateMPG.Location = new System.Drawing.Point(15, 140);
            this.btnCalculateMPG.Name = "btnCalculateMPG";
            this.btnCalculateMPG.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateMPG.TabIndex = 8;
            this.btnCalculateMPG.Text = "Calculate";
            this.btnCalculateMPG.UseVisualStyleBackColor = true;
            this.btnCalculateMPG.Click += new System.EventHandler(this.btnCalculateMPG_Click);
            // 
            // formMPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 175);
            this.Controls.Add(this.btnCalculateMPG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.textBoxGallons);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.lblGallonsUsed);
            this.Controls.Add(this.lblMilesTravelled);
            this.Name = "formMPG";
            this.Text = "MPG Calculator";
            this.Load += new System.EventHandler(this.formMPG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesTravelled;
        private System.Windows.Forms.Label lblGallonsUsed;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.TextBox textBoxGallons;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateMPG;
    }
}

