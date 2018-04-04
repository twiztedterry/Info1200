using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumbers
{
    public partial class lotteryForm : Form
    {
        public lotteryForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// event handler for the generatenumbers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateNumbersButton_Click(object sender, EventArgs e)
        {
            //constant to hold the size
            const int SIZE = 5;

            //delcaring an int array with five elements.
            int[] lotteryNumbers = new int[SIZE];

            //creating a new random object.
            Random rand = new Random();

            //for loop to fill the array with random numbers
            for(int index = 0; index < lotteryNumbers.Length; index++)
            {
                //generates and assigns a random number to each variable in the array
                lotteryNumbers[index] = rand.Next(100);
            }

            //assigning the first value to the array
            firstLabel.Text = lotteryNumbers[0].ToString();
            //assigning the second value to the array.
            secondLabel.Text = lotteryNumbers[1].ToString();
            //the third
            thirdLabel.Text = lotteryNumbers[2].ToString();
            //the fourth
            fourthLabel.Text = lotteryNumbers[3].ToString();
            //the fifth
            fifthLabel.Text = lotteryNumbers[4].ToString();





        }
    }
}
