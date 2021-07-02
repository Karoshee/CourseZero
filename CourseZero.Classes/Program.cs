using CourseZero.Classes.SomeClass;
using System;

namespace CourseZero.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            ref int j = ref i;
            object o = i;
            object o1 = 1;
            Console.WriteLine(2.3);

            Box b1 = new() { Value = 1 };
            Box b2 = b1;
            Box b3 = new() { InnerBox = b1 };
            b1.Value = 2;
            string s1 = "123123";
            string s2 = s1;
            s1.Replace("1", "9");


            Stack<char> stack = new Stack<char>();
            bool continueInput;
            do
            {
                Console.Write("Введите символ: ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                continueInput = char.IsLetterOrDigit(key.KeyChar);
                if (continueInput)
                {
                    stack.Add(key.KeyChar);
                }
            } while (continueInput);
            Console.WriteLine(stack);
            Console.ReadKey();
        }

        public static int CompareMethod(int i1, int i2)
        {
            return i1 - i2;
        }

        public static void RunVehicles()
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
                if (vehicles[i] is CargoVehicle cargoVehicle)
                {
                    cargoCount += cargoVehicle.Weight;
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
