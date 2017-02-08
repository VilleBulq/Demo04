using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_4
{
    class Bicycle : Vehicle
    {
        public bool Geared { get; set; }
        public string Gearname { get; set; }

    public Bicycle() {

    }
    public Bicycle(string name, int year, string color, bool geared, string gearname)
    :base(name, year, color){
            Geared = geared;
            Gearname = gearname;
    }
        public override string ToString()
        {
            return base.ToString() + " Geared" + Geared + " G-Model " + Gearname;
        }
    }
}
