namespace TestScores
{
    partial class testscoreForm
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
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.Location = new System.Drawing.Point(26, 59);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(79, 121);
            this.scoreListBox.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(23, 28);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(64, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Test Scores";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(136, 59);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 59);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Score";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(271, 116);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(129, 23);
            this.averageButton.TabIndex = 4;
            this.averageButton.Text = "Average Scores";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(136, 120);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 23);
            this.averageLabel.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(26, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear ListBox";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(158, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // testscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.scoreListBox);
            this.Name = "testscoreForm";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

