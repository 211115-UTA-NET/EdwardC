using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "abcdefghijklmnopqrstuvwxyz";


            // Read individual characters
            Console.WriteLine("####### Individual Character #######");
            char myChar = testString[0];
            Console.WriteLine(myChar);

            // Find the length of a string of characters
            Console.WriteLine("\n####### Length #######");
            // Length function will return the length of the string
            Console.WriteLine(testString.Length);


            // Conatenation - n a series of interconnected things or events
            // line up or join multiple strings one after another

            Console.WriteLine("\n####### Concat #######");
            string one = "this is a string";
            string two = "this is a different string";

            Console.WriteLine(one + " " + two);

            Console.WriteLine(one);
            Console.WriteLine(two);

            // Change cases to uppercase, to lower case
            Console.WriteLine("\n####### Case Changes #######");
            testString = testString.ToUpper();
            Console.WriteLine(testString);
            
            testString = testString.ToLower();
            Console.WriteLine(testString);
            

            // Change case of a specific letter to upper or to lower case

            // trim end, trim start, trm
            Console.WriteLine("\n####### Trim #######");
            string badSpacing = "      hello     world!     ";
            Console.WriteLine("start " + badSpacing + " end");

            badSpacing = badSpacing.TrimStart();
            Console.WriteLine("start " + badSpacing + " end");

            badSpacing = badSpacing.TrimEnd();
            Console.WriteLine("start " + badSpacing + " end");

            badSpacing = badSpacing.Trim();
            Console.WriteLine("start " + badSpacing + " end");

            // Break down a string into component characters
            Console.WriteLine("\n####### SubStrings #######");
            string betterSpacing = "hello world";
            Console.WriteLine(betterSpacing);
            Console.WriteLine(betterSpacing.Substring(6));

            // Compare the contents of a string
        }
    }
}
