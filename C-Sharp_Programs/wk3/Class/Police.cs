namespace SampleNamespace
{
    class Police : Person
    {
        public string rank {get; set;} = "police officer";

        public Police()
        {
            rank = "police officer";
        }

        public Police(string rank)
        {
            this.rank = rank;
        }

        public Police(string rank, string firstName, string lastName) : base(firstName, lastName)
        {
            this.rank = rank;
        }

        public void policeArrive()
        {
            Console.WriteLine($"I am an {rank} and I am going arrest you, Sir");
            Console.WriteLine("I am here because this store manager call me that you stirred some trouble");
        }
    }
}