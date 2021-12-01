namespace SampleNamespace
{
    class Customer : Person
    {
        // Shorthand to use getter and setter 
        public double CashOnHand {get; set;} = 0;

        public Customer(int CashOnHand, string firstName, string lastName) : base(firstName, lastName)
        {
            this.CashOnHand = CashOnHand;
        }
    }
}