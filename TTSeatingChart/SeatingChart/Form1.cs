using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatingChart
{
    public partial class seatingChartForm : Form
    {
        //adding the constants for row and column size
        const int MAX_ROW = 5;
        const int MAX_COL = 3;

        //two dimensional array, initilized with price data
        decimal[,] prices = {   {450m, 450m, 450m, 450m},
                                       {425m, 425m, 425m, 425m},
                                       {400m, 400m, 400m, 400m},
                                       {375m, 375m, 375m, 375m},
                                       {375m, 375m, 375m, 375m},
                                       {350m, 350m, 350m, 350m}

                                    };


        public seatingChartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When clicked, closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }
        /// <summary>
        /// When clicked, displays the price of the selected seats.
        /// Verification will occur to make sure that proper entries are selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            //local variables for row and column
            int column, row;

            //if statement logic to check the column text box, ensures the text in the box is an int
            if (int.TryParse(columnTextBox.Text, out column))
            {
                //makes sure that the text in column is less than MAX_COL and greater or equal to 0
                if (column >= 0 && column <=MAX_COL)
                {
                    //if statement to check the row text box, ensures the text is an int
                    if (int.TryParse(rowTextBox.Text, out row))
                    {
                        //makes sure that the text is less than MAX_COL and greater or equal to 0
                        if (row >= 0 && row <=MAX_ROW)
                        {
                            //sets the pricelabel text to the price value from the array
                            priceLabel.Text = prices[row, column].ToString("c");
                        }
                        else
                        {
                            //sets the focus on the row box
                            rowTextBox.Focus();
                            //messagebox that explains row requirements.
                            MessageBox.Show("Row entered must be between 0 and " + MAX_ROW);
                        }
                    }
                    else
                    {
                        //sets the focus on the row box
                        rowTextBox.Focus();
                        //messagebox that explains row requirements.
                        MessageBox.Show("Row entered must be a valid whole number");
                    }
                        
                    

                }
                else
                {
                    //sets the focus on the column box
                    columnTextBox.Focus();
                    //messagebox that explains column requirements.
                    MessageBox.Show("Column entered must be between 0 and " + MAX_COL);
                }
            }
            else
            {
                //sets the focus on the column box
                columnTextBox.Focus();
                //messagebox that explaisn column requirements.
                MessageBox.Show("Column entered must be a valid whole number");
                    
            }

        }
        /// <summary>
        /// when clicked, uses a loop to sum all price values into the total. Outer loop for row and inner for column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revenueButton_Click(object sender, EventArgs e)
        {
            //local variable for total
            decimal total = 0;

            //nested for loop
            //as long as our counter is less than the max row size
            for (int i = 0; i< MAX_ROW; i++)
            {
                //and as long as another counter is less than the column size
                for (int j = 0; j<MAX_COL; j++)
                {
                    //add the two together and add the total to the variable
                    total += prices[i, j];
                }
            }

            //displays the total in a messagebox
            MessageBox.Show("The total revenue is :" + total.ToString("c"));

        }
    }
}
