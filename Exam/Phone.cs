using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Phone : Product
    {
        public Phone(string id, string name, double price) : base(id, name, price)
        {
        }

        public override double ComputeTax()
        {
            return productPrice * 10 / 100;
        }
    }
}
