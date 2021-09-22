using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.Resources
{
    public class ABS : Resource
    {
        public string ResourceName()
        {
            return "ABS";
        }
        public void Add(Car car)
        {
            car.resources.Add(this);
            car.atributes["stability"] += 5;
        }
    }
}
