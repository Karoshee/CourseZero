namespace CourseZero.Classes
{
    public class Vehicle
    {
        private decimal _fuel;

        public decimal Fuel
        {
            get { return _fuel; }
            protected set 
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

        protected decimal BaseConsumption { get; set; }

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

        
        // "Brand=Lada;Consumption=9,9;MaxFuel=55"

        public virtual decimal GetConsumption()
        {
            return BaseConsumption;
        }

    }

}
