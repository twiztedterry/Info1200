using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTPizzaOrder
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When clicked, the close button closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form.
            this.Close();  
        }
        /// <summary>
        /// When clicked, the clear button wille deselect all checkboxes, revert the radio button to default, and erase all textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the order textbox
            txtboxOrder.Text = "";
            //unchecks the cheese topping
            chkboxCheese.Checked = false;
            //unchecks the pepperoni topping
            chkboxPepperoni.Checked = false;
            //unchecked the pineapple topping
            chkboxPineapple.Checked = false;
            //reverts the radio back to default of "Pan"
            radiobtnPan.Checked = true;
            //clears the city listbox
            listboxCity.ClearSelected();

        }
        /// <summary>
        /// When pressed, the "Send order" buttton will take the information checked and selected in each box 
        /// and concatenate it into a string inserted into the order box at the bottom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Establish the string variables
            string topping1, topping2, order, topping3, city, crusttype;

            //intialize and fill the topping 1 string with empty text
            topping1 = "";
            //intialize and fill the topping 2 string with empty text
            topping2 = "";
            //intialize and fill the topping 3 string with empty text
            topping3 = "";
            //intialize and fill the order string with empty text
            order = "";
            //intialize and fill the city string with empty text
            city = "";
            //initizlie and fill the crusttype string with empty text.
            crusttype = "";

            // Check to see if the Pan radio button is selected
            if(radiobtnPan.Checked)
            {
                //stores the radio button text ("pan") as the crusttype
                crusttype = radiobtnPan.Text.ToString() + " "; 
            }
            // performs an action depending on the result of the previous "If" statement
            else
            {
                //stores the radio button text ("Thin") as the crusttype
                crusttype = radiobtnThin.Text.ToString() + " ";
            }
            //checks to see if the cheese checkbox is checked
            if(chkboxCheese.Checked)
            {
                // if checked, stores the cheese text as the "Topping1" variable
                topping1 = chkboxCheese.Text.ToString() + " ";
            }
            //checks to see if the pepperoni checkbox is checked
            if (chkboxPepperoni.Checked)
            {
                // if checked, stores the pepperoni text as the "Topping2" variable
                topping2 = chkboxPepperoni.Text.ToString() + " ";
            }
            //checks to see if the pineapple checkbox is checked
            if (chkboxPineapple.Checked)
            {
                // if checked, stores the pineapple text as the "Topping3" variable
                topping3 = chkboxPineapple.Text.ToString() + " ";
            }
            //verifies that a city is selected
            if (listboxCity.SelectedIndex != -1)
            {
                // if a city is selected, adds the text for the city to the string variable.
                city = listboxCity.SelectedItem.ToString();
                // combines all variables into the "order" Variable
                order = crusttype + topping1 + topping2 + topping3 + city;
                // sends the order varaiable to the order textbox
                txtboxOrder.Text = order;
            }
            // if the city is not selected
            else
            {
                // show a textbox saying "City not selected, please select a city before placing your order"
                MessageBox.Show("City Not Selected, please select a city before placing your order");
            }
        }
    }
}
