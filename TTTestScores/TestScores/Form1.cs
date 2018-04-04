using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScores
{
    public partial class testscoreForm : Form
    {
        //creates the testScores list
        List<int> testScores = new List<int>();

               
        public testscoreForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handler for the "Add Score" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //local varaible to store the score value.
            int score;

            if(int.TryParse(scoreTextBox.Text, out score) && score >= 0 && score <=100)
            {
                //adds the score to the list
                testScores.Add(score);
                //adds the score to the listbox
                scoreListBox.Items.Add(score);

            }
            //else do
            else
            {
                //throws an error message
                MessageBox.Show("Please enter a valid number between 0 and 100 for score", "Invalid Number");
                //sets focus to the score box
                scoreTextBox.Focus();
                //empties the score box
                scoreTextBox.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //variable for testscore count
            int size = testScores.Count;

            //clears the listbox
            scoreListBox.Items.Clear();
            
            //for as long as the index is less than the size of the testscore count
            for (int index = 0; index < size; index++)
            {
                // remove each item from the testscore list.
                testScores.RemoveAt(0);
            }

            //clears the average label
            averageLabel.Text = "";
            
        }
        /// <summary>
        /// event handler to average scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void averageButton_Click(object sender, EventArgs e)
        {
            //double variable to hold the sum of scores
            double sum = 0.0;
            //double to hold the average
            double avg = 0.0;

            //if statement to verify that there is something in the list
            if(testScores.Count != 0)
            {
                //for each score item in the testscores, add them together to get sum 
                foreach(int score in testScores)
                {
                    sum += score;
                }

                //calculate the average of the scores.
                avg = sum / testScores.Count;
                //displays the average in the label
                averageLabel.Text = avg.ToString("#.#");

            }
            //else do
            else
            {
                //displays a messagebox
                MessageBox.Show("There are no scores, add some first!");
            }       
                    



        }
    }
}
