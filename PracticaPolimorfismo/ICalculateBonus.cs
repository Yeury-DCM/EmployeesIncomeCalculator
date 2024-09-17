using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    internal interface ICalculateBonus
    {
        bool GoalAchieved {  get; set; }
        decimal Bonus {  get; set; }
        abstract decimal CalculateBonus();
    }
}
