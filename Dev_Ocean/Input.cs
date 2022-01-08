using DevOcean.Models;
using DevOcean.Services;
using System;

using static DevOcean.GlobalConstants.OutputMessages;

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
            string spaceshipType = Console.ReadLine();
            Console.WriteLine(ConfirmationMessage);

            Console.WriteLine(YearOfPurchase);
            int yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine(ConfirmationMessage);

            Console.WriteLine(YearOfTaxCalculation);
            int yearOfTaxCalculation = int.Parse(Console.ReadLine());

            Console.WriteLine(MilesTraveled);
            int milesTraveled = int.Parse(Console.ReadLine());

            double result;
            Spaceship spaceship;

            switch (spaceshipType)
            {
                case "cargo":
                    spaceship = new Cargo();
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfPurchase, yearOfTaxCalculation, milesTraveled);
                    break;

                case "family":
                    spaceship = new Family();
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfPurchase, yearOfTaxCalculation, milesTraveled);
                    break;

                default:
                    throw new Exception();
            }

            Console.WriteLine(result);
        }
    }
}
