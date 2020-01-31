using System;
using System.Collections.Generic;
using System.Text;
using GlobalMotorcycleServiceModule;

namespace ConsoleMotorcycle
{
    class MyConsoleMotorcycle
    {
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public static int Odometer { get; private set; }
        public int DailyDistance { get; set; }

        public MyConsoleMotorcycle(string model)
        {
            Model = model;
        }

        public void StartEngine()
        {
            Console.WriteLine($"\nEngine has been started at {DateTime.Now}");
        }

        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance} km");
        }

        public void StopEngine()
        {
            Odometer += DailyDistance;

            //Call MotorcycleService
            MotorcycleService.DistanceFromLastService += DailyDistance;

            Console.WriteLine($"Engine has been stoped at {DateTime.Now}");
            Console.WriteLine($"Total distance: {Odometer} km");
        }
    }
}
