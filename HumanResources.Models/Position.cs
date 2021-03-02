using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResources.Models
{
    public class Position
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal FixedSalary { get; set; }
    }
}
