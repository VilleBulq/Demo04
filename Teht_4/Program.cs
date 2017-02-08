using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle auto = new Vehicle();
            Bicycle bike = new Bicycle();
            Boat boat = new Boat("Jessus", 1200, "Punane", "Shit", 24);
            Console.WriteLine(boat.ToString());
            auto.Name = "Volvo";
            auto.Year = 1995;
            auto.Color = "Red";
            Console.WriteLine(auto.ToString());
            
            bike.Name = "BMX";
            bike.Color = "RED";
            bike.Geared = true;
            bike.Gearname = "shitgear";
            Console.WriteLine(bike.ToString());

            

        }
    }
}
