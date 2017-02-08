using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Vehicle() {

        }
        public Vehicle(string name, int year, string color) {
            Name = name;
            Year = year;
            Color = color;
        }
        public override string ToString()
        {
            return base.ToString() + "Name " + Name + " Year " + Year +  " Color " + Color;
        }
    }
}
