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

namespace TTMyGradeApp
{
    public partial class GradingMethodsForm : Form
    {
        //backing fields for transferring data between forms.
        private string _letter;
        private double _grade;

        /// <summary>
        /// establishing grade as a property
        /// </summary>
        public double Grade
        {
            //get and set for grade property
            get { return _grade; }
            set { _grade = value; }
        }
        /// <summary>
        /// establishing letter as a property 
        /// </summary>
        public string Letter
        {
            //get and set for the letter property
            get { return _letter; }
            set { _letter = value; }
        }


        //cosnstant for project weight
        const double PROJECTS_VALUE = .45;
        //constant for exam weight
        const double EXAMS_VALUE = .30;
        //constant for quizzes weight
        const double QUIZZES_VALUE = .25;
        //constant for quizzes max value
        const double QUIZZES_MAX = 15;
        //constant for projects max value
        const double PROJECTS_MAX = 50;
        //constant for exams max value
        const double EXAMS_MAX = 100;
        //constant for A grade
        const double gradea = 94;
        //cosntant for A- grade
        const double gradeaminus = 90;
        //constant for B+ grade
        const double gradebplus = 87;
        //cosntant for B grade
        const double gradeb = 83;
        //constant for B- grade
        const double gradebminus = 80;
        //constant for C+ grade
        const double gradecplus = 77;
        //constant for a C grade
        const double gradec = 73;
        //constant for a C- grade
        const double gradecminus = 70;
        //constant for a D+ grade
        const double gradedplus = 67;
        //constant for a D grade
        const double graded = 63;
        //constant for a D- grade
        const double gradedminus = 60;
        //constant for an E grade
        const double gradee = 0;

            


        public GradingMethodsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// button click event handler for the "Find Grade Button" when pressed, will take all variables entered, and output the final grade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            //creates and initializes the final score variable
            double finalscore = 0;
            //creates and initializes the grade variable to store the letter grade
            string grade = "";
            //creates and initializes all the variables for the actual scores entered in the textboxes.
            int project1 = 0, project2 = 0, project3 = 0, exam1 = 0, exam2 = 0, quiz1 = 0, quiz2 = 0, quiz3 = 0, quiz4 = 0;
            //start of project validation
            if (ProjectValidation(ref project1, ref project2, ref project3))
            {
                //if project validation passes, move on to exam validation
                if(ExamValidation(ref exam1, ref exam2))
                {
                    //if exam validation passes, move on to quiz valiation
                    if(QuizValidation(ref quiz1, ref quiz2, ref quiz3, ref quiz4))
                    {
                        //run the calculategrade method
                        CalculateGrade(project1, project2, project3, exam1, exam2, quiz1, quiz2, quiz3, quiz4, ref finalscore );
                        //run the lettergrade method
                        LetterGrade(finalscore, ref grade);
                        //run the grade report method
                        GradeReport(finalscore, grade);

                        //set the form properties to the grade and letter
                        //finalscore = grade percentage
                        this.Grade = finalscore;
                        //grade = lettergrade
                        this.Letter = grade;
                        //closes the form
                        this.Close();

                    }
                }
            }

        }
        /// <summary>
        /// Method for validating the projects scores, compares them against the max and ensures they're valid integers
        /// </summary>
        /// <param name="project1"></param>
        /// <param name="project2"></param>
        /// <param name="project3"></param>
        /// <returns></returns>
        public bool ProjectValidation(ref int project1, ref int project2, ref int project3)
        {
            //if project 1 is valid, try project 2, else throw error and return false
            if (int.TryParse(txtboxProject1.Text, out project1) && (project1 <= PROJECTS_MAX))
            {
                //if project 2 is valid, try project 3, else throw error and return false
                if (int.TryParse(txtboxProject2.Text, out project2) && (project2 <= PROJECTS_MAX))
                {
                    //if project 3 is valid, return true, else throw error and return false
                    if (int.TryParse(txtboxProject3.Text, out project3) && (project3 <= PROJECTS_MAX))
                    {
                        //returns true
                        return true;
                    }
                    //else do
                    else
                    {
                        //displays specific error message
                        MessageBox.Show("Project 3 must be a valid integer between 0-50");
                        //clears textbox
                        txtboxProject3.Text = "";
                        //sets focus
                        txtboxProject3.Focus();
                        //returns false
                        return false;
                    }
                }
                //else do
                else
                {
                    //displays specific error message
                    MessageBox.Show("Project 2 must be a valid integer between 0-50");
                    //clears textbox
                    txtboxProject2.Text = "";
                    //sets focus
                    txtboxProject2.Focus();
                    //returns false
                    return false;
                }
            }
            //else do
            else
            {
                //displays specific error message
                MessageBox.Show("Project 1 must be a valid integer between 0-50");
                //clears textbox
                txtboxProject1.Text = "";
                //sets focus
                txtboxProject1.Focus();
                //returns false
                return false;


            }
        }
        /// <summary>
        /// validates the exam scores and returns a value
        /// </summary>
        /// <param name="exam1"></param>
        /// <param name="exam2"></param>
        /// <returns></returns>
        public bool ExamValidation(ref int exam1, ref int exam2)
        {
            //if exam 1 is valid, try exam 2, otherwise throw error and return false
            if (int.TryParse(txtboxExam1.Text, out exam1) && (exam1 <= EXAMS_MAX))
            {
                //if exam 2 is valid, return true, otherwise throw error and return false.
                if (int.TryParse(txtboxExam2.Text, out exam2) && (exam2 <= EXAMS_MAX))
                {

                    //returns true
                    return true;
                }
                //else do
                else
                {
                    //displays a specific error message
                    MessageBox.Show("Exam 2 must be a valid integer between 0 and 100");
                    //clears textbox
                    txtboxExam2.Text = "";
                    //sets focus
                    txtboxExam2.Focus();
                    //returns false
                    return false;
                }
            }
            //else do
            else
            {
                //displays specific error message
                MessageBox.Show("Exam 1 must be a valid integer between 0 and 100");
                //clears textbox
                txtboxExam1.Text = "";
                //sets focus
                txtboxExam1.Focus();
                //returns false
                return false;

            }
        }
        public bool QuizValidation(ref int quiz1, ref int quiz2, ref int quiz3, ref int quiz4)
        {
            //if quiz 1 is valid, try quiz 2, else throw error and return false
            if (int.TryParse(txtboxQuiz1.Text, out quiz1) && (quiz1 <= QUIZZES_MAX))
            {
                //if quiz 2 is valid, try quiz 3, else throw error and return false
                if (int.TryParse(txtboxQuiz2.Text, out quiz2) && (quiz2 <= QUIZZES_MAX))
                {
                    //if project 3 is valid, try quiz 4, else throw error and return false
                    if (int.TryParse(txtboxQuiz3.Text, out quiz3) && (quiz3 <= QUIZZES_MAX))
                    {
                        //if quiz 4 is valid, return true, else throw error and return false
                        if (int.TryParse(txtboxQuiz4.Text, out quiz4) && (quiz4 <= QUIZZES_MAX))
                        {
                            //returns true
                            return true;
                        }
                        //else do
                        else
                        {
                            //displays specific error message
                            MessageBox.Show("Quiz 4 must be a valid integer between 0-15");
                            //clears textbox
                            txtboxQuiz4.Text = "";
                            //sets focus
                            txtboxQuiz4.Focus();
                            //returns false
                            return false;

                        }

                    }
                    //else do
                    else
                    {
                        //displays specific error message
                        MessageBox.Show("Quiz 3 must be a valid integer between 0-15");
                        //clears textbox
                        txtboxQuiz3.Text = "";
                        //sets focus
                        txtboxQuiz3.Focus();
                        //returns false
                        return false;
                    }
                }
                //else do
                else
                {
                    //displays specific error message
                    MessageBox.Show("Quiz 2 must be a valid integer between 0-15");
                    //clears textbox
                    txtboxQuiz2.Text = "";
                    //sets focus
                    txtboxQuiz2.Focus();
                    //returns false
                    return false;
                }
            }
            //else do
            else
            {
                //displays specific error message
                MessageBox.Show("Quiz 1 must be a valid integer between 0-15");
                //clears textbox
                txtboxQuiz1.Text = "";
                //sets focus
                txtboxQuiz1.Focus();
                //returns false
                return false;

            }
        }
        /// <summary>
        /// method for calculating the grade
        /// </summary>
        /// <param name="project1"></param>
        /// <param name="project2"></param>
        /// <param name="project3"></param>
        /// <param name="exam1"></param>
        /// <param name="exam2"></param>
        /// <param name="quiz1"></param>
        /// <param name="quiz2"></param>
        /// <param name="quiz3"></param>
        /// <param name="quiz4"></param>
        /// <returns></returns>
        public double CalculateGrade(int project1, int project2, int project3, int exam1, int exam2, int quiz1, int quiz2, int quiz3, int quiz4, ref double finalscore)
        {
            //storing the averages in a double value for project
            double projectavg = 0;
            //storing the averages for quiz in a double value
            double quizavg = 0;
            //storing the average for exam in a double value
            double examavg = 0;

            //getting the grade average for the projects category
            projectavg = (project1 + project2 + project3) / (PROJECTS_MAX * 3);
            //getting the grade average for the exams category
            examavg = (exam1 + exam2) / (EXAMS_MAX * 2);
            //getting the grade average for the quizzes category
            quizavg = (quiz1 + quiz2 + quiz3 + quiz4) / (QUIZZES_MAX * 4);

            //sets final score by math
            finalscore = ((projectavg * PROJECTS_VALUE) + (examavg * EXAMS_VALUE) + (quizavg * QUIZZES_VALUE))*100;

            //rounds the final score to 2 decimal places
            finalscore = Math.Round(finalscore, 2);


            //returns finalscore
            return finalscore;

        }
        /// <summary>
        /// lettergrade method to figure out the letter grade
        /// </summary>
        /// <param name="finalscore"></param>
        /// <param name="grade"></param>
        public void LetterGrade(double finalscore, ref string grade)

        {
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            if (finalscore >= gradea)
            {
                //sets grade value to indicated letter
                grade = "A";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradeaminus)
            {
                //sets grade value to indicated letter
                grade = "A-";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradebplus)
            {
                //sets grade value to indicated letter
                grade = "B+";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradeb)
            {
                //sets grade value to indicated letter
                grade = "B";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradebminus)
            {
                //sets grade value to indicated letter
                grade = "B-";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradecplus)
            {
                //sets grade value to indicated letter
                grade = "C+";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradec)
            {
                //sets grade value to indicated letter
                grade = "C";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradecminus)
            {
                //sets grade value to indicated letter
                grade = "C-";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradedplus)
            {
                //sets grade value to indicated letter
                grade = "D+";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= graded)
            {
                //sets grade value to indicated letter
                grade = "D";
            }
            //nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else if (finalscore >= gradedminus)
            {
                //sets grade value to indicated letter
                grade = "D-";
            }
            //end of nested desicion structure, if finalscore is greater than a specific amount, return the corresponding grade value
            else
            {
                //sets grade value to indicated letter
                grade = "E";
            }
        }
        /// <summary>
        /// sets the textbox value according to the grade aqcuired, shamelessly copied and pasted from my letter grades project.
        /// </summary>
        /// <param name="finalscore"></param>
        /// <param name="grade"></param>
        public void GradeReport(double finalscore, string grade)
        {
        ///     //assings value to the textbox based on grade and letter value.
        ///     txtboxGradeReport.Text = "Your final grade is " + finalscore.ToString("#.##") + "% for a letter grade of " + grade;
        }
      
    }
}
