using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    abstract class Employee
    {
        public string? Name {  get; set; }
        public string? LastName { get; set; }
        public string? IDNumber { get; set; }
        public decimal Salary {  get; set; }
        public decimal Income {  get; set; }

        public Employee(string name, string lastName, string id, decimal salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.IDNumber = id;
            this.Salary = salary;

        }

        public abstract decimal CalculateIncome();

    }
}
