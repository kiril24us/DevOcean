namespace DevOcean.Models
{
    public abstract class Spaceship
    {
        protected readonly int _milesTraveled;
        protected readonly int _yearOfPurchase;

        protected Spaceship(int yearOfPurchase, int milesTraveled)
        {
            _yearOfPurchase = yearOfPurchase;
            _milesTraveled = milesTraveled;
        }

        public int MilesTraveled
        {
            get { return _milesTraveled; }
        }

        public int YearOfPurchase
        {
            get { return _yearOfPurchase; }
        }

        public virtual int Tax { get; protected set; }

        public virtual int TaxIncreaser { get; protected set; }

        public virtual int TaxDecreaser { get; protected set; }
    }
}
