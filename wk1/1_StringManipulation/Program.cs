using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a string variable and an integer variable but don't assign values to them.
            string message;
            int num;

            //Get a string from the user
            Console.ReadLine();

            //Print to the console “Please enter your message and press enter”
            Console.WriteLine("Please enter your message and press enter");

            //Assign that entered string to the string variable which you declared initially.
            message = Console.ReadLine();

            //Print to the console "Please enter a number LESS THAN the 
            //length of your string and press enter".
            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Create Method calling 
            Program p = new Program();

            // Print both user
            //p.Print(message, num);

            // Get char value from User and Search it in message, then display if they are found or not
            char c;
            Console.WriteLine("For which character should I search in you original message?");
            c = Convert.ToChar(Console.ReadLine());
            p.SearchChar(message, c);
            Console.WriteLine();
            
            // Enter the User's first name and last name seperalty, then concats name into one full name
            string firstName;
            string lastName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            p.ConcatNames(firstName, lastName);

            string[] myArray = {"Eddie", "Seth"};
            Console.WriteLine(myArray[1].Substring(0, 1) );

        }

        public void Print(string message, int num){
            Console.WriteLine(message);
            Console.WriteLine(num);
        }

        public void SearchChar(string message, char c){
            Console.WriteLine("The letter " + c + " isn't in the message, you won't be able " +
                              "to find it.");
        }

        public void ConcatNames(string fName, string lName){
            // striing.Concat(); string.Join()

            string fullName = string.Concat(fName, lName);
            Console.WriteLine(fullName);
            Console.WriteLine(fName + " " + lName);
            
        }

    }
}
