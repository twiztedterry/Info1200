using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBuyingCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        /// <summary>
        /// When clicked, pulls values and returns a total in the results box at the bottom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            //variables for make, color, condition, price
            string make = "", color = "", condition ="";
            decimal price = 0.0m;
            //executes the getmake method
            GetMake(ref make);
            //excecutes the getcolor method
            GetColor(ref color);
            //executes the getcondition method
            GetCondition(ref condition);
            
            //if statement to run the getprice method if no blank boxes
            if (GetPrice(ref price) && make != "" && color != "" && condition !="")
            {
                //sets the results texbox if the if passes true
                DisplayResults(price, make, color, condition);
            }
            else
            {
                //displays error message if passes false.
                MessageBox.Show("Enter a valid price", "Invalid Price");
            }
           
            



        }
        /// <summary>
        /// Gets and passes the cars make by reference.
        /// </summary>
        /// <param name="make"></param>
        private void GetMake(ref string make)
        {
            //if statement that validates make
            if (listboxMake.SelectedIndex >= 0)
            {
                //get and set make
                make = listboxMake.SelectedItem.ToString();

            }
            //else that throws message if make invalid
            else
            {
                //display error that make is invalid
                MessageBox.Show("Please select a make", "Invalid Make");

            }
 
        }

        /// <summary>
        /// gets and passes the cars color by reference
        /// </summary>
        /// <param name="color"></param>
        private void GetColor(ref string color)
        {
            //if statement that validates color
            if (listboxColor.SelectedIndex >= 0)
            {
                //get and set color
                color = listboxColor.SelectedItem.ToString();
            }
            //else that throws message if color invalid
            else
            {
                //display error message for invalid color
                MessageBox.Show("Please select a color", "Invalid Color");
            }

        }

        /// <summary>
        /// gets and passes the cars condition by reference
        /// </summary>
        /// <param name="condition"></param>
        private void GetCondition(ref string condition)
        {
            //if statement to check which radio button is selected
              if (radiobuttonNew.Checked)
            {
                //sets condition to new
                condition = "New";
                    
            }
            //else statement at the tail end to determine radio button
            else
            {
                //setes condition to used
                condition = "Used";
            }          
 
        }
        /// <summary>
        /// method to get and validate the price, then pass it by reference
        /// </summary>
        /// <param name="price"></param>
        private bool GetPrice(ref decimal price)
        {
            

            //if statement to validate price using tryparse
            if (decimal.TryParse(txtboxPrice.Text, out price))
            {
                //returns true
                return true;
            }
            //tail end else statement, throws a message box if invalid input
            else
            {
                //returns false
                return false;
            }
 
        }

        /// <summary>
        /// final method to concactnate it all together
        /// </summary>
        /// <param name="price"></param>
        /// <param name="make"></param>
        /// <param name="color"></param>
        /// <param name="condition"></param>
        private void DisplayResults(decimal price, string make, string color, string condition)
        {
            //changes the value of the results textbox
            txtboxResult.Text = condition + " " + color + " " + make + " " + "for" + " " + price.ToString("c");
        }


    }
}
