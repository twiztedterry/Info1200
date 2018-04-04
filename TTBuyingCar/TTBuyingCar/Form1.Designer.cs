namespace TTBuyingCar
{
    partial class Form1
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
            this.btnDesign = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.listboxColor = new System.Windows.Forms.ListBox();
            this.listboxMake = new System.Windows.Forms.ListBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.radiobuttonUsed = new System.Windows.Forms.RadioButton();
            this.radiobuttonNew = new System.Windows.Forms.RadioButton();
            this.txtboxResult = new System.Windows.Forms.RichTextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDesign
            // 
            this.btnDesign.Location = new System.Drawing.Point(80, 215);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(156, 34);
            this.btnDesign.TabIndex = 0;
            this.btnDesign.Text = "Design Car";
            this.btnDesign.UseVisualStyleBackColor = true;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(192, 30);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(102, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Choose a car make:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 30);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(81, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Choose a color:";
            // 
            // listboxColor
            // 
            this.listboxColor.FormattingEnabled = true;
            this.listboxColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Silver",
            "Green"});
            this.listboxColor.Location = new System.Drawing.Point(12, 46);
            this.listboxColor.Name = "listboxColor";
            this.listboxColor.Size = new System.Drawing.Size(120, 95);
            this.listboxColor.TabIndex = 3;
            // 
            // listboxMake
            // 
            this.listboxMake.FormattingEnabled = true;
            this.listboxMake.Items.AddRange(new object[] {
            "Subaru",
            "Prius",
            "Jeep",
            "Mini Cooper"});
            this.listboxMake.Location = new System.Drawing.Point(195, 46);
            this.listboxMake.Name = "listboxMake";
            this.listboxMake.Size = new System.Drawing.Size(120, 95);
            this.listboxMake.TabIndex = 4;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(12, 157);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(73, 13);
            this.lblCondition.TabIndex = 5;
            this.lblCondition.Text = "Car Condition:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(192, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Max Price:";
            // 
            // radiobuttonUsed
            // 
            this.radiobuttonUsed.AutoSize = true;
            this.radiobuttonUsed.Location = new System.Drawing.Point(15, 196);
            this.radiobuttonUsed.Name = "radiobuttonUsed";
            this.radiobuttonUsed.Size = new System.Drawing.Size(50, 17);
            this.radiobuttonUsed.TabIndex = 7;
            this.radiobuttonUsed.TabStop = true;
            this.radiobuttonUsed.Text = "Used";
            this.radiobuttonUsed.UseVisualStyleBackColor = true;
            // 
            // radiobuttonNew
            // 
            this.radiobuttonNew.AutoSize = true;
            this.radiobuttonNew.Location = new System.Drawing.Point(15, 173);
            this.radiobuttonNew.Name = "radiobuttonNew";
            this.radiobuttonNew.Size = new System.Drawing.Size(47, 17);
            this.radiobuttonNew.TabIndex = 8;
            this.radiobuttonNew.TabStop = true;
            this.radiobuttonNew.Text = "New";
            this.radiobuttonNew.UseVisualStyleBackColor = true;
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(12, 255);
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.ReadOnly = true;
            this.txtboxResult.Size = new System.Drawing.Size(303, 45);
            this.txtboxResult.TabIndex = 9;
            this.txtboxResult.Text = "";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(194, 173);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.radiobuttonNew);
            this.Controls.Add(this.radiobuttonUsed);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.listboxMake);
            this.Controls.Add(this.listboxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.btnDesign);
            this.Name = "Form1";
            this.Text = "Trevor\'s Buying a Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ListBox listboxColor;
        private System.Windows.Forms.ListBox listboxMake;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton radiobuttonUsed;
        private System.Windows.Forms.RadioButton radiobuttonNew;
        private System.Windows.Forms.RichTextBox txtboxResult;
        private System.Windows.Forms.TextBox txtboxPrice;
    }
}

