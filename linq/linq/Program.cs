
using System;
using System.Linq;
using System.Collections.Generic;

class Employee{

    string Name,Location;
    int Salary;
    static void Main(string[] args) {

        List<Employee> Geeks = new List<Employee>(){
        new Employee{Location="Kathmandu", Name = "Samyog", Salary = 50000},
        new Employee{Location="Kathmandu", Name = "Ram", Salary = 65000},
        new Employee{Location="Kathmandu", Name = "Krishna", Salary = 400},
        new Employee{Location="Pok", Name = "Sonial", Salary = 20000},
        new Employee{Location="pok", Name = "Mickey", Salary = 70000},
    };
  IEnumerable<Employee> result = from Employee in Geeks where Employee.Salary>1000 && Employee.Location=="Kathmandu" select Employee;

        foreach (Employee x in result)
        {
            Console.WriteLine($"{x.Name}\t {x.Location} \t{x.Salary}");
        }
    }
}
