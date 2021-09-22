using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.BasicTypes
{
    public class Hatch : BasicType
    {
        public string TypeName()
        {
            return "Hatch";
        }
        public double BaseSpeed()
        {
            return 50;
        }
        public double BaseStability()
        {
            return 30;
        }
        
    }
}
