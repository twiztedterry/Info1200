using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTestAverage
{
    public partial class formTestAverage : Form
    {
        public formTestAverage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the "Calculate Average" Button, when pressed, will divide the sum of our variables (test 1,2,3) by 3
        /// and insert the result into the average test score textbox, if the average is above 95% (The "High Score" constant)
        /// it will display a congratulatory message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            //beginning of the try-catch statement to handle exceptions.
            try
            {
                const double HIGH_SCORE = .95; // this constant holds the "High Score" record to be used by our if statement later.
                double test1, test2, test3; // this will hold test scores 1,2,3 as a double variable.
                double average; // this will hold the result of our division of the sum of 1,2,3 by 3, and will be inserted into the average box.

                //get the test scores
                test1 = double.Parse(txtboxTest1.Text);
                test2 = double.Parse(txtboxTest2.Text);
                test3 = double.Parse(txtboxTest3.Text);
                
                // Sum up the three test variables, and divide the result by 3, then assign it to the "Average" variable.
                // Note: I changed the calculation to divide by 100 first, so that more realistic values could be entered.
                // This means if I scored 85/100 on a test, i'd just need to enter 85 rather than .85.
                average = ((test1+test2+test3) /100) / 3.0;

                // checks the users average score varialbe against the "High Score" constant, if true - displays a message congratulating the user.
                if (average >= HIGH_SCORE)
                    MessageBox.Show ("Congratulations! Great Job!");

                //display average test score as a percentage.
                txtboxAverageScore.Text = average.ToString("p");
            }
            catch
            {
                //display error message if exception is thrown
                MessageBox.Show("Please enter valid numbers in the test entry boxes.");
            }
        }
        /// <summary>
        /// Exit button functionality: When pressed, this button will close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clear button functionality: when pressed, this button will clear all data entered in all text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxTest1.Text = ""; //clears the "Test 1" text box
            txtboxTest2.Text = ""; //clears the "Test 2" text box
            txtboxTest3.Text = ""; //clears the "Test 3" text box
            txtboxAverageScore.Text = ""; //clears the "Average Score" text box
        }
        /// <summary>
        /// Help button to display how the program works, when pressed will display a textbox detailing necessary information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is designed to calculate an average percentage when given 3 test scores, this means your test scores must be given as if they were a percentage of 100. for example, If I scored 85% on a test, I'd enter 85 as my number. Do this with all 3 numbers, then hit the calculate button, your average will be displayed as a percentage.");
        }
    }
}
