namespace DevOcean.GlobalConstants
{
    public static class OutputMessages
    {
        public const string WelcomeMessage = "Welcome to DevOcean Galaxy, in order to calculate the tax you need to provide us with some information";

        public const string SpaceshipType = "Enter what type of spaceship is: cargo or family";

        public const string ConfirmationMessage = "Good, let's proceed with some more information";

        public const string YearOfPurchase = "Enter the year of the purchase";

        public const string YearOfTaxCalculation = "Enter the year of the tax calculation";

        public const string MilesTraveled = "Enter the miles traveled";

        public const string WrongSpaceshipType = "Wrong spaceship type! Please enter cargo or family!";

        public const string InvalidNumber = "Invalid value! The number cannot be negative or string!";

        public const string YouOweMessage = "After the calculation you owe: ";

        public const string SpaceshipCargo = "cargo";

        public const string SpaceshipFamily = "family";

        public const string RedCardMessage = "Calculation is not done correctly, you receive red card!";
    }

    public static class TestsMessages
    {
        public const string InvalidSpaceshipName = "wrong";

        public const string ValidSpaceshipNameCargo = "cargo";

        public const string ValidSpaceshipNameFamily = "family";

        public const string WhiteSpaceAsInput = " ";

        public const string ZeroAsInput = "0";

        public const string ValidInputNumber = "100";

        public const string NegativeNumberAsInput = "-5";

        public const string StringAsInput = "test";

        public const string InputValues = @"cargo 
1000
1200
10000";

        public const string ExpectedOutputWithFinalResultMoreThanZero = @"Welcome to DevOcean Galaxy, in order to calculate the tax you need to provide us with some information
Enter what type of spaceship is: cargo or family
Enter the year of the purchase
Enter the year of the tax calculation
Enter the miles traveled
After the calculation you owe: 
100";

        public const string ExpectedOutputWithFinalResultNegativeNumber = @"Welcome to DevOcean Galaxy, in order to calculate the tax you need to provide us with some information
Enter what type of spaceship is: cargo or family
Enter the year of the purchase
Enter the year of the tax calculation
Enter the miles traveled
Calculation is not done correctly, you receive red card!";
    }
}

