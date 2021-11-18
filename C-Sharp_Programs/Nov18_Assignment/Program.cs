using System;

namespace Nov18_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number that you want to run, by follow by:\n" +
                              "1 - Let's Echo\n"  +
                              "2 - A Personalized Echo\n" +
                              "3 - Looping with Numbers\n" +
                              "4 - Looping and Skipping\n" +
                              "5 - Getting started with conditionals\n" +
                              "6 - Comparing Numbers\n" +
                              "7 - More on Conditionals\n" +
                              "8 - Compute the Average");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(userInput == 1){
                // Let's Echo
                Console.WriteLine("Hello World!");
            }
            else if(userInput == 2){
                // A Personalized Echo
                String user = "";
                Console.WriteLine("Enter your name.");
                user = Console.ReadLine();
                Console.WriteLine("Hello, " + user);
            }
            else if(userInput == 3){
                //Looping and Numbers
                for(int i = 1; i <= 50; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(userInput == 4){
                //Looping and Skipping
                for(int i = 1; i <= 99; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if(userInput == 5){
                //Getting started with conditional
                Console.WriteLine("Enter a letter: n, N, y, Y");
                string letter = Console.ReadLine();
                if(letter == "Y" || letter == "y")
                {
                    Console.WriteLine("YES");
                }
                else if(letter == "N" || letter == "n")
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if(userInput == 6){
                //Comparing Numbers
                Console.Write("Enter your first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if(num1 < num2)
                {
                    Console.WriteLine(num1 + " is less than " + num2);
                }
                else if(num1 > num2)
                {
                    Console.WriteLine(num1 + " is greater than " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " is equal to " + num2);
                }
            }
            else if(userInput == 7){
                //More on Conditionals
                Console.Write("Enter your first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your third number: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                if(num1 == num2 && num1 == num3)
                {
                    Console.WriteLine("EQUILATERAL");
                }
                else if(num1 != num2 || num1 != num3 || num2 != num3)
                {
                    Console.WriteLine("ISOSCELES");
                }
                else
                {
                    Console.WriteLine("SCALENE");
                }
            }
            else if(userInput == 8){
                //Compute the Average
                Console.Write("Please enter a number for loop: ");
                double userNum = Convert.ToDouble(Console.ReadLine());
                double total = 0;

                userNum = Convert.ToDouble(String.Format("{0:0.000}", userNum));
            
                Console.WriteLine(userNum);
                for(int i = 0; i < userNum; i++)
                {
                    double user = 0.0;
                    Console.Write(i + ") Enter a new number: ");
                    user = Convert.ToDouble(Console.ReadLine());
                    total += user;
                }

                total = total / userNum;
                Console.WriteLine(String.Format("{0:0.000}", total));
                }
            else{
                Console.WriteLine("You enter invalid number. Try again");
            }
        }
    }
}
