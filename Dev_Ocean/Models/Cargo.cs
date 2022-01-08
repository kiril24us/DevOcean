namespace DevOcean.Models
{
    public class Cargo : Spaceship
    {
        public Cargo(int yearOfPurchase, int milesTraveled) : base(yearOfPurchase, milesTraveled)
        {

        }

        public override int Tax { get; protected set; } = 10000;

        public override int TaxIncreaser { get; protected set; } = 1000;

        public override int TaxDecreaser { get; protected set; } = 736;
    }
}
