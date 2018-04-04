using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTAccountBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //sets the datetimepicker's value to todays date/time.
            datetimeSave.Value = DateTime.Now;
        }

        /// <summary>
        /// When clicked, the close button closes the dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the dialog
            this.Close();
        }
        /// <summary>
        /// When clicked, the reset button will erase all form data and reset the datepicker to today's date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // clears the textbox for startingbalance
            txtboxStartingBalance.Text = "";
            //reverts the datetime picker to todays date/time
            datetimeSave.Value = DateTime.Now;
            //clears the listbox
            listboxDetails.Items.Clear();

        }
        /// <summary>
        /// When clicked, the calculate button will take the values in the date/time and starting balance textbox, 
        /// assign them to variables, and perform a math action for each month, counting a running balance
        /// this balance will be displayed in the text box at the bottom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // establish the variables
            double CurrentBalance;
           // assigns todaysdate variable as "now"
            DateTime TodaysDate = DateTime.Now;
            // creates the savedate variable
            DateTime SaveDate;
            // creates interest rate constant
            const double INTEREST_RATE = .005;
            
            
            //if statement to attempt a tryparse on the startingbalance box   
            if (double.TryParse(txtboxStartingBalance.Text, out CurrentBalance))
            {
                //if statement to attempt to tryparse the datetime value
                if (DateTime.TryParse(datetimeSave.Text, out SaveDate))
                {
                    //creates the monthssaving variable
                    int MonthsSaving;
                    // creates the "count" variable
                    int Count = 1;
                    //assigns the "Months saving" variable to a calculation I had to get help with :( - this subtracts the years, multiplies by ten, then adds the difference in months.
                    MonthsSaving = ((SaveDate.Year - TodaysDate.Year) * 12) + SaveDate.Month - TodaysDate.Month;
                    // starts the "While" loop, using the "Monthssaving" variable as the counter
                    while (MonthsSaving >= Count)
                    {
                        //creates the new "Current Balance"
                        CurrentBalance = CurrentBalance+ (CurrentBalance * INTEREST_RATE);
                        //displays the text as an entry in the textbox.
                        listboxDetails.Items.Add("The ending balance " + "for month " + Count + " is " + CurrentBalance.ToString("c"));
                        //adds one to the loop counter.
                        Count++;
                    }


                }
                // if it fails, show a messagebox indicating an incorrect date was entered
                else
                {
                    // shows the messagebox with the message.
                    MessageBox.Show("Please select a valid date.");

                }
            }
            // if the tryparse failed, display a message indicating an invalid value was entered.
            else
            {
                //displays the messagebox
                MessageBox.Show("Please enter a valid number int he Starting Balance field.");
            }



            



        }
    }
}
