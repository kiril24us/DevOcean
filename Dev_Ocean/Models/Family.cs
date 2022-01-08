namespace DevOcean.Models
{
    public class Family : Spaceship
    {
        public int Tax { get; set; } = 5000;

        public int YearOfPurchase { get; set; }

        public int YearOfCalculation { get; set; }

        public int Miles { get; set; }

        public int TaxIncreaser { get; set; } = 100;

        public int TaxDecreaser { get; set; } = 355;
    }
}
