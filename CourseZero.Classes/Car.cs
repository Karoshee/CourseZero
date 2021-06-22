using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    public class Car
    {
        private decimal _fuel;

        // по шагам
        public decimal Fuel
        {
            get { return _fuel; }
            set
            {
                if (_fuel == value)
                    return;
                _fuel = value;
            }
        }

        public decimal MaxFuel { get; private set; }

        public decimal FuelSpace { get { return MaxFuel - Fuel; } }

        public string Name { get; private set; }

        protected virtual decimal Consumption { get; set; }

        public decimal DistanceCapacity
        {
            get
            {
                return Fuel / Consumption;
            }
        }

        // Go to Car with parameters
        public Car()
        {
            Name = "Default car";
            Consumption = 10;
            MaxFuel = 60;
        }

        public Car(string name, decimal consumption, decimal maxFuel)
        {
            Name = name;
            Consumption = consumption;
            MaxFuel = maxFuel;
        }

        ~Car()
        {
            // Do something
        }

        public decimal Move(decimal distance)
        {
            decimal fuelConsumed = Consumption * distance;
            if (Fuel < fuelConsumed)
            {
                decimal remainingDistance = (fuelConsumed - Fuel) / Consumption;
                Fuel = 0;
                //OutOfFuel.Invoke(this, EventArgs.Empty);
                return remainingDistance;
            }
            else
            {
                Fuel -= fuelConsumed;
                return 0;
            }
        }

        public void FuelUp(decimal fuel)
        {
            if (FuelSpace < fuel)
            {
                Fuel = MaxFuel;
            }
            else
            {
                Fuel += fuel;
            }
        }

        public static string FuelBrand { get { return "97"; } }


        // Name=Kia;Consumption=9;MaxFuel=45
        // Name=Lada;Consumption=10,5;MaxFuel=50
        // Name=Toyota;Consumption=11,1;MaxFuel=55

        public static Car Parse(string text)
        {
            string[] parameters = text.Split(';');
            Car car = new Car();
            foreach (var parameter in parameters)
            {
                string[] splittedParameter = parameter.Split("=");
                if (splittedParameter[0] == nameof(car.Name))
                {
                    car.Name = splittedParameter[1];
                }
                else if (splittedParameter[0] == nameof(car.Consumption))
                {
                    car.Consumption = decimal.Parse(splittedParameter[1]);
                }
                else if (splittedParameter[0] == nameof(car.MaxFuel))
                {
                    car.MaxFuel = decimal.Parse(splittedParameter[1]);
                }
            }

            return car;
        }

        private static Car Initialize(Car car, string parameter)
        {
            return car;
        }

        public event EventHandler OutOfFuel;

    }
}
