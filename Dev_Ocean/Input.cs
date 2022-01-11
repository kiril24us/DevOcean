using Dev_Ocean.Validation;
using DevOcean.Models;
using DevOcean.Services;
using System;

using static DevOcean.GlobalConstants.OutputMessages;

namespace DevOcean_Task
{
    public class Input
    {
        private readonly ISpaceshipsService _spaceshipsService;
        private readonly IInputValidation _inputValidation;

        public Input(ISpaceshipsService spaceshipsService, IInputValidation inputValidation)
        {
            _spaceshipsService = spaceshipsService;
            _inputValidation = inputValidation;
        }

        public void ReadInput()
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine(SpaceshipType);
            string spaceshipType = Console.ReadLine().ToLower();

            spaceshipType = _inputValidation.ValidationSpaceshipType(spaceshipType);           

            Console.WriteLine(YearOfPurchase);
            string yearOfPurchaseAsString = Console.ReadLine();
            int yearOfPurchase = _inputValidation.ValidationTheInputNumber(yearOfPurchaseAsString);

            Console.WriteLine(YearOfTaxCalculation);
            string yearOfTaxCalculationAsString = Console.ReadLine();
            int yearOfTaxCalculation = _inputValidation.ValidationTheInputNumber(yearOfTaxCalculationAsString);

            Console.WriteLine(MilesTraveled);
            string milesTraveledAsString = Console.ReadLine();
            int milesTraveled = _inputValidation.ValidationTheInputNumber(milesTraveledAsString);

            double result;
            Spaceship spaceship;

            switch (spaceshipType)
            {
                case "cargo":
                    spaceship = new Cargo(yearOfPurchase, milesTraveled);
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfTaxCalculation);
                    break;

                case "family":
                    spaceship = new Family(yearOfPurchase, milesTraveled);
                    result = _spaceshipsService.CalculateTax(spaceship, yearOfTaxCalculation);
                    break;

                default:
                    throw new Exception();
            }

            if(result > 0)
            {
                Console.WriteLine(YouOweMessage);
                Console.Write(result);
            }
            else
            {
                Console.Write(RedCardMessage);
            }           
        }
    }
}
