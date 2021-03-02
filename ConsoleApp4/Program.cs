using HumanResources.Models;
using System;
using System.Linq;

namespace HumanResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department
            {
                Id = 1,
                Title = "Accounting"                
            };

            Employee employee1 = new Employee(department)
            {
                Id = 1,
                Name = "Ivanov",
                BirthDate = new DateTime(1999, 03, 22),
                Gender = Gender.Male
            };

            Employee employee2 = new Employee(department)
            {
                Id = 2,
                Name = "Petrova",
                BirthDate = new DateTime(1991, 6, 2),
                Gender = Gender.Female
            };

            Employee employee3 = new Employee(department)
            {
                Id = 3,
                Name = "Antonov",
                BirthDate = new DateTime(1995, 11, 12),
            };

            Position director = new Position();
            director.Title = "Директор";

            employee1.Position = director;
            employee2.Position = new Position { Title = "Разработчик" };
            employee3.Position = new Position { Title = "Ученик" };


            //employee1.Department = department;

            string info1 = employee1.GetInfo();
            string info2 = employee2.GetInfo();
            //employee1.Id = 1;



            Console.WriteLine(string.Join(", ",
                new string[] { employee1.GetInfo(), employee3.GetInfo("Dr") }));


            Employee[] employees = new Employee[] { employee1, employee2, employee3 };

            Console.WriteLine(string.Join("\n", employees.Select(e => e.GetInfo())));


            department.Employees = employees;

            Console.WriteLine($"Средний возраст по отделу {department} равен {department.GetAverageAge():0.0}");
        }       
    }
}
