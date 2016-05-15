using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class SnickersReg //class 
    {
        private string _productName;
        private int _productCount;
        private double _productPrice;

        public SnickersReg() // constructor
        {
            _productName = "Snickers";
            _productPrice = 1.25;
            _productCount = 10;
        }

        public string ProductName // method
        {
            get{ return _productName; }
            set { _productName = value; }
        }

        public double ProductPrice // method
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public  int ProductCount // method
        {
            get { return _productCount; }
            set { _productCount = value;}
        }
    }
}
