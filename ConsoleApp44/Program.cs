using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Employees before instantiation:{Employee.Count}");

            var e1 = new Employee("Susan", "Baker");
            var e2 = new Employee("Bob", "Blue");

            Console.WriteLine($"\nEmployees after instantiation:{Employee.Count}");

            Console.WriteLine($"\nEmployee 1:{e1.FirstName}{e1.LastName}");
            Console.WriteLine($"\nEmployee 2:{e2.FirstName}{e2.LastName}");
            Console.ReadLine();

            e1 = null;
            e2 = null;
        }
    }
}
