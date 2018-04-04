//Name: (Trevor Terry)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Crandall)
//Date: 1/12/2018
//Project #: 2
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTLanguageTranslator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LanguageTranslatorForm());
        }
    }
}
