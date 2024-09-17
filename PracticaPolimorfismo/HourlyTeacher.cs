using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
     class HourlyTeacher : Employee
    {
        //En este caso, salario representara el pago por hora
        public int HoursWorked {  get; set; }

        public HourlyTeacher(string name, string lastName, string id, decimal salary) : base(name, lastName, id, salary) { }

        public override decimal CalculateIncome()
        {
            Income = Salary * HoursWorked;
            return Income;
        }

        public override string ToString()
        {
            string myString = $"Full Name: {Name} {LastName}\nID: {IDNumber}\nSalary Per Hour: {Salary}\nHours Worked: {HoursWorked}\nTotal Income: {this.CalculateIncome()}";
            return myString;
        }
    }
}
