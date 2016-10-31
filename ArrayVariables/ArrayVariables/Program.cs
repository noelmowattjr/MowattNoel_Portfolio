using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //--ARRAYS
            //--Datatype[] arrayName = new dataType[size of array]

            //--Declare array
            int[] bills = new int[3];

            //--Define array
            bills[0] = 103;
            bills[1] = 150;
            bills[2] = 200;

            //--call an item in array
            Console.WriteLine("The water bill for the month is $"+bills[1]);

            //--Total bills
            int total = bills[0]+bills[1]+bills[2];
            Console.WriteLine("My bills this month total to $"+total);

            //--------------------------//
            //--Declare and Define an array
            string[] fruits = new string[] {"Apple","Orange","Peach" };

            //--What is index 1 in array of fruits
            Console.WriteLine("Index 1 is: "+fruits[1]);

            //--Frind length of array
            int fruitSize = fruits.Length;
            Console.WriteLine(fruitSize);

            

        }
    }
}
