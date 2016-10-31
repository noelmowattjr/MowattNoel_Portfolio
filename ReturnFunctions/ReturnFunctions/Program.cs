using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int results = CalcArea(10,2);
            Console.WriteLine("The area of your rectangle is "+results);
            Console.WriteLine("Main func.");

            int tW = 10;
            int tH = 4;
            int two = 2;

            //--Call the CalcAreaTri func
            int resultsTri = CalcAreaTriangle(tW,tH,two );
            Console.WriteLine("The area of your triangle is "+resultsTri);
        }

        //--Calculate the area of a Rectangle w/ return
        public static int CalcArea(int w, int h)
        {
           // int width = 6;
           // int height = 7;

            int area = w * h;
            return area;
        }

        //--Find Area of Triangle
        public static int CalcAreaTriangle(int width, int height, int d)
        {
            return ((width * height) / 2);
        }
    }
}
