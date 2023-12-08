using System;

namespace Classes
{
    // Definition of the Employee class
    public class Employee
    {
        // Properties
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        // Constructor
        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            // Assigning values to the properties during object creation
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}
