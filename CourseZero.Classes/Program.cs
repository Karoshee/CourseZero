using System;

namespace CourseZero.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = Car.Parse("Name=Kia;Consumption=9;MaxFuel=45");
            car = Car.Parse("Name=Lada;Consumption=10,5;MaxFuel=50");
            car = Car.Parse("Name=Toyota;Consumption=11,1;MaxFuel=55");
        }
    }
}
