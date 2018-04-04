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
using System.Threading;
using System.Media;
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
    public partial class QuizTimerForm : Form
    {
        public QuizTimerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When pressed, the exit button will close the dialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the window
            this.Close();
        }
        /// <summary>
        /// When clicked, the "Reset" button will clear all boxes and return all settings to their default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //sets the radio button to the up value
            radiobtnUp.Select();
            
            //sets the seconds value to 0
            txtboxSeconds.Text = "";
            
            //sets the focus on the seconds box
            txtboxSeconds.Focus();
            
            //unchecks the alarm box.
            chkboxAlarm.Checked = false;

            //sets the color of the label back to the system default
            lblTimer.BackColor = SystemColors.Control;


        }
        /// <summary>
        /// When clicked, will either count up or down the given amount of seconds based on the options chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //declares seconds variable
            int seconds;
            
            //declares count variable
            int count = 0;
            
            //declares the constant for the sleep timer
            const int SLEEP = 1000;
            
            //declares a cosntant for the beep number
            const int BEEP = 3;

            //declares max and min constants
            const int MAX = 3599;
            const int MIN = 1;
            
            //establishes the "play" variable, used to count the number of rings.
            int play = 0;

            //sets the color of the label back to the system default
            lblTimer.BackColor = SystemColors.Control;

        

            //tryparse to ensure valid text in the seconds box
            if (int.TryParse(txtboxSeconds.Text, out seconds))
            {
                //if statement to catch values that are too high or too low.
                if (seconds >= MAX || seconds < MIN)
                {
                    //messagebox that displays exception message
                    MessageBox.Show("Please enter a number between 1 and 3599");

                    //sets the seconds value to 0
                    txtboxSeconds.Text = "";

                    //sets the focus on the seconds box
                    txtboxSeconds.Focus();

                    //clears the time label
                    lblTimer.Text = "";

                    //sets the color of the label back to the system default
                    lblTimer.BackColor = SystemColors.Control;

                    //cancels the method, returning to the previous method executed.
                    return;
                }
                     //if statement to check the value of the radio button, and execute if "up" checked.
                     if (radiobtnUp.Checked)
                     {
    
                         //while loop to count up to the entered number.
                          while (seconds >= count)
                        {
                        
                            //converts the up count as a mm:ss display
                            TimeSpan myTime = new TimeSpan(0, 0, count);
                        
                            //assigns the mm:ss display to the lbltimer
                            lblTimer.Text = myTime.ToString(@"mm\:ss");
                        
                            //redraws the dialog
                            Application.DoEvents();
                        
                            //increments the count
                            count++;
                        
                            //sleeps for 1000ms (1s)
                            Thread.Sleep(SLEEP);

                        //if count that checks to see if the seconds are the same as the "Count" and if the checkbox alarm is checked.
                        if (count > seconds)
                             {
                                //sets the timer to a different color
                                lblTimer.BackColor = Color.Red;
                                //redraws the dialog
                                Application.DoEvents();

                                if (chkboxAlarm.Checked)
                                {
                                    //while the play variable is less than the beep variable                       
                                    while (play < BEEP)
                                    {

                                        //play the beep sounds
                                        SystemSounds.Beep.Play();
                                        //wait 1000ms
                                        Thread.Sleep(SLEEP);
                                        //increment the play variable by 1
                                        play++;
                                        }
                                     }

                            }
                        
                        }
                    
                }
                //if statement to check the value of the radio button, and execute if "down" checked.
                if (radiobtnDown.Checked)
                {

                    //while loop to count up to the entered number.
                    while (seconds >= count)
                    {

                        //converts the up count as a mm:ss display
                        TimeSpan myTime = new TimeSpan(0, 0, seconds);
                        
                        //assigns the mm:ss display to the lbltimer
                        lblTimer.Text = myTime.ToString(@"mm\:ss");
                        
                        //redraws the dialog
                        Application.DoEvents();
                        
                        //decrements the seconds
                        seconds--;
                        
                        //sleeps for 1000ms (1s)
                        Thread.Sleep(SLEEP);

                        //if count that checks to see if the seconds are the same as the "Count" and if the checkbox alarm is checked.

                        if (count > seconds)
                        {
                            //sets the timer to a different color
                            lblTimer.BackColor = Color.Red;
                            //redraws the dialog
                            Application.DoEvents();

                            if (chkboxAlarm.Checked)
                            {
                                //while the play variable is less than the beep variable                       
                                while (play < BEEP)
                                {

                                    //assigns the mm:ss display to the lbltimer
                                    lblTimer.Text = myTime.ToString(@"mm\:ss");

                                    //play the beep sounds
                                    SystemSounds.Beep.Play();

                                    //wait 1000ms
                                    Thread.Sleep(SLEEP);

                                    //increment the play variable by 1
                                    play++;
                                }
                            }

                        }
                    }
                    


                }

                
            }
            
        
            
            
        
        //else statement to catch exceptions
        else
        {
            //displays the messagebox in case of exception.
            MessageBox.Show("Invalid number entered for time, please enter whole numbers only.");

            //sets the seconds value to 0
            txtboxSeconds.Text = "";

            //sets the focus on the seconds box
            txtboxSeconds.Focus();

            //clears the time label
            lblTimer.Text = "";

            //sets the color of the label back to the system default
            lblTimer.BackColor = SystemColors.Control;

        }
     }
}
}
