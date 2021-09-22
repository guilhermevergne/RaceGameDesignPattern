using System;
using System.Collections.Generic;
using RaceGameDesignPattern.BasicTypes;

namespace RaceGameDesignPattern.Factory
{
    class BasicTypeFactory
    {
        public Dictionary<string, BasicType> basicTypes = new Dictionary<string, BasicType>()
        {
            {"Hatch", new Hatch() },
            {"Sedan", new Sedan() },
            {"SUV", new SUV() }
        };
        public BasicType BuildBasicType(string type)
        {
            return basicTypes[type];
        }
    }
}
