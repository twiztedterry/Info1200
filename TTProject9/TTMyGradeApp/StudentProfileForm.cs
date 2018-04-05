// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 3/28/2018
// Project #: 8A
// I declare that the source code contained in this assignment was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Basic Form code, creates the form
namespace TTMyGradeApp
{
    public partial class studentProfileForm : Form
    {
        public studentProfileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the same method I used in the cardflip application, it's an if statement wrapped in a reusable method that will
        /// switch images and button text when the button is clicked.
        /// </summary>
        private void picswapper()
        {
            // beginning of "IF" statement, establishes a rule that changes the behavior of the image if the pictureboxface is not visible.
            if (pictureboxLeft.Visible == false)
            {
                // Action to take if the pictureboxLeft isn't visible, changes the button text to "Show Second Picture" 
                btnPicSwitch.Text = "Use Photo 2";
                // Action to take if the pictureboxLeft isn't visible, Makes pictureboxLeft visible
                pictureboxLeft.Visible = true;
                // Action to take if the pictureboxLeft isn't visible, Makes the pictureboxRight not visible
                pictureboxRight.Visible = false;
                // Displays a messagebox confirming the photo swap
                MessageBox.Show("Image Set to Picture 1");
            }
            //  "Else" portion of the "IF" statement, which establishes a separate rule that performs a different set of actions if the pictureBoxLeft is visible.
            else
            {
                // Action to take if the pictureboxLeft is visible, changes the button text to "Show First Picture"
                btnPicSwitch.Text = "Use Photo 1";
                // Action to take if the pictureBoxLeft is visible, makes the pictureboxLeft not visible
                pictureboxLeft.Visible = false;
                // Action to take if the pictureBoxLeft is visible, makes the pictureboxRight visible.
                pictureboxRight.Visible = true;
                // Displays a messagebox confirming the photo swap.
                MessageBox.Show("Image set to Picture 2");
            }
        }

        /// <summary>
        /// Adds the close button logic to the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the window
            this.Close();
        }
        /// <summary>
        /// Method to clear the text boxes of all information, when the button is pressed, all textboxes will be cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxEmail.Text = ""; //Clears the email box
            txtboxFName.Text = ""; //Clears the First Name box
            txtboxGradYear.Text = ""; // Clears the Graduation Year box
            txtboxLName.Text = ""; // Clears the Last Name box
            txtboxMajor.Text = ""; // Clears the Major box

        }
        /// <summary>
        /// Method calling the "PicSwapper method to swap images and button information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPicSwitch_Click(object sender, EventArgs e)
        {
            //calls the picswapper and uses the if statement to swap images and button text.
            picswapper();
        }
    }
}
