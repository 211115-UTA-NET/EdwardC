namespace SampleNamespace
{
    public class Manager : Employee
    {
        private string ID;
        private string AuthorizationLevel;
        private int pinCode;

        public Manager()
        {
            this.ID = "00000";
            this.AuthorizationLevel = "F";
            this.pinCode = 0000;

        }

        public Manager(string ID, string AuthorizationLevel, int pinCode, string firstName, string lastName) : base(firstName, lastName)
        {
            this.ID = ID;
            this.AuthorizationLevel = AuthorizationLevel;
            this.pinCode = pinCode;
        }

        public Manager(string ID, string AuthorizationLevel, int pinCode, int HoursWorked, double PayRate, string firstName, string lastName) : base(HoursWorked, PayRate, firstName, lastName)
        {
            this.ID = ID;
            this.AuthorizationLevel = AuthorizationLevel;
            this.pinCode = pinCode;
        }

        public void setID(string ID)
        {
            this.ID = ID;
        }
        public void setAuthorizationLevel(string level)
        {
            AuthorizationLevel = level;
        }
        public void setPinCode(int pinCode)
        {
            this.pinCode = pinCode;
        }

        public string getID()
        {
            return ID;
        }

        public string getAuthorizationLevel()
        {
            return AuthorizationLevel;
        }

        public int getPinCode()
        {
            return pinCode;
        }

        public void helpCustomer()
        {
            switch(AuthorizationLevel)
            {
                case "A": Console.WriteLine("I can help you with anything you need"); break;
                case "B": Console.WriteLine("I can help you with anything you need execpt discount"); break;
                case "C": Console.WriteLine("I only can help you with shopping"); break;
                case "D": Console.WriteLine("I only can answer your question."); break;
            }
        }
    }
}