using DevOcean.Models;

namespace DevOcean.Services
{
    public interface ISpaceshipsService
    {
        public int CalculateTax(Spaceship spaceship, int yearOfCalculation);
    }
}
