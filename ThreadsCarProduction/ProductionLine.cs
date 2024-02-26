using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsCarProduction
{
    class ProductionLine
    {
        private const int NumberOfCarsToProduce = 3;

        private int tiresBuilt = 0;
        private int seatsBuilt = 0;
        private int enginesBuilt = 0;
        private int framesBuilt = 0;

        private readonly int tireBuildTime = 2;
        private readonly int seatBuildTime = 3;
        private readonly int engineBuildTime = 7;
        private readonly int frameBuildTime = 5;

        private readonly object lockObject = new object();

        public void StartProduction()
        {
            Console.WriteLine("Производство на автомобили започва...");

            Thread tireThread = new Thread(BuildTires);
            Thread seatThread = new Thread(BuildSeats);
            Thread engineThread = new Thread(BuildEngines);
            Thread frameThread = new Thread(BuildFrames);

            tireThread.Start();
            seatThread.Start();
            engineThread.Start();
            frameThread.Start();

            tireThread.Join();
            seatThread.Join();
            engineThread.Join();
            frameThread.Join();

            for (int i = 0; i < NumberOfCarsToProduce; i++)
            {
                AssembleCar();
            }

            Console.WriteLine("Производството на автомобили приключи.");
        }

        private void BuildTires()
        {
            while (tiresBuilt < NumberOfCarsToProduce * 4)
            {
                Thread.Sleep(tireBuildTime * 1000);
                lock (lockObject)
                {
                    tiresBuilt++;
                    Console.WriteLine("Изградени гуми: " + tiresBuilt);
                }
            }
        }

        private void BuildSeats()
        {
            while (seatsBuilt < NumberOfCarsToProduce * 5)
            {
                Thread.Sleep(seatBuildTime * 1000);
                lock (lockObject)
                {
                    seatsBuilt++;
                    Console.WriteLine("Изградени седалки: " + seatsBuilt);
                }
            }
        }

        private void BuildEngines()
        {
            while (enginesBuilt < NumberOfCarsToProduce)
            {
                Thread.Sleep(engineBuildTime * 1000);
                lock (lockObject)
                {
                    enginesBuilt++;
                    Console.WriteLine("Изградени двигатели: " + enginesBuilt);
                }
            }
        }

        private void BuildFrames()
        {
            while (framesBuilt < NumberOfCarsToProduce)
            {
                Thread.Sleep(frameBuildTime * 1000);
                lock (lockObject)
                {
                    framesBuilt++;
                    Console.WriteLine("Изградени рами: " + framesBuilt);
                }
            }
        }

        private void AssembleCar()
        {
            Console.WriteLine("Сглобяване на автомобил...");

            while (tiresBuilt < 4 || seatsBuilt < 5 || enginesBuilt < 1 || framesBuilt < 1)
            {
                Thread.Sleep(1000);
            }

            lock (lockObject)
            {
                tiresBuilt -= 4;
                seatsBuilt -= 5;
                enginesBuilt--;
                framesBuilt--;
            }

            Console.WriteLine("Автомобил сглобен успешно!");
        }
    }
}
