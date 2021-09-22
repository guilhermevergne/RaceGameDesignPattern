using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern.Resources
{
    public class SuspensionControl : Resource
    {
        public string ResourceName()
        {
            return "SuspensionControl";
        }
        public void Add(Car car)
        {
            car.resources.Add(this);
            car.atributes["stability"] += 5;
        }
    }
}
