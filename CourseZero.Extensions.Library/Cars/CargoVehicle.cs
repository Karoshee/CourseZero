using CourseZero.Extensions.Library.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    [Serializable]
    public class CargoVehicle : Vehicle
    {
        public List<Cargo> CargoBoxes { get; private set; }
            = new List<Cargo>();

        public decimal Weight
            => CargoBoxes.Sum(b => b.Weight);

        public CargoVehicle()
        {

        }

        protected override decimal GetConsumption()
        {
            return base.GetConsumption() * (Weight/1230);
        }

        public static CargoVehicle Parse(string text)
        {
            string[] parameters = text.Split(";");
            CargoVehicle car = new();
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
                else if (splittedParameter[0] == nameof(Weight))
                {
                    string[] weights = splittedParameter[1].Split("|");
                    car.CargoBoxes.AddRange(weights.Select(w => new Cargo() { Weight = decimal.Parse(w) }));
                }
            }
            return car;
        }

    }

}
