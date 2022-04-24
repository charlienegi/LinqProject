using System;
using System.Linq;
namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var employeeList = Employee.GetEmployees()
            //    .GroupBy(x => new { x.Department, x.Gender })
            //    .OrderByDescending(x => x.Key.Department).ThenBy(x => x.Key.Gender)
            //    .Select(x => new
            //    {
            //        Dept = x.Key.Department,
            //        Gender = x.Key.Gender,
            //        Employees=x.OrderByDescending(x=>x.Name)
            //    });
            var employeeList = from item in Employee.GetEmployees()
                               group item by new { item.Department, item.Gender }
                             into eGroup
                               orderby eGroup.Key.Department, eGroup.Key.Gender
                               select new
                               {
                                   Dept = eGroup.Key.Department,
                                   Gender = eGroup.Key.Gender,
                                   Employees = eGroup.OrderByDescending(x => x.Name)
                               };
            foreach (var group in employeeList) {
                Console.WriteLine("{0} department {1} employees count = {2}", group.Dept, group.Gender, group.Employees.Count());
                Console.WriteLine("------------------------");
                foreach(var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
                }
                Console.WriteLine();Console.WriteLine();
                    }

        }
    }
}
