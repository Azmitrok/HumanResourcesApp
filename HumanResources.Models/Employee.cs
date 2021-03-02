using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResources.Models
{
    public class Employee
    {
        const string EmployeePrefix = "Сотрудник";
        public Employee(Department department)
        {
            Department = department;
        }

        public long Id { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public double Age
        {
            get
            {
                return Math.Round((DateTime.Now - BirthDate).TotalDays / 365, 2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Department Department { get; }

        public Position Position { get; set; }

        public Employee Supervisor { get; set; }

        /// <summary>
        /// Возвращает описание сотрудника
        /// </summary>
        /// <param name="title">Титул</param>
        /// <returns>Описание сотрудника</returns>
        public string GetInfo(string title = "")
        {
            return $"{EmployeePrefix} {(string.IsNullOrEmpty(title) ? "" : title + ".")} {Name}, {BirthDate}(Текущий возраст-{Age}) ({Department.Title}, {Position.Title})";
        }



    }
}
