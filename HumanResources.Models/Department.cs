using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResources.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Title { get; set; }
        
        public Employee[] Employees { get; set; }


        public double GetAverageAge()
        {
            return Employees.Select(e => e.Age).Average();
        }

    }
}
