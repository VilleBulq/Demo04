using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_3
{
    class Employee
    {
    public string Name { get; set; }
    public string Profession { get; set; }
    public int Salary { get; set; }
    public Employee() {

    }
    public Employee(string name, int salary) {
            salary = Salary;
            name = Name;
    }
        public override string ToString()
        {
            return "Name: " + Name + " Salary: " + Salary + " Profession: " + Profession;
        }
    }
}
