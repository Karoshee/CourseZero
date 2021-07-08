using System;
using CourseZero.Classes;
using CourseZero.Extensions.Library;

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

            // Min, Max, Averange, Sum

            // First, Last, OrderBy

            // Where, Cast, OfType

            // Group, Aggregate
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
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230",
                "Brand=BELAZ;BaseConsumption=0,50;MaxFuel=100;Weight=13230",
                "Brand=Ford;BaseConsumption=0,12;MaxFuel=44",
                "Brand=Dodge;BaseConsumption=0,13;MaxFuel=45",
                "Brand=Subaru;BaseConsumption=0,12;MaxFuel=45",
            };
        }
    }
}
