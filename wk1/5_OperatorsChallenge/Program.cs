using System;

namespace _5_OperatorsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            bool exitLoop = false;
            string userAnswer;
            int userInput = 0;
            int userNum1 = 0;
            int userNum2 = 0;
            bool userBool = true;

            do{
            Console.WriteLine("Pick a number that you want to use method:\n" +
                              "1) Increment()\n" +
                              "2) Decrement()\n" +
                              "3) Not()\n" +
                              "4) Negate()\n" +
                              "5) Sum()\n" +
                              "6) Diff()\n" +
                              "7) Product()\n" +
                              "8) Quotient()\n" +
                              "9) Remainder()\n" +
                              "10) And()\n" +
                              "11) Or()\n" );
            userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput <= 2 || userInput >= 4){
                Console.WriteLine("Enter your first num: ");
                userNum1 = Convert.ToInt32(Console.ReadLine());
            }
            else if(userInput == 3){
                Console.WriteLine("Enter 'true' or 'false: ");
                userBool = Convert.ToBoolean(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter your second num: ");
                userNum2 = Convert.ToInt32(Console.ReadLine());
            }
            
            
            switch(userInput){
                case 1: p.Increment(userNum1); break;
                case 2: p.Decrement(userNum1); break;
                case 3: p.Not(userBool); break;
                case 4: p.Negate(userNum1); break;
                case 5: p.Sum(userNum1, userNum2); break;
                case 6: p.Diff(userNum1, userNum2); break;
                case 7: p.Product(userNum1, userNum2); break;
                case 8: p.Quotient(userNum1, userNum2); break;
                case 9: p.Remainder(userNum1, userNum2); break;
                case 10: p.And(userNum1, userNum2); break;
                case 11: p.Or(userNum1, userNum2); break;                
                }

                Console.WriteLine("\nWant to do other one?");
                userAnswer = Console.ReadLine();

                if(userAnswer == "y" || userAnswer == "Y"){
                    exitLoop = true;
                }

            }
            while(!exitLoop);
        }

        public void Increment(int num1){
            Console.WriteLine("\n###### Increment ######");
            num1++;
            Console.WriteLine(num1);
        }

        public void Decrement(int num1){
            Console.WriteLine("\n###### Decrement ######");
            num1--;
            Console.WriteLine(num1);

        }

        public void Not(bool userBool){
            Console.WriteLine("\n###### Not ######");
            Console.WriteLine(!userBool);
        }

        public void Negate(int num1){
            Console.WriteLine("\n###### Negate ######");
            Console.WriteLine(num1 * -1);
        }

        public void Sum(int num1, int num2){
            Console.WriteLine("\n###### Sum ######");
            Console.WriteLine(num1 + num2);
        }

        public void Diff(int num1, int num2){
            Console.WriteLine("\n###### Diff ######");
            Console.WriteLine(num1 - num2);
        }

        public void Product(int num1, int num2){
            Console.WriteLine("\n###### Product ######");
            Console.WriteLine(num1 * num2);
        }

        public void Quotient(int num1, int num2){
            Console.WriteLine("\n###### Product ######");
            Console.WriteLine(num1 / num2);
        }

        public void Remainder(int num1, int num2){
            Console.WriteLine("\n###### Product ######");
            Console.WriteLine(num1 % num2);
        }

        public void And(int num1, int num2){
            Console.WriteLine("\n###### Product ######");
            if(num1 != 0 && num1 >= num2){
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("It is false");

            }
        }

        public void Or(int num1, int num2){
            Console.WriteLine("\n###### Product ######");
            if(num1 == num2 || num1 < 0){
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("It is false");

            }
        }
    }
}
