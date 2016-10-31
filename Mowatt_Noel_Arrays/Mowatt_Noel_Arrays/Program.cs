using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mowatt_Noel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Name: Noel Mowatt
             Section: 00
             Date: 09/09/2016
             Arrays Assignment
             */

            //Create your own project and call it Lastname_Firstname_Arrays
            //Copy this code inside of this Main section into your Main Section
            //Work through each of the sections

            //Given Number Arrays
            int[] firstArray = new int[4] { 4, 20, 60, 150 };
            double[] secondArray = new double[4] { 5, 40.5, 65.4, 145.98 };

            //Find the total of each array and store it in a variable and output to console

            int sumOfFirstArray = firstArray.Sum();     //--appended Sum() method to firstArray to find total
            double sumOfSecondArray = secondArray.Sum();    //--appended Sum() method to secondArray to find total

            //--Console results
            Console.WriteLine("The total of firstArray is: "+sumOfFirstArray+"\r\nand the total of secondArray is: "+sumOfSecondArray);

            //Calculate the average of each array and store it in a variable and output to console

            //--Calculating & storing the averages for both int and double arrays in their respective variables
            int meanOfFirstArray = sumOfFirstArray / firstArray.Length;
            double meanOfSecondArray = sumOfSecondArray / secondArray.Length;

            //--Console the results
            Console.WriteLine("The average for firstArray is: "+meanOfFirstArray+"\r\nand average for secondArray is: "+meanOfSecondArray);


            /*
               Create a 3rd number array.  The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then 
                 store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your 
                 new array at the index#0 spot.
                -Repeat this for each index #.
                -After you have the completed new array, output this to the Console.
             */
             

            //--Added indices of arrays to create new values..store new values in third array 
            double a = firstArray[0] + secondArray[0];
            double b = firstArray[1] + secondArray[1];
            double c = firstArray[2] + secondArray[2];
            double d = firstArray[3] + secondArray[3];
            
            //--Store new values in thirdArray
            double[] thirdArray = new double [4] {a, b, c, d };

            //--Console thirdArray
            Console.WriteLine("thirdArray: "+thirdArray);
            
            
            //Given String Array
            string[] MixedUp = new string[] { "but the lighting of a", "Education is not", "fire.", "the filling", "of a bucket," };


            /*
               Given an array of strings.  You must create a string variable that puts the 
               items in the correct order to make a complete sentence.
                -Use each item in the array.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this string to the console.
             */

            //--Organized MixedUp array and store them for better tracking
            string one = MixedUp[1];
            string two = MixedUp[3];
            string three = MixedUp[4];
            string four = MixedUp[0];
            string five = MixedUp[2];

            //--Console results
            Console.WriteLine(one+" "+two+" "+three+" "+four+" "+five);
      
        }
    }
}
