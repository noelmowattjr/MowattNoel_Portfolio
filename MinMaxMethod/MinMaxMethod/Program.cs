using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Ask user to enter a series of numbers separated by comma
            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();

            var resultz = findMinAndMax(new int[] { 20,30,900,800,1,0,909100  });

            //--Print min and max to console
            Console.WriteLine("Results: {0}", resultz);
        }

        /*  A method for finding the min and max of an array of numbers */
        static Tuple<int, int> findMinAndMax(int [] numbers)
        {
            //--my holders for my min and max number values
            int minNow = numbers[0];
            int maxNow = numbers[0];

            //--use n to iterate through array called numbers
            foreach (int n in numbers) {

                //--Filter out the min and max
                if (n < minNow)
                {
                    minNow = n;
                }
                else if (n > maxNow)
                {
                    maxNow = n;
                }
            }

            return Tuple.Create(minNow, maxNow);
        }
    }
}
