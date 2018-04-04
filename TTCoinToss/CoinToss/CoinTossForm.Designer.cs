namespace CoinToss
{
    partial class CoinTossForm
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
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnToss5times = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.listboxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(83, 237);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 31);
            this.btnFlip.TabIndex = 11;
            this.btnFlip.Text = "Flip Once";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(153, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnToss5times
            // 
            this.btnToss5times.Location = new System.Drawing.Point(59, 164);
            this.btnToss5times.Name = "btnToss5times";
            this.btnToss5times.Size = new System.Drawing.Size(120, 38);
            this.btnToss5times.TabIndex = 8;
            this.btnToss5times.Text = "Toss Coin 5 Times";
            this.btnToss5times.UseVisualStyleBackColor = true;
            this.btnToss5times.Click += new System.EventHandler(this.btnToss5times_Click);
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Location = new System.Drawing.Point(56, 17);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(66, 13);
            this.lblCoin.TabIndex = 7;
            this.lblCoin.Text = "Toss Result:";
            // 
            // listboxResults
            // 
            this.listboxResults.FormattingEnabled = true;
            this.listboxResults.Location = new System.Drawing.Point(59, 33);
            this.listboxResults.Name = "listboxResults";
            this.listboxResults.Size = new System.Drawing.Size(120, 95);
            this.listboxResults.TabIndex = 6;
            // 
            // CoinTossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 304);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnToss5times);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.listboxResults);
            this.Name = "CoinTossForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnToss5times;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.ListBox listboxResults;
    }
}

