using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengerArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            AvengersRoster();
        }

        public static void AvengersRoster()
        {
            ArrayList avengersList = new ArrayList() { "Captain America", "Iron Man" };

            avengersList.Add("The Incredible Hulk");
            avengersList.Add("Black Widow");
        }
    }
}
