using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSolution
{

    class Person
    {
        string fname;
        string lname;
        string email;
        string date;

        public Person(string a,string  b,string c, string d)
            
        {
            
            this.fname = a;
            
            this.lname = b;
            
            this.email = c;
            
            
            this.date = d;

        }
        public void show()
        {
            Console.WriteLine($"First Name:{fname}\n Last Name:{lname}\n E-mail:{email}\n DATE:{date}");
        }
    }

    class Test1
    {
        static void Main()
        {
            Console.WriteLine("Enter fname,lname,email,date");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();


            //Person p = new Person("saksham","gupta","sakshamgupta1973@gmail.com","21-02-2001");
            Person p = new Person(a,b,c,d);
            p.show();
        }

    }

}
