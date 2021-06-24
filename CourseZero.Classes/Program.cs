using System;

namespace CourseZero.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal initialFuel = 42;
            const decimal distance = 100;

            Vehicle car = new Vehicle("Zebra", 55, 3);

            Vehicle cargo = CargoVehicle.Parse("Brand=Lada;Consumption=9,9;MaxFuel=55;Weight=1234");

            Vehicle[] vehicles = new Vehicle[2];

            vehicles[0] = car;
            vehicles[1] = cargo;

            decimal allConsumption = 0;

            foreach (var veh in vehicles)
            {
                allConsumption += veh.GetConsumption();
            }

            var cons = cargo.GetConsumption();

            var distanceRemain = car.Move(distance);


            car.FuelUp(initialFuel);
            distanceRemain = car.Move(distance);

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
