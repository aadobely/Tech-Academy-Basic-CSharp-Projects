using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display header for the program
            Console.WriteLine("=== Employee Comparison Demo ===");
            Console.WriteLine();

            // Create first Employee object with Id=1, FirstName=John, LastName=Doe
            Employee employee1 = new Employee(1, "John", "Doe");

            // Create second Employee object with Id=2, FirstName=Jane, LastName=Smith
            Employee employee2 = new Employee(2, "Jane", "Smith");

            // Display information about the first employee
            Console.WriteLine("Employee 1:");
            Console.WriteLine("  ID: " + employee1.Id);
            Console.WriteLine("  Name: " + employee1.FirstName + " " + employee1.LastName);
            Console.WriteLine();

            // Display information about the second employee
            Console.WriteLine("Employee 2:");
            Console.WriteLine("  ID: " + employee2.Id);
            Console.WriteLine("  Name: " + employee2.FirstName + " " + employee2.LastName);
            Console.WriteLine();

            // Compare the two employees using the overloaded == operator
            // This will compare their Id properties
            Console.WriteLine("=== Comparison Results ===");
            if (employee1 == employee2)
            {
                // This message shows if the two employees have the same Id
                Console.WriteLine("employee1 == employee2: TRUE - Both employees have the same ID");
            }
            else
            {
                // This message shows if the two employees have different Ids
                Console.WriteLine("employee1 == employee2: FALSE - Employees have different IDs");
            }

            // Compare using the overloaded != operator
            if (employee1 != employee2)
            {
                // This message shows if the two employees are different
                Console.WriteLine("employee1 != employee2: TRUE - Employees are different");
            }
            else
            {
                // This message shows if the two employees are the same
                Console.WriteLine("employee1 != employee2: FALSE - Employees are the same");
            }

            Console.WriteLine();

            // Create a third employee with the same Id as employee1 (Id=1)
            // This will help demonstrate that the comparison is based on Id only
            Employee employee3 = new Employee(1, "Bob", "Johnson");

            // Display information about the third employee
            Console.WriteLine("Employee 3:");
            Console.WriteLine("  ID: " + employee3.Id);
            Console.WriteLine("  Name: " + employee3.FirstName + " " + employee3.LastName);
            Console.WriteLine();

            // Compare employee1 and employee3 using the overloaded == operator
            Console.WriteLine("=== Comparing Employee 1 and Employee 3 ===");
            if (employee1 == employee3)
            {
                // Even though names are different, Ids are the same (both have Id=1)
                Console.WriteLine("employee1 == employee3: TRUE - Both have ID: 1 (even though names differ)");
            }
            else
            {
                Console.WriteLine("employee1 == employee3: FALSE - Different IDs");
            }

            // Compare using != operator
            if (employee1 != employee3)
            {
                Console.WriteLine("employee1 != employee3: TRUE - Employees are different");
            }
            else
            {
                Console.WriteLine("employee1 != employee3: FALSE - Employees have the same ID: 1");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
