//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 1/12/2018
//Project #: 3
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace TTCardFlip
{
    partial class CardFlipForm
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
            this.grpBoxDeck = new System.Windows.Forms.GroupBox();
            this.pictureBoxFace = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCardFlip = new System.Windows.Forms.Button();
            this.grpBoxDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxDeck
            // 
            this.grpBoxDeck.Controls.Add(this.pictureBoxFace);
            this.grpBoxDeck.Controls.Add(this.pictureBoxBack);
            this.grpBoxDeck.Location = new System.Drawing.Point(12, 12);
            this.grpBoxDeck.Name = "grpBoxDeck";
            this.grpBoxDeck.Size = new System.Drawing.Size(260, 342);
            this.grpBoxDeck.TabIndex = 0;
            this.grpBoxDeck.TabStop = false;
            this.grpBoxDeck.Text = "My Deck:";
            // 
            // pictureBoxFace
            // 
            this.pictureBoxFace.Image = global::TTCardFlip.Properties.Resources.Ace_Spades;
            this.pictureBoxFace.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxFace.Name = "pictureBoxFace";
            this.pictureBoxFace.Size = new System.Drawing.Size(248, 317);
            this.pictureBoxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFace.TabIndex = 1;
            this.pictureBoxFace.TabStop = false;
            this.pictureBoxFace.Visible = false;
            this.pictureBoxFace.Click += new System.EventHandler(this.pictureBoxFace_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::TTCardFlip.Properties.Resources.Backface_Blue;
            this.pictureBoxBack.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(248, 317);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCardFlip
            // 
            this.btnCardFlip.Location = new System.Drawing.Point(18, 360);
            this.btnCardFlip.Name = "btnCardFlip";
            this.btnCardFlip.Size = new System.Drawing.Size(128, 23);
            this.btnCardFlip.TabIndex = 2;
            this.btnCardFlip.Text = "Show the Card Face";
            this.btnCardFlip.UseVisualStyleBackColor = true;
            this.btnCardFlip.Click += new System.EventHandler(this.btnCardFlip_Click);
            // 
            // CardFlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 387);
            this.Controls.Add(this.btnCardFlip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxDeck);
            this.Name = "CardFlipForm";
            this.Text = "Trevor\'s Card Flip";
            this.grpBoxDeck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDeck;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btnCardFlip;
        private System.Windows.Forms.PictureBox pictureBoxFace;
    }
}

