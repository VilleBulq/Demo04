using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Boss boss = new Boss();
            emp.Name = "Jaska";
            boss.Name = "Jaska";
            emp.Profession = "Ope ";
            boss.Profession = "CEO";
            boss.Car = "Audi";
            Console.WriteLine(boss.ToString());
            Console.WriteLine(emp.ToString());

        }
    }
}
