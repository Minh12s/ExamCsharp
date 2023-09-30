using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Program
    {
         static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Book("1", "Book 1", 100);
            products[1] = new Book("2", "Book 2", 200);
            products[2] = new Book("3", "Book 3", 300);
            products[3] = new Phone("4", "Phone 1", 400);
            products[4] = new Phone("5", "Phone 2", 500);

            double totalBookTax = 0;
            double totalPhoneTax = 0;

            foreach (Product product in products)
            {
                if (product is Book)
                {
                    totalBookTax += product.ComputeTax();
                }
                else if (product is Phone)
                {
                    totalPhoneTax += product.ComputeTax();
                }
            }

            Console.WriteLine("Total tax for Book: " + totalBookTax);
            Console.WriteLine("Total tax for Phone: " + totalPhoneTax);
        }
    }

}
