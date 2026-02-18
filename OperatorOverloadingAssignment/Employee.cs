using System;

namespace OperatorOverloadingAssignment
{
    // Employee class to store employee information
    class Employee
    {
        // Property to store the employee's unique ID number
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Constructor to create a new Employee with all properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the == operator to compare two Employee objects by their Id
        // This allows us to use == to check if two employees are the same person
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null - they are equal
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // Check if one is null and the other is not - they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id property of both employees
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to compare two Employee objects
        // Comparison operators must be overloaded in pairs (== and !=)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the == operator and return the opposite result
            return !(emp1 == emp2);
        }

        // Override Equals method (required when overloading == operator)
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee)
            {
                // Cast to Employee and compare using == operator
                return this == (Employee)obj;
            }
            return false;
        }

        // Override GetHashCode method (required when overriding Equals)
        public override int GetHashCode()
        {
            // Return the Id as the hash code since we compare by Id
            return Id.GetHashCode();
        }
    }
}
