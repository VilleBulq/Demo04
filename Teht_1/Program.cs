using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            bool working = true;
            while (working)
            {
                Console.WriteLine("Elevator is now in floor: " + hissi.Floor);
                Console.Write("Give a new floor number(1 - 5) >");
                int kerros = Int32.Parse(Console.ReadLine());
                if(kerros == 0) { working = false; }
                hissi.Floor = kerros;
            }



        }
    }
}
