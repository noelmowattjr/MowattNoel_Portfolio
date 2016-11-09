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
            //--findMinAndMax();
        }

        /*  A method for finding the min and max of an array of numbers */

        static Tuple<int, int> findMinAndMax(int [] numbers)
        {
            //--my holders for my min and max number values
            int minNow = numbers[0];
            int maxNow = numbers[0];

            //--use n to iterate through array called numbers
            foreach (int n in numbers) {

            }

            return Tuple.Create(1,2);
        }
    }
}
