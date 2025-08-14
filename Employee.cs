using System; // Allows access to Console and other basic .NET features

namespace IQuittableDemo
{
    // Employee class represents an employee
    // It implements the IQuittable interface, so it must define the Quit() method
    public class Employee : IQuittable
    {
        // Property for first name
        public string FirstName { get; set; }

        // Property for last name
        public string LastName { get; set; }

        // Implementation of the Quit() method from the interface
        public void Quit()
        {
            // This is the action that will be performed when an employee quits
            Console.WriteLine($"{FirstName} {LastName} has quit the company. Goodbye!");
        }
    }
}