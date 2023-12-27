using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class Employee
    {
        public string name;
        public int age;
        public string department;

        public Employee(string name,int age, string department) {
            
            this.name = name;
            this.age = age; 
            this.department = department;
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Department:{department}");
        }
    }
}
