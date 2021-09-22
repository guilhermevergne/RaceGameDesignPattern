using System;
using System.Collections.Generic;
using System.Text;
using RaceGameDesignPattern.Resources;

namespace RaceGameDesignPattern.Factory
{
    class ResourceFactory
    {
        public Dictionary<string, Resource> resources = new Dictionary<string, Resource>()
        {
            {"ABS", new ABS() },
            {"HotWheels", new HotWheels() },
            {"SuspensionControl", new SuspensionControl() },
            {"TurboEngine", new TurboEngine() }
        };
        public Resource BuildResource(string resource)
        {
            return resources[resource];
        }
    }
}
