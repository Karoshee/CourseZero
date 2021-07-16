using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    [Serializable]
    public class Car : Vehicle
    {

        public Car(string brand, decimal consumption, int maxFuel)
        {
            Brand = brand;
            BaseConsumption = consumption;
            MaxFuel = maxFuel;
        }

        public Car()
        {

        }

        public static Car Parse(string text)
        {
            string[] parameters = text.Split(";");
            Car car = new();
            foreach (string parameter in parameters)
            {
                string[] splittedParameter = parameter.Split("=");
                if (splittedParameter[0] == nameof(Brand))
                {
                    car.Brand = splittedParameter[1];
                }
                else if (splittedParameter[0] == nameof(BaseConsumption))
                {
                    car.BaseConsumption = decimal.Parse(splittedParameter[1]);
                }
                else if (splittedParameter[0] == nameof(MaxFuel))
                {
                    car.MaxFuel = decimal.Parse(splittedParameter[1]);
                }
            }
            return car;
        }
    }
}
