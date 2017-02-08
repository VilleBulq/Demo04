using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_4
{
    class Boat : Vehicle
    {
    public string Type { get; set; }
    public int Seats { get; set; }

    public Boat() {

    }
    public Boat(string name, int year, string color, string type, int seats):base(name, year,color) {
            Type = type;
            Seats = seats;
    }
        public override string ToString()
        {
            return base.ToString() + "Tyyppi " + Type + " Seats " + Seats;
        }
    }
}
