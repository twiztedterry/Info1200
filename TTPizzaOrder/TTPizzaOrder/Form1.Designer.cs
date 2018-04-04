namespace TTPizzaOrder
{
    partial class PizzaOrderForm
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
            this.grpboxToppings = new System.Windows.Forms.GroupBox();
            this.grpboxCrust = new System.Windows.Forms.GroupBox();
            this.radiobtnPan = new System.Windows.Forms.RadioButton();
            this.radiobtnThin = new System.Windows.Forms.RadioButton();
            this.chkboxCheese = new System.Windows.Forms.CheckBox();
            this.chkboxPepperoni = new System.Windows.Forms.CheckBox();
            this.chkboxPineapple = new System.Windows.Forms.CheckBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.listboxCity = new System.Windows.Forms.ListBox();
            this.txtboxOrder = new System.Windows.Forms.RichTextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpboxToppings.SuspendLayout();
            this.grpboxCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxToppings
            // 
            this.grpboxToppings.Controls.Add(this.chkboxPineapple);
            this.grpboxToppings.Controls.Add(this.chkboxPepperoni);
            this.grpboxToppings.Controls.Add(this.chkboxCheese);
            this.grpboxToppings.Location = new System.Drawing.Point(12, 12);
            this.grpboxToppings.Name = "grpboxToppings";
            this.grpboxToppings.Size = new System.Drawing.Size(135, 95);
            this.grpboxToppings.TabIndex = 0;
            this.grpboxToppings.TabStop = false;
            this.grpboxToppings.Text = "Toppings";
            // 
            // grpboxCrust
            // 
            this.grpboxCrust.Controls.Add(this.radiobtnThin);
            this.grpboxCrust.Controls.Add(this.radiobtnPan);
            this.grpboxCrust.Location = new System.Drawing.Point(153, 12);
            this.grpboxCrust.Name = "grpboxCrust";
            this.grpboxCrust.Size = new System.Drawing.Size(134, 95);
            this.grpboxCrust.TabIndex = 1;
            this.grpboxCrust.TabStop = false;
            this.grpboxCrust.Text = "Crust";
            // 
            // radiobtnPan
            // 
            this.radiobtnPan.AutoSize = true;
            this.radiobtnPan.Checked = true;
            this.radiobtnPan.Location = new System.Drawing.Point(7, 20);
            this.radiobtnPan.Name = "radiobtnPan";
            this.radiobtnPan.Size = new System.Drawing.Size(44, 17);
            this.radiobtnPan.TabIndex = 0;
            this.radiobtnPan.TabStop = true;
            this.radiobtnPan.Text = "Pan";
            this.radiobtnPan.UseVisualStyleBackColor = true;
            // 
            // radiobtnThin
            // 
            this.radiobtnThin.AutoSize = true;
            this.radiobtnThin.Location = new System.Drawing.Point(7, 45);
            this.radiobtnThin.Name = "radiobtnThin";
            this.radiobtnThin.Size = new System.Drawing.Size(46, 17);
            this.radiobtnThin.TabIndex = 2;
            this.radiobtnThin.Text = "Thin";
            this.radiobtnThin.UseVisualStyleBackColor = true;
            // 
            // chkboxCheese
            // 
            this.chkboxCheese.AutoSize = true;
            this.chkboxCheese.Location = new System.Drawing.Point(7, 20);
            this.chkboxCheese.Name = "chkboxCheese";
            this.chkboxCheese.Size = new System.Drawing.Size(62, 17);
            this.chkboxCheese.TabIndex = 0;
            this.chkboxCheese.Text = "Cheese";
            this.chkboxCheese.UseVisualStyleBackColor = true;
            // 
            // chkboxPepperoni
            // 
            this.chkboxPepperoni.AutoSize = true;
            this.chkboxPepperoni.Location = new System.Drawing.Point(7, 45);
            this.chkboxPepperoni.Name = "chkboxPepperoni";
            this.chkboxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkboxPepperoni.TabIndex = 1;
            this.chkboxPepperoni.Text = "Pepperoni";
            this.chkboxPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkboxPineapple
            // 
            this.chkboxPineapple.AutoSize = true;
            this.chkboxPineapple.Location = new System.Drawing.Point(7, 68);
            this.chkboxPineapple.Name = "chkboxPineapple";
            this.chkboxPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkboxPineapple.TabIndex = 2;
            this.chkboxPineapple.Text = "Pineapple";
            this.chkboxPineapple.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Deliver To:";
            // 
            // listboxCity
            // 
            this.listboxCity.FormattingEnabled = true;
            this.listboxCity.Items.AddRange(new object[] {
            "Orem",
            "American Fork",
            "Provo",
            "Lehi"});
            this.listboxCity.Location = new System.Drawing.Point(12, 150);
            this.listboxCity.Name = "listboxCity";
            this.listboxCity.Size = new System.Drawing.Size(120, 56);
            this.listboxCity.TabIndex = 3;
            // 
            // txtboxOrder
            // 
            this.txtboxOrder.Location = new System.Drawing.Point(12, 212);
            this.txtboxOrder.Name = "txtboxOrder";
            this.txtboxOrder.ReadOnly = true;
            this.txtboxOrder.Size = new System.Drawing.Size(275, 39);
            this.txtboxOrder.TabIndex = 4;
            this.txtboxOrder.Text = "";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(138, 114);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(162, 36);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "&Send Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(138, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(225, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 263);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtboxOrder);
            this.Controls.Add(this.listboxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.grpboxCrust);
            this.Controls.Add(this.grpboxToppings);
            this.Name = "PizzaOrderForm";
            this.Text = "Trevor\'s Pizza Order";
            this.grpboxToppings.ResumeLayout(false);
            this.grpboxToppings.PerformLayout();
            this.grpboxCrust.ResumeLayout(false);
            this.grpboxCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxToppings;
        private System.Windows.Forms.CheckBox chkboxPineapple;
        private System.Windows.Forms.CheckBox chkboxPepperoni;
        private System.Windows.Forms.CheckBox chkboxCheese;
        private System.Windows.Forms.GroupBox grpboxCrust;
        private System.Windows.Forms.RadioButton radiobtnThin;
        private System.Windows.Forms.RadioButton radiobtnPan;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ListBox listboxCity;
        private System.Windows.Forms.RichTextBox txtboxOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

