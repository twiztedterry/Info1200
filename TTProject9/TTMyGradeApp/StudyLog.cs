// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 3/28/2018
// Project #: 8A
// I declare that the source code contained in this assignment was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMyGradeApp
{
    public partial class StudyLog : Form
    {
        //creates the currentfilename variable.
        string currentfilename;


        public StudyLog()
        {
            

            InitializeComponent();
        }
        /// <summary>
        /// Load event handler for the study log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     
        /// <summary>
        /// when pressed, concatenates the items together into a string and writes it to the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      

        //when pressed, closes the window
       
        /// <summary>
        /// when pressed, saves all the data in the log listbox to a file for today's date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //declares an integer for the entries in the listbox
            int listcount = listboxLogEntries.Items.Count;

            //calls the streamwriter to create a file and open it for appending.
            StreamWriter outfile;
            //establishes the output file and opens it
            outfile = File.CreateText(currentfilename);


            //try catch to handle exceptions
            try
            {
                //as long as i>0 - add items to the file
                for (int i = 0; i < listcount; i++)
                {
                    //writes the file
                    outfile.WriteLine(listboxLogEntries.Items[i]);
                }

                //closes the file
                outfile.Close();
            }
                //catches exceptions
            catch
            {
                //displays a message
                MessageBox.Show("The file could not be written, please make sure you have enough disk space");

            }

        }
        /// <summary>
        /// when pressed, the logentry button will add a log entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLogEntry_Click(object sender, EventArgs e)
        {
            //stores the variable for the duration
            int minutes;
            //exception handling for the button, ensures that the duration is a valid integer.
            if (int.TryParse(textboxMinutes.Text, out minutes))
            {
                //creates and contactenates the logentry variable
                string entry = listboxCourses.SelectedItem.ToString() + " " + minutes + " " + txtboxNote.Text.ToString();

                //adds the item to the listbox
                listboxLogEntries.Items.Add(entry);

                //reselects the defaults
                listboxCourses.SelectedIndex = 0;
                //clears the box
                textboxMinutes.Text = "";
                //clears the box
                txtboxNote.Text = "";

            }
            //throws an exception
            else
            {
                //displays a relevant exception message
                MessageBox.Show("Whoops! Please enter a valid number for 'Duration'");
            }
        }
        /// <summary>
        /// when pressed, the close button closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            //closes the window.
            this.Close();
        }
        /// <summary>
        /// form load handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudyLog_Load_1(object sender, EventArgs e)
        {

            //establishes the variable today, and sets the value of today
            string today = DateTime.Now.ToString("d");

            //escapes today to make it savable
            today = today.Replace('/', '_');

            //sets the currentfilename values.
            currentfilename = today + "studylog" + ".txt";

            //inserts the date into the "Today's Date" textbox
            txtboxDate.Text = DateTime.Now.ToString("d");

            //delcaring a streamreader variable
            StreamReader inputFile;

            //sets the course listbox to default to the first item in the list.
            listboxCourses.SelectedIndex = 0;

            // Try this
            try
            {
                //opening the file to get the streamreader object
                inputFile = File.OpenText(currentfilename);

                //clear log listbox
                listboxLogEntries.Items.Clear();

                //variable to hold the line read from the file
                string entry = "";

                //while the inputfile is not at the end of the stream, read the data from the text file and add it to the listbox.
                while (!inputFile.EndOfStream)
                {
                    //read and save the first line of the file
                    entry = inputFile.ReadLine();

                    //add the item to the listbox
                    listboxLogEntries.Items.Add(entry);
                }
                //close the file
                inputFile.Close();



            }

            //if it fails, display message
            catch
            {

                MessageBox.Show("There is no study log file for today's date.");
               

            }





        }
    }
}
