using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class CoinTossForm : Form
    {
        public CoinTossForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// method to flip once, for the flip once button
        /// </summary>
        /// <param name="coin"></param>
        private void FlipOnce(Coin coin)
        {
            //toss the coin
            coin.Toss();
            //show a messagebox that displays the result
            MessageBox.Show(coin.GetSideUp());
        }

        /// <summary>
        /// When pressed, the exit button closes the dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the window
            this.Close();
        }
        /// <summary>
        /// When clicked, the clear button clears the boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the boxes
            listboxResults.Items.Clear();
        }

        /// <summary>
        /// Creates and interacts with the coin class to toss a coin five times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToss5times_Click(object sender, EventArgs e)
        {
            //creates a new coin as a method variable
            Coin coin = new Coin();

            //clear the listbox results.
            btnClear_Click(sender, e);

            //establishes the count variable
            int count = 0;

            //tosses 5 times
            while (count < 5)
            {
                //tosses the coin
                coin.Toss();

                //display the values in the listbox
                listboxResults.Items.Add(coin.GetSideUp());

                //increment the count
                count++;
            }

                    
        }
        /// <summary>
        /// when clicked, flips the coin and returns a value in a messagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlip_Click(object sender, EventArgs e)
        {
            //creates a new coin
            Coin coin = new Coin();
            //flips the coin
            FlipOnce(coin);

        }
    }
}
