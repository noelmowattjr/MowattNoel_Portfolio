using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //--MATH CLASS

            //--Math.Ceiling - always rounds up to nearest integer
            Console.WriteLine(Math.Ceiling(100.05));    //101

            //--Math.Floor - always rounds down to nearest integer
            Console.WriteLine(Math.Floor(100.05));  //--100

            //--Math.Round() - Normal rounding
            Console.WriteLine(Math.Round(89.8));    //--90

        }
    }
}
