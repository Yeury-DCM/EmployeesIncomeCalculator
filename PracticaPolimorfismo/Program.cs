// En este apartado se hará la prueba del programa

using System;
namespace PracticaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            HourlyTeacher hourlyTeacher = new HourlyTeacher("Anderson", "Ramirez", "402-1849384-2", 800);
            hourlyTeacher.HoursWorked = 40;

            FixedTermTeacher fixedTermTeacher = new FixedTermTeacher("Pedro", "Gutierrez", "005-1823414-2", 45000);
            fixedTermTeacher.GoalAchieved = true;

            AdminEmployee adminEmployee = new AdminEmployee("Shams", "Malik", "004-3838182-2", 650000);
            adminEmployee.GoalAchieved = false;

            Employee[] employees = new Employee[] { hourlyTeacher, fixedTermTeacher, adminEmployee };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee + "\n");
            }
        }
    }
}