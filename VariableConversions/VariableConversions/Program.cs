using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableConversions
{
    class Program
    {
        static void Main(string[] args)
        {
             //--Implicit Conversions
            //--smaller datatypes to a larger one

            short num = 23456;
            Console.WriteLine("short type:" + num);

            //--implicitly convert
            int bigNum = num;
            Console.WriteLine("int type:" + bigNum);

            //--Explicit Conversions
            //--larger datatypes to a smaller one (data loss)

            double x = 1234.56;
            Console.WriteLine("x pre-converted" + x);

            //--convert to int
            int xConverted = (int)x;
            Console.WriteLine("x converted:" + xConverted);

            //--HELPER CLASS EXAMPLES

            //--Convert Class
            string strValue = "19";

            //convert strValue to number then multiply
            int strValueConvertedToInt = Convert.ToInt32(strValue);

       

        }
    }
}
