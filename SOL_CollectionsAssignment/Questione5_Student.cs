using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOL_CollectionsAssignment
{
    class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string std { get; set; }


    }
    internal class Questione5_Student
    {
        static void Main()
        {
            ArrayList ls = new ArrayList();

            ls.Add(new Student() { rollno = 12, name = "Sia", std = "8th" });
            ls.Add(new Student() { rollno = 122, name = "raam", std = "10th" });
            foreach (Student s in ls)
            {
                Console.WriteLine($"{s.rollno} {s.name} {s.std}");
            }
        }
    }
}
