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
using System.IO;

namespace ReadWrite
{

    public partial class writeReadForm : Form
    {

        public writeReadForm()
        {
            InitializeComponent();
        }
        const string DEFAULT_FILE = "Countries.txt";



        /// <summary>
        /// When pressed, the "Write to File" button will write all lines in the current list box to the output file "Countries.txt"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeButton_Click(object sender, EventArgs e)
        {
            //beginning of a try/catch statement
            try
            {
                //establishes the outputfile streamwriter variable
                StreamWriter outputFile;

                //assigns a value to that variable and links the output file to streamwriter.
                outputFile = File.CreateText(DEFAULT_FILE);

                //uses a for loop to read the entire file, using the variable "num" to count up to the total lines in the written file.
                for (int num = 0; num < writeListBox.Items.Count; num++)
                {
                    //writes a line to the output file equal to the current number associated with the "Num" variable.
                    outputFile.WriteLine(writeListBox.Items[num]);
                }

                //inform the user that the write was successful
                MessageBox.Show("Text written successfully");

                //closes the output file.
                outputFile.Close();


            }
            //ending of a try/catch statement
            catch (Exception ex)
            {
                //displays the exception thrown in a messagebox.
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// read button handler, will read from the text file and insert all items into the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readButton_Click(object sender, EventArgs e)
        {
            //beginning of try/catch statement for the reader
            try
            {
                //assigns the inputfile variable
                StreamReader inputFile;
                //opens the text file and assigns it to the inputfile variable
                inputFile = File.OpenText(DEFAULT_FILE);

                //clears the data in the read listbox.
                readListBox.Items.Clear();

                // while statement, while not at the end of the file stream, read from the file and add to the listbox items
                while (!inputFile.EndOfStream)
                {
                    //reads the items in the file and adds them to the listbox
                    readListBox.Items.Add(inputFile.ReadLine());
                }

                //close the input file
                inputFile.Close();
                


            }

            //end of the try/catch statement for the reader
            catch (Exception ex)
            {
                //displays the relevant exception message in a textbox.
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// When clicked, the load button file will pop up a dialog and allow the user to select a text file to load from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //beginning of try catch statement
            try
            {
                //creates the streamreader file
                StreamReader inputFile;
                //clears the items in the read listbox.
                readListBox.Items.Clear();
                
                //if statement to determine whether or not a file was chosen by the dialog, if it was - it reads the file.
                if(OpenFile.ShowDialog() == DialogResult.OK)
                {
                    //establishes the variable for the inputfile
                    inputFile = File.OpenText(OpenFile.FileName);
                    //uses a while loop to read the file.
                    while (!inputFile.EndOfStream)
                    {
                        //reads the items in the file and adds them to the listbox
                        readListBox.Items.Add(inputFile.ReadLine());
                    }

                    //close the input file
                    inputFile.Close();
                }

            }
            //ending of try/catch statement
            catch (Exception ex)
            {
                //displays relevant exception message.
                MessageBox.Show(ex.Message);
            }


        }

     
    }
}
