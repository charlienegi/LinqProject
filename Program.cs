using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var employees = from item in Employee.GetEmployees()
            //                group item by item.Department
            //                into eGroup
            //                orderby eGroup.Key ascending
            //                select new
            //                {
            //                    key = eGroup.Key,
            //                    Employees = eGroup.OrderBy(x => x.Name)
            //                };
            var employees = Employee.GetEmployees().GroupBy(x => new { x.Department }).OrderBy(x => x.Key.Department).Select(x => new
            {
                key = x.Key.Department,
                Employees = x.OrderBy(x => x.Name)
            });
            foreach (var emplo in employees)
            {
                Console.WriteLine("{0}-{1}",emplo.key,emplo.Employees.Count());
                Console.WriteLine("---------------------");
                foreach(var employee in emplo.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }

            }
        }
    }
}
