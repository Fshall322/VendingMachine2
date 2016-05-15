using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Doritos // begin class
    {
        private string _productName;
        private double _productPrice;
        private int _productCount;

        public Doritos() // constructor
        {
            _productName = "Doritos";
            _productPrice = 1.00;
            _productCount = 20;
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
