using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResources.Models
{
    public class Employee
    {
        int i = 1;
        public Employee(Department department)
        {
            Department = department;
        }

        public long Id { get;  set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Department Department { get; }

        public Position Position { get; set; }

        /// <summary>
        /// Возвращает описание сотрудника
        /// </summary>
        /// <param name="title">Титул</param>
        /// <returns>Описание сотрудника</returns>
        public string GetInfo(string title = "")
        {
            i = 1;
            if (title == "")
            {
                i = 3;
            }

            i = 2;
            return $"{title}{(string.IsNullOrEmpty(title) ? "" : ".")} {Name} ({Department.Title}) ({Position.Name})";
        }

        public string GetString()
        {
            i = 2;
            return "s";
        }

    }
}
