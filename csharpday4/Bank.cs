using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpday4
{
    class Bank
    {
        public static int dollar;

        static Bank()
        {
            dollar = 100;
        }

        public void setDollar(int d)
        {
            dollar = d;
        }

        public void amount(int a)
        {
            Console.WriteLine("Amount = " + (a * dollar));
        }
    }
}
