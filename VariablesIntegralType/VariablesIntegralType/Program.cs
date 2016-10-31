using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesIntegralType
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Numeric Data Types are separated into 2 categories
            //--Integral & Floating Point/Decimals 

            //--Integral types
            //--sbyte - signed bit are numbers between -128 to 127
            sbyte exS = 50;
            Console.WriteLine("sbyte examle:" + exS);

            //--short: are numbers between -32767 to 32767
            short exShort = 30500;
            Console.WriteLine("short example:" + exShort);

            //--int: are numbers between -2,147,483,647 to 2,147,483,647
            int exInt = 1500400300;
            Console.WriteLine("int example:" + exInt);

            //--long: are numbers up to nine quintillion
            long longEx = 1900800777600500400;
            Console.WriteLine("long example:" + longEx);

            //-- NUMERICAL FLOATING TYPES --//

            //--double
            double exDouble = 100.1234;
            Console.WriteLine("\r\ndouble example:" + exDouble);

            //--float
            //--It defaults to float, we cast as float with suffix 'f'
            float exFloat = 13.9333f;
            Console.WriteLine(exFloat);

            //--decimal -use this type for money
            //--it defaults to double, we cast as decimal with suffix 'M'
            decimal exDecimal = 500.28M;
            Console.WriteLine(exDecimal);

            //-- UNSIGNED & SIGNED Values --//
            
            //--Unsigned -only positive values
            byte exByte = 255;      //--byte 0 to 255
            Console.WriteLine(exByte);

            ushort exUshort = 65000;    //--ushort 32,000 to 65,000
            Console.WriteLine(exUshort);

            uint exUint = 1005001002;   //--uint up to 4billion
            Console.WriteLine(exUint);

            ulong exUlong = 9009009009009009009;   //--ulong up to 18 quintillion
            Console.WriteLine(exUlong);

        }
    }
}
