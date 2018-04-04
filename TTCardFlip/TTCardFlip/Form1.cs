//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 1/17/2018
//Participation #: 3
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
              


namespace TTCardFlip
{
    public partial class CardFlipForm : Form
    {


        public CardFlipForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If statement that checks to see if the pictureboxface is visible and performs different functions based on whether or not that is true
        /// allowing for the button to change from one text to another,
        /// and the image to change when each different version of the button is clicked.
        /// I created this as it's own method, because I wanted to use it multiple times, and wanted things to look clean and neat.
        /// </summary>
        private void pictureflipper()
        {
            // beginning of "IF" statement, establishes a rule that changes the behavior of the image if the pictureboxface is not visible.
            if (pictureBoxFace.Visible == false)
            {
                // Action to take if the pictureboxface isn't visible, changes the button text to "Show the Card Back" 
                btnCardFlip.Text = "Show the Card Back";
                // Action to take if the pictureboxface isn't visible, Makes the Picture Box face visible
                pictureBoxFace.Visible = true;
                // Action to take if the pictureboxface isn't visible, Makes the picturebox Back not visible
                pictureBoxBack.Visible = false;
            }
            //  "Else" portion of the "IF" statement, which establishes a separate rule that performs a different set of actions if the pictureBoxFace is visible.
            else
            {
                // Action to take if the pictureboxface is visible, changes the button text to "Show the Card Face"
                btnCardFlip.Text = "Show the Card Face";
                // Action to take if the pictureBoxFace is visible, makes the Picture Box face not visible
                pictureBoxFace.Visible = false;
                // Action to take if the pictureBoxFace is visible, makes the picturebox Back visible.
                pictureBoxBack.Visible = true;
            }
        }
        /// <summary>
        /// Closes the program when the "Close" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Program closed when button clicked
            this.Close();
        }

        

        private void btnCardFlip_Click(object sender, EventArgs e)
        {
            //calls the pictureflipper method.
            pictureflipper();
        }
        
        /// <summary>
        /// I added this second method to make the image click perform the same "If Statement" as the button click, because I thought it woudld be cooler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxFace_Click(object sender, EventArgs e)
        {
            //calls the pictureflipper method
            pictureflipper();
        }

        /// <summary>
        /// I added this third method to make the image click perform the same "If Statement" as the button click, because I thought it woudld be cooler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            //calls the pictureflipper method
            pictureflipper();
        }
        
    }
}
