namespace SampleNamespace
{
    public class Trainee : Employee
    {
        bool inTraining = true;

        // Constructor(s)
        public Trainee()
        {
            this.inTraining = true;
        }

        // Function
        public bool getInTraining()
        {
            return this.inTraining;
        }
    }
}