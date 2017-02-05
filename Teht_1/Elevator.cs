using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_1
{
    class Elevator
    {
        private int minFloor = 1;
        private int maxFloor = 5;

        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value >= minFloor && value <= maxFloor)
                {
                    floor = value;
                }
                else {
                    Console.WriteLine("Floor is not valid only 1-5 floor");
                }
            }
        }
    }
}


