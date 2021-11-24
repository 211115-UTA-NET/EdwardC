using System;

// Limit to two num and have own menu for operator
namespace EmulatorCalculator
{
    class Program
    {
        static void Main(string[] args){
            /*  Your application should (mvp):
            *  -Be able to accept multiple numbers (Done for accept two number)
            *  -Perform a selected operation on those numbers (Done)
            *  -Display the result of the operation (Done: a, s, m, d, r)
            *  -Repeat until the user chooses to exit (Done)
            */
            Program p = new Program();

            bool userExit = false;
            string? userInput;
            string? userNum;
            int getNum1 = 0;
            int getNum2 = 0;

            Console.WriteLine("Welcome to my emulator calculator!");

            do
            {
                Console.WriteLine("Enter your input:\n" +
                                  "a - Add (+)\n" +
                                  "s - Substraction (-)\n" +
                                  "m - Multiply (*)\n" +
                                  "d - Divide (/)\n" +
                                  "r - Modulos (%)\n" );
                Console.Write("Your input is: ");
                userInput = Console.ReadLine();

                if(userInput == "a" || userInput == "s" ||
                   userInput == "m" || userInput == "d" || 
                   userInput == "r")
                {
                    Console.Write("\nEnter your first number: ");
                    userNum = Console.ReadLine();

                    if(int.TryParse(userNum, out getNum1))
                    {
                        getNum1 = int.Parse(userNum);
                    }


                    Console.Write("Enter your second number: ");
                    userNum = Console.ReadLine();
                    if(int.TryParse(userNum, out getNum2))
                    {
                        getNum2 = int.Parse(userNum);
                    }
                }

                switch(userInput){
                    case "a": p.Add(getNum1, getNum2);
                    break;
                    case "s": p.Substract(getNum1, getNum2);
                    break;
                    case "m": p.Multiply(getNum1, getNum2);
                    break;
                    case "d": p.Divide(getNum1, getNum2);
                    break;
                    case "r": p.Modulos(getNum1, getNum2);
                    break;
                }

                Console.WriteLine("\nEnter 'q' to quit program, else other will continue.");
                Console.Write("Your input is: ");
                userInput = Console.ReadLine();
                if(userInput == "q")
                {
                    userExit = true;
                }

                Console.WriteLine();
            }
            while(!userExit);

        }

        public void Add(int num1, int num2)
        {
            Console.WriteLine( "{0} + {1} = {2}", num1, num2, (num1 + num2) );
        }
        public void Substract(int num1, int num2)
        {
            Console.WriteLine( "{0} - {1} = {2}", num1, num2, (num1 - num2) );
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine( "{0} * {1} = {2}", num1, num2, (num1 * num2) );
        }
        public void Divide(int num1, int num2)
        {
            Console.WriteLine( "{0} / {1} = {2}", num1, num2, (num1 / num2) );
        }
        public void Modulos(int num1, int num2)
        {
            Console.WriteLine( "{0} % {1} = {2}", num1, num2, (num1 % num2) );
        }
    }
}







/*
 * Your application could also (stretch goals):
 * -Accept number values and operations in a written input format (ie. "one plus one")
 * -Accept mixed format input (ie. "one plus 3")
 * -Accept multiple values (ie. "2 + 3 + 4")
 * -Perform multiple operations (ie. "2 - 1 + 3")
 * -Store a calculation history to a file.
 * -Accept inputs from a file, perform the required operations, then ouput those results to a file.
 */