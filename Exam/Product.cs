using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Product
    {
        protected string productId;
        protected string productName;
        protected double productPrice;

        public Product(string id, string name, double price)
        {
            productId = id;
            productName = name;
            productPrice = price;
        }

        public abstract double ComputeTax();
    }
}
