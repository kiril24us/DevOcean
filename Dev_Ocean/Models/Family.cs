namespace DevOcean.Models
{
    public class Family : Spaceship
    {
        public Family(int yearOfPurchase, int milesTraveled) : base(yearOfPurchase, milesTraveled)
        {

        }

        public override int Tax { get; protected set; } = 5000;

        public override int TaxIncreaser { get; protected set; } = 100;

        public override int TaxDecreaser { get; protected set; } = 355;
    }
}
