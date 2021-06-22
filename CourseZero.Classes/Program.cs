using System;

namespace CourseZero.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal initialFuel = 42;
            const decimal distance = 100;

            Car car = 
                new Car("Zebra", 55, 3);
            
            car.FuelUp(initialFuel);
            var distanceRemain = car.Move(distance);

            if (distanceRemain == 0)
            {
                Console.WriteLine($"Машина благополучно прошла {distance}км, и затрачено {initialFuel - car.Fuel}л. топлива");
            }
            else
            {
                Console.WriteLine($"Машина прошла лишь часть пути в {distance - distanceRemain}км. потратив {initialFuel}л. топлива");
            }
        }
    }
}
