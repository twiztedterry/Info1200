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
        //adding the backing field for coursename
        private string _courseName;
        //backing field for semester
        private string _semester;
        //backing field for instructor
        private string _instructor;
        //backing field for grade
        private double _grade;
        //backing field for lettergrade
        private string _letterGrade;

        
        /// <summary>
        /// default constructor
        /// </summary>
        public Course()
        {
            //default values
            _courseName = ""; _semester = ""; _instructor = ""; _grade = 0.0; _letterGrade = "";
            
            
        }
        /// <summary>
        /// constructor that passes in the course name
        /// </summary>
        /// <param name="coursename"></param>
        public Course(string coursename)
        {
            //assigns the coursename property to the coursename variable
            _courseName = coursename;
        }

        public Course(string semester, string instructor)
        {
            _semester = semester;

        }




        /// <summary>
        /// constructor that passes in the grade
        /// </summary>
        /// <param name="grade"></param>
        public Course(double grade)
        {
            _grade = grade;
        }




    }
}
