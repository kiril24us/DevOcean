using DevOcean.Models;

namespace DevOcean.Services
{
    public class SpaceshipsService : ISpaceshipsService
    {
        public int CalculateTax(Spaceship spaceship, int yearOfCalculation)
        {
            return spaceship.Tax + (spaceship.MilesTraveled / 1000) * spaceship.TaxIncreaser - (yearOfCalculation - spaceship.YearOfPurchase) * spaceship.TaxDecreaser;

        }
    }
}
