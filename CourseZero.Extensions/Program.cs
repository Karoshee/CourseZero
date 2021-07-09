using System;
using CourseZero.Classes;
using System.Linq;
using CourseZero.Extensions.Library;
using System.Collections.Generic;

namespace CourseZero.Extensions
{
    class Program
    {
        static void OldMain(string[] args)
        {   // Пример extension методов
            string[] strings =
                {
                    "string 1",
                    "123,",
                    "7 yf "
                };

            string combined = strings.Join(" ");

            //combined = ExtensionMethods.Method(combined);
            combined = combined.Method();
            Console.WriteLine(combined);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {   // Пример LINQ
            string[] carsStrings = GetVehicles();

            // Select
            Vehicle[] vehicles = carsStrings
                .Select(carString => Vehicle.Parse(carString))
                .ToArray();

            // Min, Max, Averange, Sum

            var maxTankValue = vehicles.Select(v => v.MaxFuel).Max();
            var maxTankValue1 = vehicles.Max(vehicle => vehicle.MaxFuel);

            var averange = vehicles.Select(v => v.MaxFuel).Average();
            var sum = vehicles.Select(v => v.MaxFuel).Sum();

            // First, Last, OrderBy, All, Any
            var first = vehicles.First(v => v.MaxFuel == 45);
            var last = vehicles.Last(v => v.MaxFuel == 45);

            var sorted = vehicles.OrderBy(v => v.MaxFuel).ToArray();

            var anyElements = vehicles.Any();
            var flag = vehicles.Any(v => v.MaxFuel > 99);

            var all = vehicles.All(v => v.Fuel > 0);
            // Where, Cast, OfType
            var lowConsumption = vehicles.Where(v => v.BaseConsumption > 0.2M).ToList();

            //var movables = vehicles.Select(v => (IMovable)v);
            var result = vehicles
                .Cast<IHasFuel>()
                .Select(f => f.Fuel)
                .Where(f => f > 0)
                .Sum();
            //var cargos = vehicles.Cast<CargoVehicle>(); // Здесь будет ошибка

            var cars = vehicles.OfType<Car>();

            // Group, Aggregate

            var maxFuelTank = vehicles.GroupBy(v => v.MaxFuel).Select(g => g.Count()).Max();
            var carCount = vehicles.Count(v => v.MaxFuel == maxTankValue);

            var group = vehicles
                .GroupBy(v => v.MaxFuel)
                .Aggregate((g1, g2) => g1.Count() > g2.Count() ? g1 : g2);

            var mostOften = "jfdjfkdsk fds kfdj klfj dsak fjkl;asdfj l"
                .GroupBy(c => c)
                .Select(g => new { Symbol = g.Key, Count = g.Count() })
                .Aggregate((item1, item2) => item1.Count > item2.Count ? item1 : item2);

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("0", "value 0");
            dict.Add("1", "value 1");
            dict.Add("2", "value 3");
            dict.Add("3", "value 2");
            dict.Add("4", "value 4");

            string key = "3";
            var value = dict[key];
        }

        public static string[] GetVehicles()
        {
            return new[]
            {
                "Brand=Lada;BaseConsumption=0,25;MaxFuel=55",
                "Brand=Kia;BaseConsumption=0,15;MaxFuel=55",
                "Brand=Toyota;BaseConsumption=0,11;MaxFuel=49",
                "Brand=Hyndai;BaseConsumption=0,25;MaxFuel=35",
                "Brand=Honda;BaseConsumption=0,1;MaxFuel=25",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350|12|233|12",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230|230|901",
                "Brand=BELAZ;BaseConsumption=0,50;MaxFuel=100;Weight=1323|122|233|145|905",
                "Brand=Ford;BaseConsumption=0,12;MaxFuel=55",
                "Brand=Dodge;BaseConsumption=0,13;MaxFuel=45",
                "Brand=Subaru;BaseConsumption=0,12;MaxFuel=45",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=130|2130|190",
            };
        }
    }
}
