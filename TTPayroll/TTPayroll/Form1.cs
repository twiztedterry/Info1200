//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 1/26/2018
//Assignment #: Participation 6
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
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

namespace TTPayroll
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
            comboOvertimeRate.SelectedIndex = 0; // sets the starting "Default Value" selected by the OvertimeRate Combo box.

        }

        /// <summary>
        /// when clicked, this button will exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close(); // exits the program
        }
        /// <summary>
        /// When clicked, clears the boxes of all information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxGrossPay.Text = ""; // clears the gross pay box
            txtboxHoursWorked.Text = ""; // clears the hours worked box
            txtboxPayRate.Text = ""; // clears the payrate box
        }
        /// <summary>
        /// When clicked, the Calculate button will pull information from all textboxes, convert to decimal
        /// multiply the hours worked under 40 by the base pay rate, and the hours above 40 by the rate stored in the "OvertimeRate" variable selected with our group box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                //named constants
                const decimal BASE_HOURS = 40m;

                //local variables, hoursworked, payrate, basepay, overtimehours, overtimepay, grosspay, overtimerate.
                decimal hoursWorked, payRate, basePay, overtimeHours, overtimePay, grossPay, overtimeRate;

                //converts the combobox option into a decimal and stores it in the overtimeRate variable.
                overtimeRate = decimal.Parse(comboOvertimeRate.SelectedItem.ToString());

                //establishes the value associated with the hours worked variable
                hoursWorked = decimal.Parse(txtboxHoursWorked.Text);

                //establishes the value associated with the pay rate variable
                payRate = decimal.Parse(txtboxPayRate.Text);

                //determine gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    //Calculate base pay
                    basePay = hoursWorked * payRate;

                    //Calculate overtime hours
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate overtime pay
                    overtimePay = payRate * overtimeRate;

                    //Calculate total gross pay
                    grossPay = basePay + (overtimeHours * overtimeRate);
                }

                else
                {
                    //calculate gross pay
                    grossPay = hoursWorked * payRate;
                }
                //display gross pay
                txtboxGrossPay.Text = grossPay.ToString("c");
                 
            }

            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

    }
}
