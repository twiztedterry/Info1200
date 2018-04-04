//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 1/12/2018
//Project #: 2
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace TTLanguageTranslator
{
    partial class LanguageTranslatorForm
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
            this.lblInstructionTitle = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnItalian = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructionTitle
            // 
            this.lblInstructionTitle.AutoSize = true;
            this.lblInstructionTitle.Location = new System.Drawing.Point(14, 28);
            this.lblInstructionTitle.Name = "lblInstructionTitle";
            this.lblInstructionTitle.Size = new System.Drawing.Size(246, 13);
            this.lblInstructionTitle.TabIndex = 0;
            this.lblInstructionTitle.Text = "Select a Language, and I will say \"Good Morning\".";
            // 
            // lblTranslation
            // 
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(5, 65);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(263, 23);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.Text = "Translation";
            // 
            // btnItalian
            // 
            this.btnItalian.Location = new System.Drawing.Point(5, 111);
            this.btnItalian.Name = "btnItalian";
            this.btnItalian.Size = new System.Drawing.Size(75, 23);
            this.btnItalian.TabIndex = 2;
            this.btnItalian.Text = "Italian";
            this.btnItalian.UseVisualStyleBackColor = true;
            this.btnItalian.Click += new System.EventHandler(this.btnItalian_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.Location = new System.Drawing.Point(100, 111);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(75, 23);
            this.btnSpanish.TabIndex = 3;
            this.btnSpanish.Text = "Spanish";
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click);
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(193, 111);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(75, 23);
            this.btnGerman.TabIndex = 4;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(100, 141);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LanguageTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 176);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnItalian);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblInstructionTitle);
            this.Name = "LanguageTranslatorForm";
            this.Text = "Trevor\'s Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructionTitle;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Button closeButton;
    }
}

