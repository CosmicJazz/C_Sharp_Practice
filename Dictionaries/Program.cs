using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        //Key - Value
        //Auto - Car
        //keys can be anything, but an intiger or some unique number value is a good idea
        //the below example is not a great idea, as many entities can potentiallt have the same key

        static void Main(string[] args)
        {
            //example dict
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            //create some raw data to later populate into a dict
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lara", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            //dict creation and population
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            //to update a value within a dictionary, do the following
            string KeyToUpdate = "HR";

            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with key: {0}", KeyToUpdate);
            }

            //to remove dictionary values, do the following
            //notice there is no need to check ContainsKey
            //The Remove funtion will remove the entity and return a bool so it can be used as the if statement

            string KeyToRemove = "Intern";

            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed!", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found with key: {0}", KeyToRemove);
            }

            //there are many ways to access the dictionary data
            //this below example will show how to use the ElementAt() function to retrieve all the data stored in the dict

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) the retun the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i); //Need to learn linking
                //print the Key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("\nEmployee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            //the below is another example of how to pull data from the dict
            //this simply takes in a string and determines if the key is there
            //if it is, it will return the value stored

            string key = "CFO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}", empl.Name);
                Console.WriteLine("Employee Role: {0}", empl.Role);
                Console.WriteLine("Employee Age: {0}", empl.Age);
                Console.WriteLine("Employee Salary: {0}", empl.Salary);
            }
            else
            {
                Console.WriteLine("\nNo employee found with the Key '{0}'", key);
            }

            //one more example below
            //this one uses the TryGetValue() function to return a bool if the value is found

            Employee result = null;
            //using TryGetValue() it returns true the operation was successful and false otherwise
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("\nValue Retrieved!");
                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("This Key does not exist...");
            }
        }
    }


    //Emplyee class
    class Employee
    {
        //few properties like Role, Name, Age, and Pay Rate.

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        //simple constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
