using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class Class3
    {
        static void Main()
        {
            Console.WriteLine("Enter 1st Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
