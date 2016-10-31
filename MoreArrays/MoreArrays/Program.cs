using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //--call nameArrayList func
            nameArrayListFunction();
        }

        public static void nameArrayListFunction()
        {
            //--Create an Array list
            //--and add element to array
            ArrayList studentList = new ArrayList() {"Noel"};

            //--Add new elements to array
            studentList.Add("Marium");
            studentList.Add("Joshua");
            studentList.Add("Jorge");

            //--Insert items to our array
            studentList.Insert(0, "Sharon");
            studentList.Insert(2, "Noel Mowatt, Jr.");

            //--Remove a name from array
            studentList.Remove("Noel");
            studentList.Remove("Joshua");

            //--CLEARS all items in array
            //--studentList.Clear();

            //--using the Contains() method
            if (studentList.Contains("Marium"))
            {
                Console.WriteLine("Contains Marium!");
            }

            //--Console all items in array to console
            Console.WriteLine("List of students total to "+studentList.Count+" and include:\r\n"+studentList);

            //--For Each loop to cycle through our array
            //--and prints items in our array
            foreach (string eachName in studentList)
            {
                Console.WriteLine("Student "+eachName);
            }

            //--ArrayList

            //--Print a single item from array
            Console.WriteLine("Index 1: "+studentList[1]);

            //--Set an item at index
            studentList[1] = "Noel \'gunior\' Mowatt, Jr.";
            Console.WriteLine(studentList[1]);

            //--Capacity - the # of items an array can store
            Console.WriteLine("Capacity: "+studentList.Capacity);
           
            
        }
    }
}
