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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMyGradeApp
{
    class Course
    {
        //establishing the backing fields
        private string _courseName;
        //establishing the backing fields
        private string _semester;
        //establishing the backing fields
        private string _instructor;
        //establishing the backing fields
        private double _grade;
        //establishing the backing fields
        private string _lettergrade;
            
        /// <summary>
        /// paramaterless constructor
        /// </summary>
        public Course()
        {
            //declaring default values for my backing fields
            _lettergrade = "";
            //declaring default values for my backing fields
            _semester = "";
            //declaring default values for my backing fields
            _instructor = "";
            //declaring default values for my backing fields
            _grade = 0;
            //declaring default values for my backing fields
            _courseName = "";
        }

        /// <summary>
        /// paramaterized constructor for the class, to pass the backing fields.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="semester"></param>
        /// <param name="instructor"></param>
        /// <param name="lettergrade"></param>
        /// <param name="grade"></param>
        public Course(string name, string semester, string instructor, string lettergrade, double grade)
        {

            //setting non-default values for my backing fields
            _courseName = name;
            //setting non-default values for my backing fields
            _semester = semester;
            //setting non-default values for my backing fields
            _instructor = instructor;
            //setting non-default values for my backing fields
            _lettergrade = lettergrade;
            //setting non-default values for my backing fields
            _grade = grade;
        }
        /// <summary>
        /// establishing coursename as a property
        /// </summary>
        public string CourseName
        {
            //get and set for coursename.
            get { return _courseName; }
            set { _courseName = value; }
        }

        /// <summary>
        /// establishing semester as a property
        /// </summary>
        public string Semester
        {
            //get and set for semester
            get { return _semester; }
            set { _semester = value; }
        }
        /// <summary>
        /// establishing instructor as a property
        /// </summary>
        public string Instructor
        {
            //get and set for instructor
            get { return _instructor; }
            set { _instructor = value; }
        }

        /// <summary>
        /// establishing lettergrade as a property
        /// </summary>
        public string LetterGrade
        {
            //get and set for lettergrade
            get { return _lettergrade; }
            set { _lettergrade = value; }
        }

        
        /// <summary>
        /// establishing grade as a property
        /// </summary>
        public double Grade
        {
            //get and set for Grade
            get { return _grade; }
            set { _grade = value; }
        }
        /// <summary>
        /// override for tostring, pulls and concatenates the backing fields together
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //establishing the string variable and concatenating the data
            string courseReport = _courseName + "," + _semester + "," + _instructor + "," + _grade + "%"+"," + _lettergrade;
            //returns the coursereport variable to the class.
            return courseReport;
        }


    }
}
