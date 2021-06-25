using System;

namespace CourseZero.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int distance = 10000;

            Vehicle[] vehicles = GetVehicles();

            decimal totalConsumption = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                totalConsumption += vehicle.CountFuelFor(distance);
            }

            Console.WriteLine($"Для выбранных  машин расход топлива на {distance} км. составит {totalConsumption:F2} л.");

            int cargoCarCount = 0;
            decimal cargoCount = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is CargoVehicle)
                {
                    cargoCount += ((CargoVehicle)vehicles[i]).Weight;
                    cargoCarCount++;
                }
            }

            Console.WriteLine($"Всего в короване {cargoCarCount} грузовых машин c {cargoCount} кг. груза");
            Console.ReadKey();
        }

        public static Vehicle[] GetVehicles()
        {
            string[] strings =
            {
                "Brand=Lada;BaseConsumption=0,25;MaxFuel=55",
                "Brand=Kia;BaseConsumption=0,15;MaxFuel=45",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230"
            };

            Vehicle[] vehicles = new Vehicle[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                vehicles[i] = Vehicle.Parse(strings[i]);
            }

            return vehicles;
        }
    }
}
