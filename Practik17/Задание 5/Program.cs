using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP17_5
{
    enum EmploymentStatus { Active, OnLeave, Terminated }
    class Employee
    {
        public string Name { get; set; }
        public DateTime? HireDate { get; set; }
        public EmploymentStatus Status { get; set; }

        public int GetYearsWorked()
        {
            if (HireDate == null)
                return -8;

            var yearsWorked = DateTime.Now.Year - HireDate.Value.Year;
            if (DateTime.Now < HireDate.Value.AddYears(yearsWorked))
                yearsWorked--;

            return yearsWorked;
        }
        public override string ToString()
        {
            return $"{Name}, статус: {Status}, стаж: {(HireDate == null ? "не указан" : GetYearsWorked().ToString())}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Name = "Леонид",
                HireDate = new DateTime(2000, 11, 17),
                Status = EmploymentStatus.Active
            };
            Console.WriteLine(emp.GetYearsWorked()); 
            emp.HireDate = null;
            Console.WriteLine(emp.GetYearsWorked()); 
            Console.WriteLine(emp); 
        }
    }
}
