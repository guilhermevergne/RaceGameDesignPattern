using System;
using System.Collections.Generic;
using RaceGameDesignPattern.BasicTypes;
using RaceGameDesignPattern.Resources;
using RaceGameDesignPattern.Factory;

namespace RaceGameDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seleção do tipo basico
            Console.WriteLine("Digite o tipo de carro desejado(Hatch, Sedan ou SUV):");
            BasicType type = new BasicTypeFactory().BuildBasicType(Console.ReadLine());
            Car player = new Car(type);
            Console.Clear();
            Console.WriteLine("Carro criado com sucesso.");
            // Seleção dos recursos
            Console.WriteLine("Deseja adicionar algum recurso?(sim ou nao)");
            string ans = Console.ReadLine();
            while(ans == "sim")
            {
                Console.Clear();
                Console.WriteLine("Digite um recurso para adicionar ao carro(ABS, HotWheels, SuspensionControl ou TurboEngine):");
                string resource = Console.ReadLine();
                new ResourceFactory().BuildResource(resource).Add(player);
                Console.Clear();
                Console.WriteLine($"{resource} adicionado com sucesso. Deseja adicionar outro recurso?(sim ou nao)");
                ans = Console.ReadLine();
            }
            // Printando carro final
            Console.Clear();
            player.PrintCar();
            Console.WriteLine("Pressione qualquer tecla para iniciar a corrida.");
            Console.ReadKey();
            // Realizando as corridas
            string race = "sim";
            while(race == "sim")
            {
                Console.Write("Digite o numero de adversários: ");
                int enemyNumber = int.Parse(Console.ReadLine());
                List<Car> enemies = new List<Car>();
                for(int i=0; i < enemyNumber; i++)
                {
                    enemies.Add(new EnemyFactory().BuildCar(new Random().Next() % 11));
                }
                int goal = new Random().Next() % 800 + 200;
                int time = 0;
                while (!player.CheckVictory(goal))
                {
                    Console.Clear();
                    Console.WriteLine($"Chegada: {goal}\n");
                    Console.WriteLine("Player:");
                    player.Race(time, goal);

                    Console.WriteLine("\nAdversários:");
                    int k = 1;
                    foreach(Car enemy in enemies)
                    {
                        Console.WriteLine($"\nAdversário {k}");
                        enemy.Race(time,goal);
                        k++;
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    time++;
                }


                Console.WriteLine("Iniciar outra corrida? (sim ou nao)");
                race = Console.ReadLine();
            }
            
        }
    }
}
