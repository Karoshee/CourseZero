using CourseZero.Classes;
using System.Linq;

namespace CourseZero.Files
{
    public static class Cars
    {
        public static Vehicle[] GetVehicles()
        {
            return new[]
            {
                "Brand=Lada;BaseConsumption=0,25;MaxFuel=55",
                "Brand=Kia;BaseConsumption=0,15;MaxFuel=55",
                "Brand=Toyota;BaseConsumption=0,11;MaxFuel=49",
                "Brand=Hyndai;BaseConsumption=0,25;MaxFuel=35",
                "Brand=Honda;BaseConsumption=0,1;MaxFuel=25",
                "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350|12|233|12",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230|230|901",
                "Brand=BELAZ;BaseConsumption=0,50;MaxFuel=100;Weight=1323|122|233|145|905",
                "Brand=Ford;BaseConsumption=0,12;MaxFuel=55",
                "Brand=Dodge;BaseConsumption=0,13;MaxFuel=45",
                "Brand=Subaru;BaseConsumption=0,12;MaxFuel=45",
                "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=130|2130|190",
            }
            .Select(str => Vehicle.Parse(str))
            .ToArray();
        }
    }
}
