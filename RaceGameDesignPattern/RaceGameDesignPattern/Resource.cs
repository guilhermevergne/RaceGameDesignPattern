using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern
{
    public interface Resource
    {
        public string ResourceName();
        public void Add(Car car);
    }
}
