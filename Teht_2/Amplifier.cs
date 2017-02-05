using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_2
{
    class Amplifier
    {
    private int maxVolume = 100;
    private int minVolume = 0;

        private int volume;
        public int Volume {
        get { return volume; }
        set { if(value >= maxVolume) {
                    Console.WriteLine("Too much volume ");
                    volume = maxVolume;
        }
        else if(value <= minVolume) {
                    Console.WriteLine("Too low volume");
                    volume = minVolume;
        }
        else {
                    volume = value;
        }
         }
        }
    }
}
