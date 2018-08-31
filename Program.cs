using System;
using System.Collections.Generic;

namespace Classes
{

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }

    public class Company
    {

        // Some read only properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> employeeList = new List<Employee>();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime creationDate)
        {
            Name = name;
            CreatedOn = creationDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company liveWell = new Company("Live Well", new DateTime(2018, 5, 21));
            Console.WriteLine($"{liveWell.Name} was founded on {liveWell.CreatedOn}");

            // Create three employees
            Employee loriSmith = new Employee()
            {
                FirstName = "Lori",
                LastName = "Smith",
                Title = "Developer",
                StartDate = new DateTime(2018, 5, 21)
            };

            Employee jenMiller = new Employee()
            {
                FirstName = "Jen",
                LastName = "Miller",
                Title = "Developer",
                StartDate = new DateTime(2018, 5, 23)
            };

            Employee sarahLuke = new Employee()
            {
                FirstName = "Sarah",
                LastName = "Luke",
                Title = "CEO",
                StartDate = new DateTime(2017, 4, 23, 8, 0, 0)
            };
            // Assign the employees to the company
            liveWell.employeeList.Add(loriSmith);
            liveWell.employeeList.Add(jenMiller);
            liveWell.employeeList.Add(sarahLuke);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee e in liveWell.employeeList)
            {
                System.Console.WriteLine($"{e.FirstName} {e.LastName} has been working at {liveWell.Name} as {e.Title} since {e.StartDate} ");
            }
        }
    }
}