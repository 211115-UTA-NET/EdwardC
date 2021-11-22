using System;

namespace _3_DataTypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            // create a variable for each of the "primitive" datatypes
            byte numA         = 255;
            sbyte numAa       = 127;
            int numB          = 2000222111;
            uint numBb        = 4000222111;
            short numC        = 32767;
            ushort numCc      = 65535;
            long numD         = 3;
            ulong numDd       = 7;
            float numE        = 3.14F;
            double numF       = 78.25D;
            char letter       = 'a';
            bool checkBoolean = true;
            string sentence   = "How are you";
            //decimal numDec    = 120;

            string String1    = "I control text";
            string String2    = "834";

            //p.parseInt(String1, String2);

            Console.WriteLine(numA);
            Console.WriteLine(numAa);
            Console.WriteLine(numB);
            Console.WriteLine(numBb);
            Console.WriteLine(numC);
            Console.WriteLine(numCc);
            Console.WriteLine(numD);
            Console.WriteLine(numDd);
            Console.WriteLine(numE);
            Console.WriteLine(numF);
            Console.WriteLine(letter);
            Console.WriteLine(checkBoolean);
            Console.WriteLine(sentence);
            //Console.WriteLine(numDec);
            Console.WriteLine(String1);
            Console.WriteLine(String2);
        }

        public void parseInt(){
            bool result;
            string name;
            int num;

            //result = int.TryParse(name, out num);
        }
    }
}
