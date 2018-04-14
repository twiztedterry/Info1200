// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 4/10/2018
// Project #: 10A
// I declare that the source code contained in this assignment was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TTMyGradeApp
{
    public partial class GPAForm : Form
    {
        //string to hold the currentfilename
        string currentfilename;

        //constant for my array
        int COURSE_MAX = 50;

        //creating a new array variable
        string[] letterGrades;


        public GPAForm()
        {
            InitializeComponent();
            //assigning value to the current file name
            currentfilename = "Courses.txt";
            //creating a new string array, using the course max as the size.
            letterGrades = new string[COURSE_MAX];


        }
        /// <summary>
        /// when pressed, closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //closes the dialog
            this.Close();
        }

        /// <summary>
        /// method that will split out the lettergrade and assign it to the array
        /// </summary>
        /// <param name="courseString"></param>
        /// <param name="index"></param>
        public void SetLetterGrade(string filedata, int count)
        {
            //creats local array and sets the array to split using a comma as a delimiter, depending on the order of the lettergrade in the course tostring.
            string[] input = filedata.Split(',');
            letterGrades[count] = input[4];

        }
        /// <summary>
        /// method to calculate the GPA
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public double CalculateGPA(int count)
        {
            //double variable for total
            double total = 0;
            //double variable for GPA
            double gpa = 0;

            //loops through the count to get each 
            for (int i = 0; i < count; i++)
            {
                    if(letterGrades[i] == "A")
                    {
                        total += 4.0;

                    }
                    else if (letterGrades[i] == "A-")
                    {
                        total += 3.7;
                    }
                    else if (letterGrades[i] == "B+")
                    {
                        total += 3.3;
                    }
                    else if (letterGrades[i] == "B")
                    {
                        total += 3.0;
                    }
                    else if (letterGrades[i] == "B-")
                    {
                        total += 2.7;
                    }
                    else if (letterGrades[i] == "C+")
                    {
                        total += 2.3;
                    }
                    else if (letterGrades[i] == "C")
                    {
                        total += 2.0;
                    }
                    else if (letterGrades[i] == "C-")
                    {
                        total += 1.7;
                    }
                    else if (letterGrades[i] == "D+")
                    {
                        total += 1.3;
                    }
                    else if (letterGrades[i] == "D")
                    {
                        total += 1.0;
                    }
                    else if (letterGrades[i] == "D-")
                    {
                        total += 0.7;
                    }
                    else if (letterGrades[i] == "E")
                    {
                        total += 0;
                    }

                               
            }
                //calculate the GPA by dividing the total by the count
                gpa = total / count;
                return gpa;
        }


       



        /// <summary>
        /// load event handler for the GPA Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GPAForm_Load(object sender, EventArgs e)
        {
            //streamreader object creation
            StreamReader infile;
            //string for filedata
            string filedata= "";
            //int for count
            int count = 0;
            //double value for GPA;
            double gpa = 0;

            try
            {
                //establishes the inputfile
                infile = File.OpenText(currentfilename);
                //while the inputfile is not endofstream (reads the file in it's entirety
                while (!infile.EndOfStream)
                {
                    //reads each line from the file, storing it in the entry variable
                    filedata = infile.ReadLine();

                    //calls the getlettergrades method, passing coursestring and count
                    SetLetterGrade(filedata, count);

                    //increment count
                    count++;


                }
                //if count is greater than zero
                if (count > 0)
                {
                    //call the CalculateGPA method and pass in the count.
                    gpa = CalculateGPA(count);

                    //display GPA in the box to two decimal places
                    txtboxGPA.Text = gpa.ToString("#.##");



                }
                else
                {
                    //displays relevant message
                    MessageBox.Show("No courses added, please add some courses.");
                }
                //closes the file
                infile.Close();
            }

            //catches exceptions
            catch
            {
                //displays relevant messagebox
                MessageBox.Show("File was unable to read or no grades found");
            }

        }
    }
}
