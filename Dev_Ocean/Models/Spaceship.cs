namespace DevOcean.Models
{
    public interface Spaceship
    {
        public int Tax { get; set; }

        public int YearOfPurchase { get; set; }

        public int YearOfCalculation { get; set; }

        public int Miles { get; set; }

        public int TaxIncreaser { get; set; }

        public int TaxDecreaser { get; set; }
    }
}
