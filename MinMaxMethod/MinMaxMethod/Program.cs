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
            //--Method returns a tuple of the minimal and maximum value of array
            findMinAndMax(new int[] {1,2,3,4,5 });

            //--Print min and max to console
            Console.WriteLine("Results: "+ findMinAndMax(new int[] { 55,20,100,99,29,88 }));
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
