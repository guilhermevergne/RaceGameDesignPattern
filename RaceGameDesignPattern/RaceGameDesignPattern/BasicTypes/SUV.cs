using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.BasicTypes
{
    public class SUV : BasicType
    {
        public string TypeName()
        {
            return "SUV";
        }
        public double BaseSpeed()
        {
            return 30;
        }
        public double BaseStability()
        {
            return 50;
        }
    }
}
