// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 2/8/2018
// Project #: 4A
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method adds the messagebox display to the "Welcome Button" that says "Welcome to Trevor's Grade App!"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWelcome_Click(object sender, EventArgs e)
        {
            //displays the message box
            MessageBox.Show("Welcome to Trevor's Grade App!");
        }
        /// <summary>
        /// This method adds the close function to the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the dialog window
            this.Close();
        }
        /// <summary>
        /// Launches the profile form (StudentProfileForm.cs)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfile_Click(object sender, EventArgs e)
        {
            studentProfileForm studentProfile = new studentProfileForm();
            // calls the form's constructor.
            studentProfile.ShowDialog();  //Shows the form as a Dialog
        }
        /// <summary>
        /// Launches the Scoring Methods form. (ScoringMethodsForm.cs)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoringMethods_Click(object sender, EventArgs e)
        {
            //calls the forms constructor
            ScoringMethodsForm scoringMethods = new ScoringMethodsForm();
            //shows the form as a Dialog
            scoringMethods.ShowDialog();
        }
    }
}
