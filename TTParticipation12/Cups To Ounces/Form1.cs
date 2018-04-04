using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// Creates the InputIsValid Method to determine if the input is valid.
        /// </summary>
        /// <param name="cups"></param>
        /// <returns></returns>
        private bool InputIsValid(ref double cups)
        {
            
            //if statement to verify that a valid number is entered for cups
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // returns true if true
                return true;
            }
            // else statement if it can't be parsed
            else
            {
                //displays an exception message
                MessageBox.Show("Please enter a valid number for Cups");
                //clears the textbox
                cupsTextBox.Clear();
                //sets the focus on the textbox
                cupsTextBox.Focus();
                //returns the false value
                return false;
            }
        }

        /// <summary>
        /// Creates a "CupsToOunces" method to convert cups to ounces.
        /// </summary>
        /// <param name="cups"></param>
        /// <returns></returns>
        private double CupsToOunces(double cups)
        {
            //creates a constant for the cups conversion
            const int CO = 8;
            //returns cups * the CO variable
            return cups * CO;

        }

        /// <summary>
        /// creats a display ounces method to display the amount of ounces entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayOunces(double ounces, double cups)
        {
            // converts the string to a decimal of 1 decimal place
            ouncesLabel.Text = ounces.ToString("##.#");
        }
  /// <summary>
  /// event handler 
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            // yay! variables for cups and ounces
            double cups = 0;
            double ounces = 0;

            // if to verify the input is valid.
           if (InputIsValid(ref cups))
            {
               // calls the cupstoounces method.
                ounces = CupsToOunces(cups);
               // calls the displayounces method
                DisplayOunces(ounces, cups);



            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
