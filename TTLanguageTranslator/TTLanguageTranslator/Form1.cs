using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTLanguageTranslator
{
    public partial class LanguageTranslatorForm : Form
    {
        public LanguageTranslatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button changes the displayed text to "Buenos Dias"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       private void btnSpanish_Click(object sender, EventArgs e)
        {
           //Command to change the label text
           lblTranslation.Text = "Buenos Dias";
        }
       /// <summary>
       /// This button changes the displayed text to "Guten Morgen"
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnGerman_Click(object sender, EventArgs e)
        {
            //Command to change the label text
            lblTranslation.Text = "Guten Morgen";
        }
        /// <summary>
        /// This button changes the displayed text to "Buongiorno"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItalian_Click(object sender, EventArgs e)
        {
            //Command to change the label text
            lblTranslation.Text = "Buongiorno";
        }
        /// <summary>
        /// Adds the close command to the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
