// Using statements

using System;
using System.IO; // File: Read and Write
using System.Collections.Generic; //enable to use Dictionary, List, Stack, and more

//Namespace
namespace SampleNamespace
{
    //Class declartion
    class Program
    {
        // Function declaration
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // // First Object
            // Person newGuy = new Person();
            // newGuy.Introduce();

            // // Second Object
            // Person someOtherPerson = new Person("Peter", "Griffon");
            // someOtherPerson.Introduce();

            // Console.WriteLine(newGuy.getFirstName());
            // newGuy.setFirstName("Eddie");
            // Console.WriteLine(newGuy.getFirstName());

            // Employee Kyler = new Employee(40, 18.50, "Kyler", "Dennis");
            // Kyler.doWork();
            // Kyler.Introduce();

            // Employee Eddie = new Employee();
            // Eddie.Introduce();
            // Eddie.doWork();
            // Eddie.earnWork();

            // Console.WriteLine("\nAfter change information");
            // Eddie.setHoursWorked(40);
            // Eddie.setPayRate(18.50);

            // Eddie.changeName("Eddie", "Cicio");
            // Eddie.Introduce();
            // Eddie.doWork();
            // Eddie.earnWork();

            // Console.WriteLine("\nAgain Change Information");
            // Eddie.HoursWorked = 60;
            // Eddie.PayRate = 25.25;
            // Eddie.doWork();
            // Eddie.earnWork();

            // Employee Seth = new Employee("Seth", "Greek");
            // Seth.Introduce();
            // Seth.doWork();
            // Seth.earnWork();

            // Trainee Melinda = new Trainee();
            // Melinda.doWork();
            // Melinda.Introduce();
            // Console.WriteLine($"Melinda is in training: {Melinda.getInTraining()}");

            // Customer Howard = new Customer(200, "Howard", "Wen");
            // Howard.Introduce();
            // Console.WriteLine(Howard.CashOnHand);

            Manager Peter = new Manager();
            Peter.Introduce();
            Peter.doWork();
            Peter.earnWork();
            Console.WriteLine(Peter.getAuthorizationLevel());
            Console.WriteLine(Peter.getID());

            Manager Lois = new Manager("00001", "A", 7436, 40, 35.50, "Lois", "Butterfinger");
            Lois.Introduce();
            Lois.doWork();
            Lois.earnWork();
            Console.WriteLine(Lois.getAuthorizationLevel());
            Console.WriteLine(Lois.getID());
            Lois.helpCustomer();

            Police policeGuy = new Police("police sergeant", "Marvin", "Gether");
            policeGuy.Introduce();
            policeGuy.policeArrive();
        }
        // End Main
    }
    //End Person Class
}