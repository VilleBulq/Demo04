using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.SetVol(0);
            Console.WriteLine(radio.ToString());
            radio.SetVol(1);
            Console.WriteLine(radio.ToString());
            radio.SetFreq(23000);
            Console.WriteLine(radio.ToString());

        }
    }
}
