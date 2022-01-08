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

        public const string InvalidYearOfPurchaseValue = "Invalid value! The year of purchase cannot be a negative number!";

        public const string InvalidYearOfTaxCalculationValue = "Invalid value! The year of tax calculation cannot be a negative number!";

        public const string InvalidMilesTraveledValue = "Invalid value! Miles traveled cannot be a negative number!";
    }

    public static class SpaceshipTypes
    {
        public const string SpaceshipCargo = "cargo";

        public const string SpaceshipFamily = "family";
    }
}
