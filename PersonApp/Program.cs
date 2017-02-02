using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // person.Firstname = "Jaska";
            // create pone student object
            Student student = new Student();
            student.Firstname = "Niko";
            student.LastName = "Mankinen";
            student.PhoneNumber = "696969696";
            student.Address = "Dynamo 2";
            student.Age = 23;
            student.StudentID = "K1532";
            student.StudentMethod();
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D5560");
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "04429666";
            Console.WriteLine(teacher.ToString());
            student.PersonMethod();

        }
    }
}
