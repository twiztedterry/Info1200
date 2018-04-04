using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTFuelEconomy
{
    /// <summary>
    /// Automatic method created by VS to build and create the form.
    /// </summary>
       public partial class formMPG : Form
    {
        public formMPG()
        {
            InitializeComponent();
        }

        private void formMPG_Load(object sender, EventArgs e)
        {

        } 
       
           /// <summary>
           /// Creates the event for a button click on the "Help" button, created to display instructions on using the application.
           /// </summary>
           /// <param name="sender"></param>
           /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Displays the messagebox with the text "Enter how many miles were travelled and how many gallons of fuel were used, then click the calculate button."
            MessageBox.Show("Enter how many miles were travelled and how many gallons of fuel were used, then click the calculate button.");
        }
           /// <summary>
           /// Creates the event for a button click on the "Exit" Button, when clicked the button will close the program.
           /// </summary>
           /// <param name="sender"></param>
           /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();   
        }
           /// <summary>
           /// When clicked, the button will grab the variables entered in the boxes, divide miles by gallons, and return the result in the results box.
           /// </summary>
           /// <param name="sender"></param>
           /// <param name="e"></param>
        private void btnCalculateMPG_Click(object sender, EventArgs e)
        {
            //Added Try/Catch code to attempt exception handling
            //Should catch any exceptions and return the catch value
            try
            {
                double miles, gallons, mpg; //variables to hold the Miles Travelled, Gallons Used, and Average MPG result.

                //Assigns text entered in the "Miles Travelled" textbox and assigns in to the "miles" variable.
                miles = double.Parse(textBoxMiles.Text);

                //Assigns text entered in the "Gallons Used" textbox and assigns it to the "gallons" variable.
                gallons = double.Parse(textBoxGallons.Text);

                //Divides miles by gallons to return the average MPG value.
                mpg = miles / gallons;

                //Displays the average MPG in the MPG textbox
                textBoxResults.Text = mpg.ToString();
            }
            //Will return "Please enter a valid number in all fields." if an exception is thrown.
            catch
            {
                MessageBox.Show("Please enter a valid number in all fields.");
            }
        }
    }
}
