using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    internal class AdminEmployee : Employee, ICalculateBonus
    {
        public bool GoalAchieved {  get; set; }
        public decimal Bonus { get; set; }

        public AdminEmployee(string name, string lastName, string id, decimal salary) : base(name, lastName, id, salary) { }

        public override decimal CalculateIncome()
        {
            return Salary +Bonus;
        }

       public decimal CalculateBonus()
        {
            Bonus = GoalAchieved ? Salary : Salary / 2;
            return Bonus;
        }

        public override string ToString()
        {
            string myString = $"Full Name: {Name} {LastName}\nID: {IDNumber}\nSalary =: {Salary}\nGoal Achieved: {(GoalAchieved ? "Yes" : "No")}\nBonus: {CalculateBonus()}\nTotal Income: {this.CalculateIncome()}";
            return myString;
        }
    }
}
