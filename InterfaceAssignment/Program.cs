using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object with first name, last name, and employee ID
            Employee employee = new Employee("John", "Smith", 12345);

            // Display employee information
            Console.WriteLine("=== Employee Information ===");
            Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName);
            Console.WriteLine("ID: " + employee.EmployeeId);
            Console.WriteLine();

            // This demonstrates POLYMORPHISM
            // We create a variable of type IQuittable (the interface)
            // and assign it an Employee object
            // This works because Employee implements the IQuittable interface
            Console.WriteLine("=== Using Polymorphism ===");
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the interface type
            // This is polymorphism - calling a method through an interface reference
            quittableEmployee.Quit();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
