using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int salary { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id=1,Name="Chintan Negi",Gender="Male",Department="Software Engineer",salary=89000},
                new Employee{Id=2,Name="Raghav Negi",Gender="Male",Department="Software Engineer",salary=49000},
                new Employee{Id=3,Name="Uday Negi",Gender="Male",Department="Software Engineer",salary=59000},
                new Employee{Id=4,Name="Aayush Negi",Gender="Male",Department="Software Engineer",salary=49000},
                new Employee{Id=5,Name="Kapil Negi",Gender="Male",Department="HR",salary=39000},
                new Employee{Id=6,Name="Narendera Negi",Gender="Male",Department="HR",salary=29000},
                new Employee{Id=7,Name="Arjun Negi",Gender="Male",Department="Software Engineer",salary=19000},
                new Employee{Id=8,Name="Kavita Negi",Gender="Female",Department="HR",salary=99000},
                new Employee{Id=9,Name="Himani Negi",Gender="Female",Department="HR",salary=1000},
                new Employee{Id=10,Name="Kirti Negi",Gender="Female",Department="Software Engineer",salary=5000}
            };
        }
    }
}
