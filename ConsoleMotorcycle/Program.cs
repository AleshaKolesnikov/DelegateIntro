using GlobalMotorcycleServiceModule;
using System;

namespace ConsoleMotorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleService service = new MotorcycleService();
            MyConsoleMotorcycle motorcycle = new MyConsoleMotorcycle("Suzuki");

            motorcycle.StartEngine();
            motorcycle.Move(1000);
            motorcycle.Move(5000);
            motorcycle.StopEngine();

            motorcycle = null;
            service = null;

            service = new MotorcycleService();
            motorcycle = new MyConsoleMotorcycle("Suzuki");

            motorcycle.StartEngine();
            motorcycle.Move(6000);
            motorcycle.StopEngine();

            motorcycle = null;
            service = null;

            service = new MotorcycleService();
            motorcycle = new MyConsoleMotorcycle("Suzuki");


        }

        static void GoToService(int distanceFromLastService)
        {
            Console.WriteLine($"Time to go to Service. Current distance from last Service is:{distanceFromLastService}km");
        }
    }
}
