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
        private string addition = "add";
        private string substraction = "subtract";
        private string multiplication = "multiply";
        private string division = "divide";
        
        //--Make objects accessible to Program class
        public string GetAddition(){ return this.addition; }
        public string GetSubtraction() { return this.substraction; }
        public string GetMultiplication() { return this.multiplication; }
        public string GetDivision() { return this.division; }

    }
}
