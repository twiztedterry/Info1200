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
using System.Windows.Forms;
using System.IO;

namespace TTMyGradeApp
{
    public partial class AddCourse : Form
    {
        //string to hold currentfile name
        string currentfilename;

        public AddCourse()
        {
            InitializeComponent();
            //sets the value of the currentfilename string variable
            currentfilename = "Courses.txt";
        }
        /// <summary>
        /// Closes the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //creates the outputfile streamreader object
            StreamWriter outputfile;
   
            //try catch to catch exceptions
            try
            {
                //opens the currentfile for writing
                outputfile = File.CreateText(currentfilename);

                //for loop to write the file
                for (int i = 0; i <= listboxCourses.Items.Count; i++)
                {
                    //writes each line of the listbox in a loop for as many items as there are.
                    outputfile.WriteLine(listboxCourses.Items[i].ToString());
                }

                //closes the outputfile
                outputfile.Close();
            }
            catch
            {
                MessageBox.Show("There was a problem writing to the file");
            }
            //closes the application
            this.Close();

        }
        /// <summary>
        /// event handler for the addcourse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //calling the default constructor for the course class
            Course course = new Course();

            if(ValidateCourse(course))
            {
                //new gradingmethodsform object, calls the forms constructor
                GradingMethodsForm gradingmethods = new GradingMethodsForm();
                //shows the form as a dialog
                gradingmethods.ShowDialog();

                //sets the course grade property with the gradingmethodsform grade property
                course.Grade = gradingmethods.Grade;
                //sets the course lettergrade property with the gradingmethodsform grade property
                course.LetterGrade = gradingmethods.Letter;

                //show course in listbox as a comma delimited string, using our override method.
                listboxCourses.Items.Add(course.ToString());

                //clear out the course input textboxes
                txtboxCourseName.Text = "";
                txtboxInstructor.Text = "";
                txtboxSemester.Text = "";
                //sets the focus on the course name.
                txtboxCourseName.Focus();


            }



        }
        /// <summary>
        /// method to validate the course and return a true or false based on the results.
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>

        private bool ValidateCourse(Course course)
        {
            //checks the course name box to ensure it's not empty
            if (txtboxCourseName.Text != "")
            {
                //checks the instructor textbox to ensure it's not empty
                if (txtboxInstructor.Text != "")
                {
                    //checks to ensure that the semester box is not empty
                    if (txtboxSemester.Text != "")
                    {
                        //sets the property fields with appropriate values.
                        course.CourseName = txtboxCourseName.Text;
                        course.Instructor = txtboxInstructor.Text;
                        course.Semester = txtboxSemester.Text;
                        //if so, return true
                        return true;
                    }
                    //else do
                    else
                    {
                        //displays relevant error message
                        MessageBox.Show("Invalid data entered for Semester.", "Invalid Data");
                        //sets the focus
                        txtboxSemester.Focus();
                        //returns false
                        return false;
                    }
                }
                //else do
                else
                {
                    //displays relevant error message
                    MessageBox.Show("Invalid data entered for Instructor.", "Invalid Data");
                    //sets the focus
                    txtboxInstructor.Focus();
                    //returns false
                    return false;
                }
            
            }
            //else do
            else
            {
                //displays relevant error message
                MessageBox.Show("Invalid data entered for Course Name.", "Invalid Data");
                //sets the focus
                txtboxCourseName.Focus();
                //returns false
                return false;
            }

        }
        

        /// <summary>
        /// load event handler that loads the textdocument when loaded and reads lines from it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCourse_Load(object sender, EventArgs e)
        {
            //establishes the inputfile streamreader object
            StreamReader inputfile;
            //creates an entry string to hold text
            string entry = "";
            //establishes the inputfile
            inputfile = File.OpenText(currentfilename);


            //try catch block to check if the file exists, will throw an exception error message if there's an issue.

            try
            {
                
                //reads file while note at the end of the stream
                while (!inputfile.EndOfStream)
                {
                    //reads the next line and saves to entry variable
                    entry = inputfile.ReadLine();

                    //adds entry to listbox
                    listboxCourses.Items.Add(entry);
                    
                }

                //closes the streamreader file.
                inputfile.Close();

            }
            catch
            {
                //throws an exception window indicating that the file has not been created yet.
                MessageBox.Show("File has not been created yet");
            }
        }
    }
}
