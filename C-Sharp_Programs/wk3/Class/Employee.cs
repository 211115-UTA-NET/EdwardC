// Namespace
namespace SampleNamespace
{
    // Inhertance Person class for Employee
    public class Employee : Person
    {
        // field(s)
        public int HoursWorked;
        public double PayRate;

        // Constructor(s) Start here
        public Employee()
        {
            this.HoursWorked = 20;
            this.PayRate = 18.50; 
        }

        // Work same as adove constructor
        // public Employee() : base()
        // {
        //     HoursWorked = 35;
        //     PayRate = 20.00;
        // }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            HoursWorked = 20;
            PayRate = 15.50;
        }

        // base() is used to assicated with Person class's constructor (any other class) with matched parameters
        public Employee(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            // this keyword tell that variable is belong this class's field (referring to the class object)
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;
        }


        // Function start here
        public void doWork()
        {
            Console.WriteLine($"I've worked {HoursWorked} hours.");
        }
        public void earnWork()
        {
            Console.WriteLine($"I've earn ${PayRate * HoursWorked} per week before tax");
        }

        // get Function
        public int getHoursWorked()
        {
            return HoursWorked;
        }
        public double getPayRate()
        {
            return PayRate;
        }

        // set Function
        public void setHoursWorked(int HoursWorked)
        {
            this.HoursWorked = HoursWorked;
        }
        public void setPayRate(double PayRate)
        {
            this.PayRate = PayRate;
        }
        public void changeName(string first, string last)
        {
            // Call the function from base class (Person class)
            setFirstName(first);
            setLastName(last);
        }

        // End Function
    }
    // End Employee : Person
}