using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class CellPhone
    {
        //field for the brand
        private string _brand;
        //field for the model
        private string _model;
        //field for the price
        private decimal _price;


        //brand property
        public string Brand
        //get and set for the brand property
        { get { return _brand; } set { _brand = value; } }
        //model property
        public string Model
        { get { return _model; } set { _model = value; } }
        //price property
        public decimal Price
        { get { return _price; } set { _price = value; }  }




        /// <summary>
        /// Cosntructor for the class
        /// </summary>
        public CellPhone()
        {
            //initializes brand with an empty string
            _brand = "";
            //initializes model with an empty string
            _model = "";
            //initializes price with a value of zero.
            _price = 0m;


        }

    }
}
