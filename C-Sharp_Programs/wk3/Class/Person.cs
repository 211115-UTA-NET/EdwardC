//Namespace

namespace SampleNamespace
{
    // Another Class
    // Noted: we don't use any parameter on Class
    // AccessModifier class ClassName{}
    public class Person
    {
        // default is private accessModifier
        
        private string firstName;   // if access is public, then  outside of this Class can access firstName ex: Program Class
        private string lastName;

        // Constructor(s) start here
        // AccessModifier className with no parameters
        public Person()
        {
            firstName = "Jackie";
            lastName = "Chan";
        }
        // Access Modifier className(Paramenter)
        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
        // End Constructor(s)


        // Function/Method start here

        // Set function (Has nothing with setter)
        public void setFirstName(string name)
        {
            firstName = name;
        }
        public void setLastName(string name)
        {
            lastName = name;
        }
        
        // Get Function (Has nothing with getter)
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }


        // AccessModifier returnType methodName(Parameters)
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }
        // End Function(s)
    }
    //End Person
}