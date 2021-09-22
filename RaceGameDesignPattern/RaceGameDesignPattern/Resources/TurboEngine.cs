using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.Resources
{
    public class TurboEngine : Resource
    {
        public string ResourceName()
        {
            return "TurboEngine";
        }
        public void Add(Car car)
        {
            car.resources.Add(this);
            car.atributes["speed"] += 30;
        }
    }
}
