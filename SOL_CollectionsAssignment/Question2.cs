using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL_CollectionsAssignment
{
    internal class Question2
    {
        static void Main()
        {
            ArrayList stu = new ArrayList();
            Console.WriteLine("Enter 5 Student names");
            for (int i = 0; i < 5; i++)
            {
                stu.Add(Console.ReadLine());
            }  
            stu.Sort();
            stu.Reverse();
            foreach(var x in stu)

            {
                Console.WriteLine(x as string);
            }
        }
    }
}
