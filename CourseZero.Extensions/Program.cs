using System;

namespace CourseZero.Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
