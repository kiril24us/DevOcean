using DevOcean.Models;

namespace DevOcean.Services
{
    public class SpaceshipsService : ISpaceshipsService
    {
        public double CalculateTax(Spaceship spaceship, int startYear, int endYear, int miles)
        {

            spaceship.Miles = miles;
            spaceship.YearOfPurchase = startYear;
            spaceship.YearOfCalculation = endYear;

            return spaceship.Tax + (spaceship.Miles / 1000) * spaceship.TaxIncreaser - (endYear - startYear) * spaceship.TaxDecreaser;

        }
    }
}
