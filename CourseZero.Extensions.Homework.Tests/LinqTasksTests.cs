using NUnit.Framework;
using CourseZero.Extensions.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseZero.Classes;
using FluentAssertions;
using CourseZero.Extensions.Library.Cars;

namespace CourseZero.Extensions.Homework.Tests
{
    [TestFixture()]
    public class LinqTasksTests
    {
        public static string[] Vehicles => new[]
        {
            "Brand=Lada;BaseConsumption=0,25;MaxFuel=55",
            "Brand=Kia;BaseConsumption=0,15;MaxFuel=55",
            "Brand=Toyota;BaseConsumption=0,11;MaxFuel=49",
            "Brand=Toyota;BaseConsumption=0,11;MaxFuel=49",
            "Brand=Hyndai;BaseConsumption=0,25;MaxFuel=35",
            "Brand=Honda;BaseConsumption=0,1;MaxFuel=25",
            "Brand=GAZ;BaseConsumption=0,30;MaxFuel=60;Weight=350|12|233|12",
            "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=1230|230|901",
            "Brand=BELAZ;BaseConsumption=0,50;MaxFuel=100;Weight=1323|122|233|145|905",
            "Brand=Ford;BaseConsumption=0,12;MaxFuel=55",
            "Brand=Dodge;BaseConsumption=0,13;MaxFuel=45",
            "Brand=Dodge;BaseConsumption=0,13;MaxFuel=45",
            "Brand=Subaru;BaseConsumption=0,1;MaxFuel=45",
            "Brand=KAMAZ;BaseConsumption=0,40;MaxFuel=80;Weight=130|2130|190",
        };

        [Test()]
        public void MinConsumptionTest()
        {
            LinqTasks.GetMinConsumption(Vehicles).Should().Be(0.1M);
        }

        [Test()]
        public void TotalWeightTest()
        {
            LinqTasks.GetTotalWeight(Vehicles).Should().Be(8146);
        }

        [Test()]
        public void TotalCargoBoxesCountTest()
        {
            LinqTasks.GetTotalCargoBoxesCount(Vehicles).Should().Be(15);
        }

        [Test()]
        public void GetCarNamesTest()
        {
            var result = LinqTasks.GetCarNames(Vehicles);

            result.Should().HaveCount(10);
            result.Count(b => b == "Toyota").Should().Be(2);
            result.Count(b => b == "Dodge").Should().Be(2);
            result.Count(b => b == "Ford").Should().Be(1);
        }

        [Test()]
        public void GetCarsCountTest()
        {
            LinqTasks.GetCarsCount(Vehicles).Should().Be(10);
        }

        [Test()]
        public void WeightOfLastKamazTest()
        {
            LinqTasks.GetWeightOfLastKamaz(Vehicles).Should().Be(2450);
        }

        [Test()]
        public void GetCarsWithLesserConsumptionTest()
        {
            var result = LinqTasks.GetCarsWithLesserConsumption(Vehicles);

            result.Should().HaveCount(2);
            result.FirstOrDefault(c => c.Brand == "Honda").Should().NotBeNull();
            result.FirstOrDefault(c => c.Brand == "Subaru").Should().NotBeNull();
        }

        [Test()]
        public void GetUnrepetableBrandsTest()
        {
            var result = LinqTasks.GetUnrepetableBrands(Vehicles);

            result.Should().HaveCount(11);
        }

        [Test()]
        public void GetAllCargoBoxesSortedByWeightTest()
        {
            var result = LinqTasks.GetAllCargoBoxesSortedByWeight(Vehicles);

            result.Should().HaveCount(15);

            Cargo lightweightBox = result.First();
            for (int i = 0; i < result.Length; i++)
            {
                lightweightBox.Weight.Should().BeLessOrEqualTo(result[i].Weight);
                lightweightBox = result[i];
            }
        }

        [Test()]
        public void GetFuelCountForAllCarsTest()
        {
            LinqTasks.GetFuelCountForAllCars(Vehicles).Should().Be(778);
        }
    }
}