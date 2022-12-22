using System;
using System.Linq;
using System.Collections.Generic;
class Employee
{
    string Name, Location,College;
    static void Main(string[] args)
    {
        List<Employee> Orgs = new List<Employee>(){
        new Employee{Location="Kathmandu", Name = "Samyog", College ="KCT"},
        new Employee{Location="Kathmandu", Name = "Ram", College ="ISMT" },
        new Employee{Location="Kathmandu", Name = "Krishna", College="KCT"},
        new Employee{Location="Pok", Name = "Sonial", College = "KCT"},
    };
       var result=Orgs.FindAll(x => x.Location=="Kathmandu" && x.College=="KCT");
        foreach (var x in result)
        {
            Console.WriteLine($"{x.Name}\t {x.Location}\t {x.College}");
        }
    }
}
