using DevOcean.Models;

namespace DevOcean.Services
{
    public interface ISpaceshipsService
    {
        public double CalculateTax(Spaceship spaceship, int startYear, int endYear, int miles);
    }
}
