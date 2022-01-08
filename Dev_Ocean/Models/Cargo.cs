namespace DevOcean.Models
{
    public class Cargo : Spaceship
    {
        public int Tax { get; set; } = 10000;

        public int YearOfPurchase { get; set; }

        public int YearOfCalculation { get; set; }

        public int Miles { get; set; }

        public int TaxIncreaser { get; set; } = 1000;

        public int TaxDecreaser { get; set; } = 736;
    }
}
