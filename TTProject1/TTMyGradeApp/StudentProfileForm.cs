// Name: (Trevor Terry)
// Class: (INFO 1200)
// Section: (001)
// Professor: (Crandall)
// Date: 1/17/2018
// Project #: 1A
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
//Basic Form code, creates the form
namespace TTMyGradeApp
{
    public partial class studentProfileForm : Form
    {
        public studentProfileForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds the close button logic to the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the window
            this.Close();
        }
    }
}
