using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTFriendsName
{
    public partial class formFriendFile : Form
    {
        public formFriendFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When pressed, closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // command to close the application
            this.Close();
        }
        /// <summary>
        /// When pressed, writes the name entered to a new line in a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteName_Click(object sender, EventArgs e)
        {
            //beginning of try/catch statement
            try
            {
                //establishing the output file variable
                StreamWriter outputFile;
                //assigning value to the output file variable, and creating the file if it doesn't exist, otherwise appends the data
                outputFile = File.AppendText("Names.txt");
                
                //writes the new line to the file
                outputFile.WriteLine(txtboxFriendsName.Text);
                //closes the file
                outputFile.Close();

                //inform the user that the name was written
                MessageBox.Show("Name " + txtboxFriendsName.Text + " written to " + "Names.txt");

                //clears the textbox
                txtboxFriendsName.Text = "";

                //gives the name box focus
                txtboxFriendsName.Focus();
            }
            //final part of try/catch statement
            catch (Exception ex)
            {
                //displays an error window with relevant message to the exception that occurred.
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
