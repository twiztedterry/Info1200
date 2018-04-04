using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhone
{
    public partial class cellPhoneForm : Form
    {
        public cellPhoneForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// creating the GetPhoneData method, which will pass a bool and assign data entered by the user to the properties within the class.
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        private bool GetPhoneData(CellPhone phone)
        {
            //variable to hold the price
            decimal newprice = 0m;

            //sets the values of the brand
            phone.Brand = brandTextBox.Text;
            //sets the value of the model
            phone.Model = modelTextBox.Text;

            //checks to see if the amount entered is a valid decimal value and assigns it if it is, if it's not, returns false.
            if (decimal.TryParse(priceTextBox.Text, out newprice))
            {
                //sets the value of the price
                phone.Price = newprice;
                //returns a true value to our bool
                return true;
            }
            else
            {
                //display an error message
                MessageBox.Show("Invalid Value for 'Price'");

                //returns a false value to our bool
                return false;
                
            }

        }
        /// <summary>
        /// method to assign the values to the textboxes
        /// </summary>
        /// <param name="phone"></param>
        private void DisplayPhone(CellPhone phone)
        {
            //assigns the brand label to the brand value
            resultBrandLabel.Text = phone.Brand;
            //assigns the model label to the model value
            resultModelLabel.Text = phone.Model;
            //assigns the price label to the price value
            resultPriceLabel.Text = phone.Price.ToString("c");
        }
        /// <summary>
        /// event handler for the create phone button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPhoneButton_Click(object sender, EventArgs e)
        {
            //new cellphone object
            CellPhone cellphone = new CellPhone();
            //calls an if statement to display values if there's no error thrown by our bool value
            if (GetPhoneData(cellphone))
            {
                //display data
                DisplayPhone(cellphone);
            }
            

        }
    }
}
