//how to import parts of the .net class library
using System;
//namespace is a collection of related classes when we need to use a class from one file inside of another we use the namespace in which the class is defined.
namespace Classes
{
    //almost all C# code is contained inside a class. It is convention to use the same name for the class and the .cs file
    class Program
    {
        //main is "method" in the program class. a method is a function that exists inside a class. Main is a static method. 
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            
            Company myCompany = new Company("My Company", DateTime.Now);


            // Create three employees
            Employee employee1 = new Employee("Jane", "Doe", "Lion Tamer", new DateTime(2015, 3, 23));
            Employee employee2 = new Employee("John", "Smith", "Software Engineer", new DateTime(2018, 6, 10));
            Employee employee3 = new Employee("Alice", "Johnson", "Marketing Specialist", new DateTime(2020, 9, 5));


            // Assign the employees to the company
            myCompany.Employees.Add(employee1);
            myCompany.Employees.Add(employee2);
            myCompany.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.ListEmployees();
        }
    }
}