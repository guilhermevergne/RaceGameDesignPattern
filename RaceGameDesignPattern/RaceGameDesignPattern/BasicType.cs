using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern
{
    public interface BasicType
    {
        public string TypeName();
        public double BaseSpeed();
        public double BaseStability();
    }
}