using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Peli();
         
        }
        public static void Peli()
        {
            Rommi rommi = new Rommi();
            while (rommi.Health > 0)
            {
                RunPaska();
            }
        }
        public static void RunPaska() {
            Console.WriteLine("Do something");
            Console.WriteLine("1: Go to mission");
            Console.WriteLine("2: Open your bag");
            int valinta = Int32.Parse(Console.ReadLine());
            if(valinta == 1) {
            Mission();
             }
            else if(valinta == 2)
            { OpenBag(); }
        }
        public static void Mission() { }
        public static void OpenBag() {
            List<string> bag = new List<string>();
            foreach(string item in bag) {
                Console.WriteLine(item);
            }
        }
        
        
    }
}
