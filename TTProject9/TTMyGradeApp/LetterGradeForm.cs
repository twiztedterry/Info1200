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
    public partial class LetterGradeForm : Form
    {
        //Establish Exam Max constant
        const double EXAM_MAX = 100;
        //Establish Quiz Max constant
        const double QUIZ_MAX = 15;
        //Establish Project Max constant
        const double PROJECT_MAX = 50;

        public LetterGradeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When clicked, the Calculate Grade button will capture all applicable variables and return a letter grade value based on a percentage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGradeCalculate_Click(object sender, EventArgs e)
        {
            //declare variables to hold the data
            int Project1, Quiz1, Exam1;
            double GradeTotal;
            string LetterGrade;

            //first IF statement, Tryparse the project1 variable 
            if (int.TryParse(txtboxProject1.Text, out Project1) && (Project1 <= PROJECT_MAX))
            {
                // second IF statement, tryparse the Exam1 variable
                if (int.TryParse(txtboxExam1.Text, out Exam1) && (Exam1 <= EXAM_MAX))
                {
                    // third IF statement, tryparse the Quiz1 variable
                    if (int.TryParse(txtboxQuiz1.Text, out Quiz1) && (Quiz1 <= QUIZ_MAX))
                    {
                        // calculating the total grade
                        GradeTotal = (((double)Project1 + (double)Exam1 + (double)Quiz1) / (PROJECT_MAX + EXAM_MAX + QUIZ_MAX))*100;
                        // Check to see if the total grade is below 60                              
                        if (GradeTotal < 60)
                        {
                            // assigns variable to lettergrade
                            LetterGrade = "E";
                            // Concatenates the strings together for the final text
                            txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                            
                        }
                        // if it's not, run next
                        else
                        {
                            // checks to see if it's below 63
                            if (GradeTotal < 63)
                            {
                                // assigns variable to lettergrade
                                LetterGrade = "D-";
                                // Concatenates the strings together for the final text
                                txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                
                            }
                            // if it's not, run next    
                            else
                            {
                                //checks to see if it's below 67
                                if (GradeTotal < 67)
                                {
                                    // assigns variable to lettergrade
                                    LetterGrade = "D";
                                    // Concatenates the strings together for the final text
                                    txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                }
                                // if it's not, run next
                                else
                                {
                                    //checks to see if it's below 70
                                    if (GradeTotal < 70)
                                    {
                                        // assigns variable to lettergrade
                                        LetterGrade = "D+";
                                        // Concatenates the strings together for the final text
                                        txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                    }
                                    // if it's not, run next
                                    else
                                    {
                                        //checks to see if it's below 73
                                        if (GradeTotal < 73)
                                        {
                                            // assigns variable to lettergrade
                                            LetterGrade = "C-";
                                            // Concatenates the strings together for the final text
                                            txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                        }
                                        // if it's not, run next
                                        else
                                        {
                                            //checks to see if it's below 77
                                            if (GradeTotal < 77)
                                            {
                                                // assigns variable to lettergrade
                                                LetterGrade = "C";
                                                // Concatenates the strings together for the final text
                                                txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                            }
                                            // if it's not, run next
                                            else
                                            {
                                                //checks to see if it's below 80
                                                if (GradeTotal < 80)
                                                {
                                                    // assigns variable to lettergrade
                                                    LetterGrade = "C+";
                                                    // Concatenates the strings together for the final text
                                                    txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                                }
                                                // if it's not, run next
                                                else
                                                {
                                                    //checks to see if it's below 83
                                                    if (GradeTotal < 83)
                                                    {
                                                        // assigns variable to lettergrade
                                                        LetterGrade = "B-";
                                                        // Concatenates the strings together for the final text
                                                        txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                                    }
                                                    // if it's not, run next
                                                    else
                                                    {
                                                        //checks to see if it's below 87
                                                        if (GradeTotal < 87)
                                                        {
                                                            // assigns variable to lettergrade
                                                            LetterGrade = "B";
                                                            // Concatenates the strings together for the final text
                                                            txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                                        }
                                                        // if it's not, run next
                                                        else
                                                        {
                                                            //checks to see if it's below 90
                                                            if (GradeTotal < 90)
                                                            {
                                                                // assigns variable to lettergrade
                                                                LetterGrade = "B+";
                                                                // Concatenates the strings together for the final text
                                                                txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                                            }
                                                            // if it's not, run next
                                                            else
                                                            {
                                                               //checks to see if it's below 94
                                                                if (GradeTotal < 94)
                                                                {
                                                                    LetterGrade = "A-";
                                                                    // Concatenates the strings together for the final text
                                                                    txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;
                                                                }
                                                                // if it's not, run next
                                                                else
                                                                {

                                                                    //assigns variable to lettergrade
                                                                    LetterGrade = "A";
                                                                    // Concatenates the strings together for the final text
                                                                    txtboxFinalGrade.Text = "Your final grade is " + GradeTotal.ToString("#.##") + "% for a letter grade of " + LetterGrade;

                                                                }
                                                            }
                                                        }
                                                        
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                    // else statement for the quiz1 tryparse
                    else 
                    {
                        //shows a message box that reads "Enter a valid number for quiz1"
                        MessageBox.Show("Enter a valid number between 0-15 for Quiz1");
                    }
                }

                // else statement for the Exam1 tryparse
                else 
                {
                    // shows a message box that reads "Enter a valid number for exam1"
                    MessageBox.Show("Enter a valid number between 0-100 for Exam1");
                }
            }
            // else statement for the Project1 tryparse
            else 
            {
                // shows a messsage box that reads "enter a valid number for Project1"
                MessageBox.Show("Enter a valid number between 0-50 for Project1");
            }


            
            


        }
        /// <summary>
        /// When clicked, will clear the textboxes and set focus to the topmost box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the textbox for exam 1
            txtboxExam1.Text = "";
            //clears the textbox for project1
            txtboxProject1.Text = "";
            //clears the textbox for quiz1
            txtboxQuiz1.Text = "";
            //sets focus to project 1 textbox
            txtboxProject1.Focus();
        }
        /// <summary>
        /// When clicked, this button will close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the application.
            this.Close();
        }
    }
}
