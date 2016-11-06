using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class ArithmeticOperators
    {
        //--Objects--//
        private string addition = "+";
        private string substraction = "-";
        private string multiplication = "*";
        private string division = "/";
        
        //----------My Public Constructors----------//
        //--Make objects accessible to Program class
        public string GetAddition(){ return this.addition; }
        public string GetSubtraction() { return this.substraction; }
        public string GetMultiplication() { return this.multiplication; }
        public string GetDivision() { return this.division; }
        
    }

    class EqualOperator
    {
        //--Equal object
        private string equal = "=";

        //--Constructor 
        public string GetEqual()
        {
            return this.equal;
        }
    }

    

}
