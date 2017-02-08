using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_3
{
    class Boss : Employee
    {
    public string Car { get; set; }
    public int Bonus { get; set; }
    public Boss() {

    }
    public Boss(string Name, int Salary, string car, int bonus) 
    : base(Name, Salary)
    {
            Car = Car;
            Bonus = bonus;
    }
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }
    }
}
