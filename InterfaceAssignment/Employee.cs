using System;

namespace InterfaceAssignment
{
    // Employee class that implements the IQuittable interface
    // The : IQuittable means this class must implement all methods from IQuittable
    class Employee : IQuittable
    {
        // Properties to store employee information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        // Constructor to create a new employee with initial values
        public Employee(string firstName, string lastName, int employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
        }

        // Implementation of the Quit method from IQuittable interface
        // This method is called when an employee quits their job
        public void Quit()
        {
            // Display a message showing the employee is quitting
            Console.WriteLine("Employee " + FirstName + " " + LastName + " (ID: " + EmployeeId + ") has quit the job.");
            Console.WriteLine("Processing exit paperwork...");
            Console.WriteLine("Goodbye and good luck!");
        }
    }
}
