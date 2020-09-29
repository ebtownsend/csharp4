using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpday4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] nums = {
                2,7,10,15,3,1
            };

            int max = nums[0];
            foreach (int value in nums)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            Console.WriteLine(max);

            // Static Methods
            One.msg();

            // Static Variables
            Bank hsbc, nbs;
            hsbc = new Bank();
            hsbc.amount(2);
            hsbc.setDollar(200);

            nbs = new Bank();
            nbs.amount(2);

            // String Manipulation
            StringManip s = new StringManip();
            s.vertical("General Kenobi");

            s.wordCount("hello my friends");

            s.wordVertical("Hello There");

            s.reverseSentence("Hello There");

            s.reverse2("Hello My Friends");

            s.reverse3("SHAFEEQ IS BACK");

            s.finalReverse("Hello World");

            s.longestWord("Hello Thank you I am fine How are You friend" );

            Console.ReadKey();
        }
    }
}
