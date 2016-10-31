using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y = 12;
            if (x > 10 || y/x > 1)
            {
                Console.WriteLine("y minus x is: "+(y-x));
            }
            else
            {
                Console.WriteLine(y);
            }

            /*  Basic Calculator using Do While Loop
             
             */
            
            do
            {
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                int sum = a + b;
                Console.WriteLine("The sum of {0} + {1} equals to {2}", a, b, sum);

            } while (false);
        }
    }
}
