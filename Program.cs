using System; // Allows us to use Console

namespace IQuittableDemo
{
    // Main program class
    internal class Program
    {
        // Entry point for the program
        static void Main(string[] args)
        {
            // Create a new Employee object and set its properties
            Employee emp = new Employee
            {
                FirstName = "John",  // First name of the employee
                LastName = "Doe"     // Last name of the employee
            };

            // --- POLYMORPHISM EXAMPLE ---
            // Create an IQuittable type reference and assign the Employee object to it
            // This works because Employee implements IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit() method using the IQuittable reference
            // Even though the variable is of type IQuittable,
            // it will run Employee's version of the Quit() method
            quittableEmp.Quit();

            // Keep the console open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}