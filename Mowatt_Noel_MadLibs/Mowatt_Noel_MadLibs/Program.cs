using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mowatt_Noel_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Noel Mowatt
               09/07/2016
               SDI - Section 00
               MadLibs Assignment
             */

            //--Ask for age
            Console.WriteLine("How old are you?");
            //--catch
            string ageStr = Console.ReadLine();

            //--candy
            Console.WriteLine("How many pieces of candy do you have?");
            string numCandyStr = Console.ReadLine();

            //--Marriages
            Console.WriteLine("How many marriags have you had?");
            string numMarriagesStr = Console.ReadLine();
            
            //--Shoe size
            Console.WriteLine("What is your shoe-size?");
            //-catch
            string shoeSizeStr = Console.ReadLine();

            //--Favorite color?
            Console.WriteLine("What is your favoite color?");
            //--Catch color
            string colorStr = Console.ReadLine();

            //--Birth
            Console.WriteLine("Where were you born?");
            string birthPlaceStr = Console.ReadLine();

            //--Mother's first name
            Console.WriteLine("What is your mom's first name?");
            string momFirstNameStr = Console.ReadLine();

            //--Convert all string numbers to int--//
            //--Age
            int ageInt;
            int.TryParse(ageStr, out ageInt);

            //--number of candy
            int candyInt;
            int.TryParse(numCandyStr, out candyInt);

            //--marriages
            int marriagesInt;
            int.TryParse(numMarriagesStr, out marriagesInt);

            //--Shoe size
            int shoeSizeInt;
            int.TryParse(shoeSizeStr, out shoeSizeInt);
            //-------------------------------------------//

            //--Our Madlib Story
            Console.WriteLine("Hi, my name is...hmm never mind that. All you need to know is that I like to think");
            Console.WriteLine("that I am "+ageInt+"years old but I am really 51 haha. Anyhow, every morning before");
            Console.WriteLine("I get out of bed I love to eat candy, perhaps "+candyInt+" or 35, depending on my mood.");
            Console.WriteLine("But on a side note, I love reading up on aricles about the decline of marriage in our culture,");
            Console.WriteLine("considering I've only been married " + marriagesInt + " time. Moreover, I think I got a devorce because");
            Console.WriteLine("of my shoe-size which is probably "+shoeSizeInt+" in men. Furthermore, I may have gotten a divorce because I love");
            Console.WriteLine("the color "+colorStr+" sad, I know. Ok let me let you where I was born. I was born in a");
            Console.WriteLine("garbage can at some airport in " + birthPlaceStr+". I was born to "+momFirstNameStr+" so beautiful.");
            Console.WriteLine("But it was nice talking to you, I've go to go now.");
        }
    }
}
