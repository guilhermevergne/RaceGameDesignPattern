using System;
using System.Collections.Generic;
using System.Text;

namespace RaceGameDesignPattern
{
    public class Car
    {
        BasicType type;
        public List<Resource> resources = new List<Resource>();
        public Dictionary<string, double> atributes = new Dictionary<string, double>
        {
            {"speed", 0},
            {"stability", 0}
        };
        public double position = 0;
        public void PrintCar()
        {
            Console.WriteLine("Basic Type: {0}\nSpeed: {1}\nStability: {2}\nResources:", type.TypeName(), atributes["speed"], atributes["stability"]);
            foreach(Resource resource in resources)
            {
                Console.Write($"{resource.ResourceName()}. ");
            }
            Console.WriteLine();
        }
        public Car(BasicType type)
        {
            this.type = type;
            atributes["speed"] = type.BaseSpeed();
            atributes["stability"] = type.BaseStability();
        }
        public void Race(int time, double goal)
        {
            if (time == 0) position = 0;
            PrintCar();
            Console.WriteLine($"OldPosition: {position:N2}\n\n");
            position += atributes["speed"] - (new Random().NextDouble() / atributes["stability"]);
            Console.WriteLine($"NewPosition: {position:N2}\n\n");
        }
        public bool CheckVictory(double goal)
        {
            return position >= goal;
        }
    }
}