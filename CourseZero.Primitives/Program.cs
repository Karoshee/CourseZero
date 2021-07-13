using System;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace CourseZero.Primitives
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = 45.67M;
            DateTime dt = DateTime.Now;
            Console.WriteLine($"Число равно {d:C}");
            Console.WriteLine($"День недели {dt:dd.MM.yyyy hh:mm.ss}");

            string[] strings =
            {
                "Brand=Lada;BaseConsumption=0,25;MaxFuel=55",
                "Brand=Kia;BaseConsumption=0,15;MaxFuel=45",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230"
            };

            string result = "";
            foreach (var item in strings)
            {
                result += item;
            }

            StringBuilder builder = new StringBuilder();

            foreach (var item in strings)
            {
                builder.AppendLine(item);
            }

            Console.WriteLine(builder.ToString());

            Operation op = Operation.Add;
            Operations ops = Operations.Add | Operations.Divide;

            if (ops.HasFlag(Operations.Divide))
            {

            }

            (bool isSuccess, int index) = GetInt();

            if (isSuccess)
            {
                index++;
            }

            Data1 data = new Data1("fdsfsd", 34);
            Data1 data1 = new Data1("fdsfsd", 34);

            if (data == data1)
            {
                Console.WriteLine("Объекты равны");
            }

            Console.WriteLine(Do(2M, 3M, Operation.Add));

            Console.ReadLine();
        }

        public static decimal Do(decimal op1, decimal op2, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return op1 + op2;
                case Operation.Substract:
                    return op1 - op2;
                case Operation.Multiply:
                    return op1 * op2;
                case Operation.Divide:
                    return op1 / op2;
                default:
                    throw new ArgumentException("Эта операция не предумотрена");
            }
        }
        
        public static (bool, int) GetInt()
        {
            return (true, 23);
        }

        public enum Operation : byte
        {
            Add = 1,
            Substract = 2,
            Multiply = 3,
            Divide = 4
        }

        [Flags]
        public enum Operations: byte
        {
            Add = 1,
            Substract = 2,
            Multiply = 4,
            Divide = 8
        }
    }

    public record Data1(string Text, int Index);
    //{
    //    public string Text { get; init; }

    //    public int Index { get; init; }

    //    public Data1(string text, int index)
    //    {
    //        Text = text;
    //        Index = index;
    //    }
    //}
}
