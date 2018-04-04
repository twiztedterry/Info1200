namespace LotteryNumbers
{
    partial class lotteryForm
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();
            this.generateNumbersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstLabel.Location = new System.Drawing.Point(27, 25);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(54, 23);
            this.firstLabel.TabIndex = 0;
            // 
            // secondLabel
            // 
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondLabel.Location = new System.Drawing.Point(97, 25);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(50, 23);
            this.secondLabel.TabIndex = 1;
            // 
            // thirdLabel
            // 
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdLabel.Location = new System.Drawing.Point(163, 25);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(52, 23);
            this.thirdLabel.TabIndex = 2;
            // 
            // fourthLabel
            // 
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fourthLabel.Location = new System.Drawing.Point(234, 24);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(46, 23);
            this.fourthLabel.TabIndex = 3;
            // 
            // fifthLabel
            // 
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fifthLabel.Location = new System.Drawing.Point(299, 25);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(45, 23);
            this.fifthLabel.TabIndex = 4;
            // 
            // generateNumbersButton
            // 
            this.generateNumbersButton.Location = new System.Drawing.Point(45, 78);
            this.generateNumbersButton.Name = "generateNumbersButton";
            this.generateNumbersButton.Size = new System.Drawing.Size(116, 26);
            this.generateNumbersButton.TabIndex = 5;
            this.generateNumbersButton.Text = "Generate Numbers";
            this.generateNumbersButton.UseVisualStyleBackColor = true;
            this.generateNumbersButton.Click += new System.EventHandler(this.generateNumbersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(224, 78);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 140);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateNumbersButton);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "lotteryForm";
            this.Text = "Lottery Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
        private System.Windows.Forms.Button generateNumbersButton;
        private System.Windows.Forms.Button exitButton;
    }
}

