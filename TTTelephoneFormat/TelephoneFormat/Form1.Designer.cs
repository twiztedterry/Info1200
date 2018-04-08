namespace TelephoneFormat
{
    partial class telephoneFormatForm
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.formattedLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.formatButton = new System.Windows.Forms.Button();
            this.instructions2Label = new System.Windows.Forms.Label();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.unformattedLabel = new System.Windows.Forms.Label();
            this.unformatButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.instructionsLabel.Location = new System.Drawing.Point(32, 19);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(221, 44);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a 10-digit number and I will format it as a telephone number.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(53, 66);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(167, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // formattedLabel
            // 
            this.formattedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formattedLabel.Location = new System.Drawing.Point(53, 114);
            this.formattedLabel.Name = "formattedLabel";
            this.formattedLabel.Size = new System.Drawing.Size(167, 23);
            this.formattedLabel.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(63, 92);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(148, 13);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Formatted Telephone Number";
            // 
            // formatButton
            // 
            this.formatButton.Location = new System.Drawing.Point(91, 152);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(75, 23);
            this.formatButton.TabIndex = 4;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // instructions2Label
            // 
            this.instructions2Label.Location = new System.Drawing.Point(308, 25);
            this.instructions2Label.Name = "instructions2Label";
            this.instructions2Label.Size = new System.Drawing.Size(170, 33);
            this.instructions2Label.TabIndex = 5;
            this.instructions2Label.Text = "Enter a formatted telephone number and I will unformat it.";
            this.instructions2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(308, 66);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(157, 20);
            this.telephoneTextBox.TabIndex = 6;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(308, 92);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(159, 13);
            this.telephoneLabel.TabIndex = 7;
            this.telephoneLabel.Text = "Unformatted Telephone Number";
            // 
            // unformattedLabel
            // 
            this.unformattedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unformattedLabel.Location = new System.Drawing.Point(313, 114);
            this.unformattedLabel.Name = "unformattedLabel";
            this.unformattedLabel.Size = new System.Drawing.Size(154, 23);
            this.unformattedLabel.TabIndex = 8;
            // 
            // unformatButton
            // 
            this.unformatButton.Location = new System.Drawing.Point(362, 152);
            this.unformatButton.Name = "unformatButton";
            this.unformatButton.Size = new System.Drawing.Size(75, 23);
            this.unformatButton.TabIndex = 9;
            this.unformatButton.Text = "Unformat";
            this.unformatButton.UseVisualStyleBackColor = true;
            this.unformatButton.Click += new System.EventHandler(this.unformatButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(178, 214);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // telephoneFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 257);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.unformatButton);
            this.Controls.Add(this.unformattedLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.instructions2Label);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.formattedLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "telephoneFormatForm";
            this.Text = "Telephone Format/Unformat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label formattedLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Label instructions2Label;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label unformattedLabel;
        private System.Windows.Forms.Button unformatButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

