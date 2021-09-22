using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.Resources
{
    public class HotWheels : Resource
    {
        public string ResourceName()
        {
            return "HotWheels";
        }
        public void Add(Car car)
        {
            car.resources.Add(this);
            car.atributes["speed"] += 20;
        }
    }
}
