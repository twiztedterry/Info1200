using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 02/07/2018
//Assignment #: Participation 7
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace TTLoanQualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When pressed, the "Exit" button will close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();   
        }
        /// <summary>
        /// When pressed, the "clear" button will clear the text in the tenure and salary boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears the salary text box
            txtboxSalary.Text = "";
            // clears the tenure text box
            txtboxTenure.Text = "";
        }
        /// <summary>
        /// When pressed, the "Check Qualifications" button will check to see if the tenure and salary boxes meet certain conditions 
        /// (2+ years on tenure, 40k salary), with a seperate message being displayed for each outcome.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Names the salary variable
            decimal salary;
            //Names the Tenure variable
            int tenure;

            //validation testing for the text box "salary"
            if(decimal.TryParse(txtboxSalary.Text, out salary))
            {
                //validation texting for the text box "tenure"
                if(int.TryParse(txtboxTenure.Text, out tenure))
                {
                    // Naming the constants
                    //names the MINIMUM SALARY constant
                    const decimal MINIMUM_SALARY = 40000M;
                    //names the tenure constant
                    const int TENURE = 2;
                    //Test the minimum salary entry to see if it's greater or equal to the 40k.
                    if(salary>=MINIMUM_SALARY)
                    {
                        //if salary is accepted and above 40k, check the tenure entry to see if it's greater or equal to 2
                        if(tenure>=TENURE)
                        {
                            //display the message "You qualify for the loan" on the decision box.
                            txtboxDecision.Text="You qualify for the loan";
                            
                        }
                        //if the tenure entry is not greater or equal to 2, display the message "minimum years at job not met" in the decision box.
                        else
                        {
                            txtboxDecision.Text="Minimum years at job not met";
                        }
                    }
                    //if the salary entry is not greater or equal to 40k, display the message "Minimum salary requirement not met" in the deicion box.
                    else
                    {
                        txtboxDecision.Text="Minimum salary requirement not met";
                    }
   
                }
                //if the tenure box has an invalid entry, display the error message "Input not valid for years at current job" in a messagebox. 
                else
                {
                    //displays the error textbox if the validation testing fails
                    MessageBox.Show ("Input not valid for Years at current job");
                }
                
            }
            //if the salary box has an invalid entry, display the error message "Input not valid for salary" in a messagebox.
            else
            {
                MessageBox.Show("Input not valid for salary");
            }         
        }
    }
}
