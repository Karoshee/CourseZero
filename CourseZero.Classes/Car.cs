namespace CourseZero.Classes
{
    public class Car
    {
        private decimal _fuel;

        public decimal Fuel
        {
            get { return _fuel; }
            private set 
            {
                if (value > 0)
                {
                    _fuel = value;
                }
            }
        }

        public decimal MaxFuel { get; set; }

        public string Name { get; private set; }

        public decimal FuelSpace { get { return MaxFuel - Fuel; } }

        private decimal Consumption { get; set; }

        public Car() : this("Lada", 45, 10.5M)
        {
        }

        public Car(string name, decimal maxFuel, decimal consumption)
        {
            Name = name;
            MaxFuel = maxFuel;
            Consumption = consumption;
        }

        ~Car()
        {

        }

        public decimal Move(decimal distance)
        {
            decimal fuelConsumed = Consumption * distance;
            if (Fuel < fuelConsumed)
            {
                decimal remainingDistance = (fuelConsumed - Fuel) / Consumption;
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
    }
}
