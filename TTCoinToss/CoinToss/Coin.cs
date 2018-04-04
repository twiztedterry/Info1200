using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    /// <summary>
    /// class to manage the coin flip
    /// </summary>
    public class Coin
    {
        //establishing the variables for sideup and the random call.
        private string sideup = "";
        Random rand = new Random();

        /// <summary>
        /// Constructor Method for the class.
        /// </summary>
        public Coin()
        {
            sideup = "Heads";

        }
        /// <summary>
        /// Method for flipping the coin and returning a value
        /// </summary>
        /// <returns></returns>
        public string Toss()
        {
            //if statement that checks a random number and returns heads if it's zero
            if (rand.Next(2) == 0)
            {
                //sets sideup to heads
                sideup = "Heads";
                             
                
            }
            //if it's not zero, return tails
            else
            {
                //sets sideup to tails
                sideup = "Tails";
            }
            //returns sideup
            return sideup;
                               
        }
        /// <summary>
        /// returns a random heads or tails if toss is called first.
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {
            //returns the value associated with sideup
            return sideup;
        }

    }
}
