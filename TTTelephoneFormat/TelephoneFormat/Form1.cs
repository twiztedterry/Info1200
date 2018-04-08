using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneFormat
{
    public partial class telephoneFormatForm : Form
    {
        //constants
        const int VALID_LENGTH = 10;
        const int UNFORMAT_VALID_LENGTH = 13;


        public telephoneFormatForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
            telephoneTextBox.Text = "";
            formattedLabel.Text = "";
            unformattedLabel.Text = "";
        }
        /// <summary>
        /// Event handler for the format button, when pressed, formats the phone number into the correct format, after checking to ensure the phone number isn't already properly formatted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formatButton_Click(object sender, EventArgs e)
        {

            //creates the variable and assigns the textbox, while trimming all empty spaces.
            string str = numberTextBox.Text.Trim();

            //if statement that uses the validnumber method to check the validity of the number, then performs actions if its valid, displays an error otherwise.
            if(ValidNumber(str))
            {
                //runs the telephoneformat method, formatting the number
                TelephoneFormat(ref str);
                //assigns the formatted number to the label's text
                formattedLabel.Text = str;
            }
            //displays a relevant error message
            else
            {
                //displays message
                MessageBox.Show("The phone number entered is not valid.");
            }
          
        }
        /// <summary>
        /// method to do validation checking on the entered text, returns true if valid format, false otherwise.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool ValidNumber(string str)
        {
            //tests the string to see if it's equal to valid length constant
            if(str.Length == VALID_LENGTH)
            {
                //foreach loop checking to see if each character is a digit, returns false otherwise.
                foreach(char ch in str)
                {
                    //if statement within the foreach loop to verify each character is a digit
                   if(!char.IsDigit(ch))
                    {
                        //returns false if one of them isn't a digit
                        return false;
                    }
                }
                //returns true
                return true;
            }

            //if it's not
            else
            {
                //return a false value to the bool
                return false;
            }

        }
        /// <summary>
        /// method to insert the characters into the number to make it into a valid phone number
        /// </summary>
        /// <param name="str"></param>
        private void TelephoneFormat(ref string str)
        {
            //inserts a left open parentheses at location zero
            str = str.Insert(0, "(");
            //inserts a right closed parentheses at location three
            str = str.Insert(4, ")");
            //inserts a dash at location seven.
            str = str.Insert(8, "-");
        }
        /// <summary>
        /// Method to test the format for the unformat button.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool ValidFormat(string str)
        {
            //checks to see if the length is valid, and that there's an open parentehses at 0, a close at 3, and a dash at 7
            if (str.Length == UNFORMAT_VALID_LENGTH && str[0] == '(' && str[4] == ')' && str[8] == '-')
            {
                //returns true
                return true;
            }
            else
            {
                //returns false
                return false;
            }   
        }

        /// <summary>
        /// method that removes the formatting from the entered telephone number
        /// </summary>
        /// <param name="str"></param>

        private void UnformatTelephone(ref string str)
        {
            //removes the character at the zero position
            str = str.Remove(0, 1);
            //removes the character at the four position
            str = str.Remove(3, 1);
            //removes the character at the seven position
            str = str.Remove(6, 1);
        }

        /// <summary>
        /// event handler for the unformat button, when pressed, will remove formatting from the entered phone number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unformatButton_Click(object sender, EventArgs e)
        {
            //grabs the textbox text and stores it in a string variable after trimming
            string str = telephoneTextBox.Text.Trim();

            //uses the established method to check to see if the format is already valid, if not - formats it properly
            if(ValidFormat(str))
            {
                //runs the unformattelephone method, which removes the formatting from a telepehone nubmer entered.
                UnformatTelephone(ref str);
                //changes the label text to be equal to the newly unformatted phone number.
                unformattedLabel.Text = str;

            }
            else
            {
                //shows a messagebox with proper text
                MessageBox.Show("The telephone number entered is not valid");
            }


        }

       
    }
}
