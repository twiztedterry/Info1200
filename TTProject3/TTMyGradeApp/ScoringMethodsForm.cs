// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 2/7/2018
// Project #: 3A
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
    public partial class ScoringMethodsForm : Form
    {
        public ScoringMethodsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When pressed, the close button will close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
        /// <summary>
        /// When pressed, the clear button will clear all text from all textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the project 1 textbox
            txtboxProject1Score.Text = "";
            //clears the project 2 textbox
            txtboxProject2Score.Text = "";
            //clears the exam 1 textbox
            txtboxExam1Score.Text = "";
            //clears the exam 2 textbox
            txtboxExam2Score.Text = "";
            //clears the assignment 1 textbox
            txtboxAssignment1Score.Text = "";
            //clears the assignment 2 textbox
            txtboxAssignment2Score.Text = "";
            //clears the weighted result textbox
            txtboxWeightedResult.Text = "";
            //clears the cumulative result textbox
            txtboxCumulativeResult.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //setting variables for each textbox
            int Project1, Project2, Exam1, Exam2, Assignment1, Assignment2;
            //setting variables for each max grade
            int Project1Max, Project2Max, Exam1Max, Exam2Max, Assignment1Max, Assignment2Max;
            //setting variables for the Weighted and Cumulative Grade boxes and Categories
            double CumulativeGrade, WeightedGrade, ProjectsWeight, ExamsWeight, AssignmentsWeight, Maxpoints, SumTotalGrades, CategoryCount, ProjectsCategoryAvg, ExamsCategoryAvg, AssignmentsCategoryAvg;
            
            //assigns value to the CategoryCount variable
            CategoryCount = 3;
            //assigns value to the project 1 variable
            Project1 = int.Parse(txtboxProject1Score.Text);
            //assigns value to the project 2 variable
            Project2 = int.Parse(txtboxProject2Score.Text);
            //assigns value to the Exam1 variable
            Exam1 = int.Parse(txtboxExam1Score.Text);
            //assigns value to the Exam2 variable
            Exam2 = int.Parse(txtboxExam2Score.Text);
            //assigns value to the Assignment1 variable
            Assignment1 = int.Parse(txtboxAssignment1Score.Text);
            //assigns value to the Assignment2 variable
            Assignment2 = int.Parse(txtboxAssignment2Score.Text);
            //assigns value to the Project1Max variable
            Project1Max = int.Parse(lblProject1MaxPoints.Text);
            //assigns value to the project2max variable
            Project2Max = int.Parse(lblProject2MaxPoints.Text);
            //assigns value to the Exam1Max variable
            Exam1Max = int.Parse(lblExam1MaxPoints.Text);
            //assigns value to the Exam2Max variable
            Exam2Max = int.Parse(lblExam2MaxPoints.Text);
            //assigns value to the Assignment1Max variable
            Assignment1Max = int.Parse(lblAssignment1MaxPoints.Text);
            //assigns value to the assignment2max variable
            Assignment2Max = int.Parse(lblAssignment2MaxPoints.Text);
            //assigns value to the Maxpoints variable
            Maxpoints = (Project1Max + Project2Max + Assignment1Max + Assignment2Max + Exam1Max + Exam2Max);
            //assigns value to the SumTotalGrades variable
            SumTotalGrades = (Project1 + Project2 + Exam1 + Exam2 + Assignment1 + Assignment2);
            //assigns value to the cumulativegrade variable
            CumulativeGrade = SumTotalGrades / Maxpoints;
            //assigns value to the ProjectCagetoryAvg variable
            ProjectsCategoryAvg = ((Double)Project1 + Project2) / ((Double)Project1Max + Project2Max);
            //assigns value to the ExamsCategoryAvg variable
            ExamsCategoryAvg = ((Double)Exam1 + Exam2) / ((Double)Exam2Max + Exam1Max);
            //assigns value to the AssignmentsCategoryAvg variable
            AssignmentsCategoryAvg = ((Double)Assignment1 + Assignment2) / ((Double)Assignment1Max + Assignment2Max);
            //assigns value to the ProjectsWeight variable
            ProjectsWeight = 0.45;
            //assigns value to the examsweight variable
            ExamsWeight = .3;
            //assigns value to the assignemntsweight variable
            AssignmentsWeight = .25;
            //assigns value to the weightedgrade variable
            WeightedGrade = (ProjectsCategoryAvg * ProjectsWeight) + (ExamsCategoryAvg * ExamsWeight) + (AssignmentsCategoryAvg * AssignmentsWeight);

        
            //sets the value of the results textboxes to display the final total cumulative grade
            txtboxCumulativeResult.Text = CumulativeGrade.ToString("P");
            //sets the value fo the results textbox to display the final total weighted grade.
            txtboxWeightedResult.Text = WeightedGrade.ToString("p");
            
        }
    }
}
