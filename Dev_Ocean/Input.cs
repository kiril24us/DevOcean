using DevOcean.Models;
using DevOcean.Services;
using System;

using static DevOcean.GlobalConstants.OutputMessages;
using static DevOcean.GlobalConstants.SpaceshipTypes;

namespace DevOcean_Task
{
    public class Input
    {
        private readonly ISpaceshipsService _spaceshipsService;

        public Input(ISpaceshipsService spaceshipsService)
        {
            _spaceshipsService = spaceshipsService;
        }

        public void ReadInput()
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine(SpaceshipType);
            string spaceshipType = Console.ReadLine().ToLower();

            while (spaceshipType != SpaceshipCargo && spaceshipType != SpaceshipFamily)
            {
                Console.WriteLine(WrongSpaceshipType);
                spaceshipType = Console.ReadLine().ToLower();
            }
            Console.WriteLine(ConfirmationMessage);

            Console.WriteLine(YearOfPurchase);
            int yearOfPurchase = int.Parse(Console.ReadLine());

            while (yearOfPurchase < 0)
            {
                Console.WriteLine(InvalidYearOfPurchaseValue);
                yearOfPurchase = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ConfirmationMessage);

            Console.WriteLine(YearOfTaxCalculation);
            int yearOfTaxCalculation = int.Parse(Console.ReadLine());

            while (yearOfTaxCalculation < 0)
            {
                Console.WriteLine(InvalidYearOfTaxCalculationValue);
                yearOfTaxCalculation = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(MilesTraveled);
            int milesTraveled = int.Parse(Console.ReadLine());

            while (milesTraveled < 0)
            {
                Console.WriteLine(InvalidMilesTraveledValue);
                milesTraveled = int.Parse(Console.ReadLine());
            }

            double result;
            Spaceship spaceship;

            switch (spaceshipType)
            {
                case "cargo":
                    spaceship = new Cargo(yearOfPurchase,milesTraveled);
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfTaxCalculation);
                    break;

                case "family":
                    spaceship = new Family(yearOfPurchase, milesTraveled);
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfTaxCalculation);
                    break;

                default:
                    throw new Exception();
            }

            Console.WriteLine(result);
        }
    }
}
