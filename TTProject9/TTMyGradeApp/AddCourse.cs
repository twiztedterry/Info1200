// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 4/04/2018
// Project #: 9A
// I declare that the source code contained in this assignment was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Windows.Forms;

namespace TTMyGradeApp
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
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
    }
}
