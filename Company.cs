using System;
using System.Collections.Generic;

namespace Classes
{
    // Definition of the Company class
    public class Company
    {
        // Properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; }

        // Constructor
        // Assigning values to the properties during object creation
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            // Initializing the Employees property with an empty List<Employee>
            Employees = new List<Employee>();
        }

        // Method to list employees
        public void ListEmployees()
        {
            // Loop through each Employee in the Employees list
            foreach (Employee employee in Employees)
            {
                // Output employee information using string interpolation
                Console.WriteLine($@"
                {employee.FirstName} {employee.LastName} 
                works for {Name} 
                as {employee.Title} 
                since {employee.StartDate:d}.");
            }
        }
    }
}
