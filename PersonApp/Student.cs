﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Student : Person
    {
    public string StudentID { get; set; }

    public Student() {

    }
    public Student(string firstname, string lastname, string studentID)
    : base(firstname, lastname) {
    StudentID = studentID;
    }
    public void StudentMethod() {
            Console.WriteLine("Studentti metodi");
    }
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
    
}
