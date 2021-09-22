using System;
using System.Collections.Generic;
using System.Text;
using RaceGameDesignPattern.BasicTypes;
using RaceGameDesignPattern.Resources;

namespace RaceGameDesignPattern.Factory
{
    class EnemyFactory
    {
        public List<Car> cars = new List<Car>();
        public EnemyFactory()
        {
            // Carro 0
            cars.Add(new Car(new Hatch()));
            new ABS().Add(cars[0]);
            new HotWheels().Add(cars[0]);
            // Carro 1
            cars.Add(new Car(new Sedan()));
            new ABS().Add(cars[1]);
            new SuspensionControl().Add(cars[1]);
            // Carro 2
            cars.Add(new Car(new SUV()));
            new ABS().Add(cars[2]);
            new TurboEngine().Add(cars[2]);
            // Carro 3
            cars.Add(new Car(new Hatch()));
            new SuspensionControl().Add(cars[3]);
            // Carro 4
            cars.Add(new Car(new Sedan()));
            new HotWheels().Add(cars[4]);
            // Carro 5
            cars.Add(new Car(new SUV()));
            new TurboEngine().Add(cars[5]);
            // Carro 6
            cars.Add(new Car(new SUV()));
            new HotWheels().Add(cars[6]);
            // Carro 7
            cars.Add(new Car(new Sedan()));
            new ABS().Add(cars[7]);
            // Carro 8
            cars.Add(new Car(new Hatch()));
            new ABS().Add(cars[8]);
            // Carro 9
            cars.Add(new Car(new Sedan()));
            new TurboEngine().Add(cars[9]);
            // Carro 10
            cars.Add(new Car(new Hatch()));
            new ABS().Add(cars[10]);
            new SuspensionControl().Add(cars[10]);
        }
        public Car BuildCar(int n)
        {
            return cars[n];
        }
    }
}
