using System;

using static DevOcean.GlobalConstants.OutputMessages;

namespace Dev_Ocean.Validation
{
    public class InputValidation : IInputValidation
    {
        public string ValidationSpaceshipType(string spaceshipType)
        {
            while (spaceshipType != SpaceshipCargo && spaceshipType != SpaceshipFamily)
            {
                Console.WriteLine(WrongSpaceshipType);
                spaceshipType = Console.ReadLine().ToLower();
            }

            return spaceshipType;
        }

        public int ValidationTheInputNumber(string inputValueAsString)
        {
            int inputNumberValue;

            while (!(int.TryParse(inputValueAsString, out inputNumberValue) && inputNumberValue > 1))
            {
                Console.WriteLine(InvalidNumber);
                inputValueAsString = Console.ReadLine();
            }

            return inputNumberValue;
        }
    }
}
