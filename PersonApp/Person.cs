using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
    public string Firstname { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }

    public Person() {

    }
    public Person(string firstname, string lastname) {
            Firstname = firstname;
            LastName = lastname;
        }
        public void PersonMethod() {
            Console.WriteLine("this method belongs to person");
        }
        public override string ToString()
        {
            return Firstname + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;
                    }
    }
}
