namespace CellPhone
{
    partial class cellPhoneForm
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
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.createPhoneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.resultPriceLabel = new System.Windows.Forms.Label();
            this.resultModelLabel = new System.Windows.Forms.Label();
            this.resultBrandLabel = new System.Windows.Forms.Label();
            this.priceObjLabel = new System.Windows.Forms.Label();
            this.modelObjLabel = new System.Windows.Forms.Label();
            this.brandObjLabel = new System.Windows.Forms.Label();
            this.dataGroupBox.SuspendLayout();
            this.objectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.priceTextBox);
            this.dataGroupBox.Controls.Add(this.modelTextBox);
            this.dataGroupBox.Controls.Add(this.brandTextBox);
            this.dataGroupBox.Controls.Add(this.priceLabel);
            this.dataGroupBox.Controls.Add(this.modelLabel);
            this.dataGroupBox.Controls.Add(this.brandLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(31, 25);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(192, 152);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Enter Cell Phone Data";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(75, 99);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(75, 60);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(75, 25);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 63);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(7, 33);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand";
            // 
            // createPhoneButton
            // 
            this.createPhoneButton.Location = new System.Drawing.Point(70, 340);
            this.createPhoneButton.Name = "createPhoneButton";
            this.createPhoneButton.Size = new System.Drawing.Size(123, 34);
            this.createPhoneButton.TabIndex = 1;
            this.createPhoneButton.Text = "Create Phone";
            this.createPhoneButton.UseVisualStyleBackColor = true;
            this.createPhoneButton.Click += new System.EventHandler(this.createPhoneButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(89, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.resultPriceLabel);
            this.objectGroupBox.Controls.Add(this.resultModelLabel);
            this.objectGroupBox.Controls.Add(this.resultBrandLabel);
            this.objectGroupBox.Controls.Add(this.priceObjLabel);
            this.objectGroupBox.Controls.Add(this.modelObjLabel);
            this.objectGroupBox.Controls.Add(this.brandObjLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(31, 200);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Size = new System.Drawing.Size(192, 134);
            this.objectGroupBox.TabIndex = 3;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // resultPriceLabel
            // 
            this.resultPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPriceLabel.Location = new System.Drawing.Point(83, 99);
            this.resultPriceLabel.Name = "resultPriceLabel";
            this.resultPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.resultPriceLabel.TabIndex = 5;
            // 
            // resultModelLabel
            // 
            this.resultModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultModelLabel.Location = new System.Drawing.Point(83, 61);
            this.resultModelLabel.Name = "resultModelLabel";
            this.resultModelLabel.Size = new System.Drawing.Size(100, 23);
            this.resultModelLabel.TabIndex = 4;
            // 
            // resultBrandLabel
            // 
            this.resultBrandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBrandLabel.Location = new System.Drawing.Point(83, 23);
            this.resultBrandLabel.Name = "resultBrandLabel";
            this.resultBrandLabel.Size = new System.Drawing.Size(100, 23);
            this.resultBrandLabel.TabIndex = 3;
            // 
            // priceObjLabel
            // 
            this.priceObjLabel.AutoSize = true;
            this.priceObjLabel.Location = new System.Drawing.Point(7, 104);
            this.priceObjLabel.Name = "priceObjLabel";
            this.priceObjLabel.Size = new System.Drawing.Size(31, 13);
            this.priceObjLabel.TabIndex = 2;
            this.priceObjLabel.Text = "Price";
            // 
            // modelObjLabel
            // 
            this.modelObjLabel.AutoSize = true;
            this.modelObjLabel.Location = new System.Drawing.Point(7, 63);
            this.modelObjLabel.Name = "modelObjLabel";
            this.modelObjLabel.Size = new System.Drawing.Size(36, 13);
            this.modelObjLabel.TabIndex = 1;
            this.modelObjLabel.Text = "Model";
            // 
            // brandObjLabel
            // 
            this.brandObjLabel.AutoSize = true;
            this.brandObjLabel.Location = new System.Drawing.Point(7, 26);
            this.brandObjLabel.Name = "brandObjLabel";
            this.brandObjLabel.Size = new System.Drawing.Size(35, 13);
            this.brandObjLabel.TabIndex = 0;
            this.brandObjLabel.Text = "Brand";
            // 
            // cellPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 427);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createPhoneButton);
            this.Controls.Add(this.dataGroupBox);
            this.Name = "cellPhoneForm";
            this.Text = "Cell Phone Test";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button createPhoneButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label resultPriceLabel;
        private System.Windows.Forms.Label resultModelLabel;
        private System.Windows.Forms.Label resultBrandLabel;
        private System.Windows.Forms.Label priceObjLabel;
        private System.Windows.Forms.Label modelObjLabel;
        private System.Windows.Forms.Label brandObjLabel;
    }
}

