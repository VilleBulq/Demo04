using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            Amplifier amp = new Amplifier();
            while (working)
            {
                Console.WriteLine("Amp volume is " + amp.Volume);
                Console.Write("Give a new volume value >");
                int vol = Int32.Parse(Console.ReadLine());
                amp.Volume = vol;
            }
        }
    }
}
