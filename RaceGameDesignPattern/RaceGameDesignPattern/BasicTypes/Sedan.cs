using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern
{
    public class Sedan : BasicType
    {
        public string TypeName()
        {
            return "Sedan";
        }
        public double BaseSpeed()
        {
            return 50;
        }
        public double BaseStability()
        {
            return 10;
        }
    }
}
