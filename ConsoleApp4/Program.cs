using HumanResources.Models;
using System;

namespace ConsoleApp4
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
                Name = "Ivanov"
            };

            Employee employee2 = new Employee(department)
            {
                Id = 2,
                Name = "Petrov"
            };

            Employee employee3 = new Employee(department)
            {
                Id = 3,
                Name = "Stoma"
            };

            Position director = new Position();
            director.Name = "Директор";

            employee1.Position = director;
            employee2.Position = new Position { Name = "Разработчик" };
            employee3.Position = new Position { Name = "Ученик" };




            //employee1.Department = department;

            string info1 = employee1.GetInfo();
            string info2 = employee2.GetInfo();
            //employee1.Id = 1;

            Console.WriteLine(string.Join(", ",
                new string[] { employee1.GetInfo(), employee3.GetInfo("Dr") }));



            //Console.WriteLine(employee1.Equals(employee2));


            //Console.WriteLine("Enter number");
            //int n = int.Parse(Console.ReadLine());

            //for (int j = 2; j <= n; j++)
            //{
            //    bool isPrime = IsPrime(j);
            //    if (isPrime)
            //    {
            //        Console.WriteLine($"{j} is Prime"); ;
            //    }
            //}


        }

        private static bool IsPrime(int n)
        {
            int i = 2;
            // bool isPrime = true;
            while (i <= Math.Sqrt(n))

            {
                if (n % i == 0)

                {
                    return false;
                }
                i++;
            }

            return true;

        }
    }
}
