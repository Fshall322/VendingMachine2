using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Hersey //class
    {
        private string _productName;
        private double _productPrice;
        private int _productCount;

        public Hersey() // constructor
        {
            _productName = "Hersey";
            _productPrice = 1.25;
            _productCount = 10;
        }

        public string ProductName // method 
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public double ProductPrice // method 
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public int ProductCount // method 
        {
            get { return _productCount; }
            set { _productCount = value; }
        }
    }
}
