using System;

namespace CourseZero.Classes
{
    [Serializable]
    public abstract class Vehicle : IMovable, IHasFuel
    {
        private decimal _fuel;

        public decimal Fuel
        {
            get { return _fuel; }
            set
            {
                if (value > 0)
                {
                    _fuel = value;
                }
            }
        }

        public decimal MaxFuel { get; set; }

        public string Brand { get; protected set; }

        public virtual decimal FuelSpace { get { return MaxFuel - Fuel; } }

        public decimal BaseConsumption { get; set; }

        public Vehicle() : this("Lada", 45, 10.5M)
        {
        }

        public Vehicle(string name, decimal maxFuel, decimal consumption)
        {
            Brand = name;
            MaxFuel = maxFuel;
            BaseConsumption = consumption;
        }

        ~Vehicle()
        {

        }

        public decimal Move(decimal distance)
        {
            decimal fuelConsumed = GetConsumption() * distance;
            if (Fuel < fuelConsumed)
            {
                decimal remainingDistance = (fuelConsumed - Fuel) / GetConsumption();
                Fuel = 0;
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
            if (FuelSpace >= fuel)
            {
                Fuel += fuel;
            }
            else
            {
                Fuel = MaxFuel;
            }
        }

        public static string FuelMark { get; } = "97";


        public virtual decimal CountFuelFor(decimal distanceInKilometers)
        {
            return distanceInKilometers * GetConsumption();
        }

        protected virtual decimal GetConsumption()
        {
            return BaseConsumption;
        }

        public override string ToString()
        {
            return Brand;
        }
        public static Vehicle Parse(string text)
        {
            return text.Contains(nameof(CargoVehicle.Weight) + "=")
                ? CargoVehicle.Parse(text)
                : Car.Parse(text);
        }
    }

    public interface IMovable
    {
        decimal Move(decimal distance);
    }

    public interface IHasFuel : IMovable
    {
        decimal Fuel { get; }

        void FuelUp(decimal fuel);
    }

}
