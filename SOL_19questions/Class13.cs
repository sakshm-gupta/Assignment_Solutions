using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _13
    {
        static void Main()
        {
            Console.WriteLine("Enter first numbers:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second numbers:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third numbers:");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine($"{a} is the largest");
                else
                    Console.WriteLine($"{c} is the largest");
            }
            else if (b > c)
                Console.WriteLine($"{b} is the largest");
            else
                Console.WriteLine($"{c} is the largest");
        }
    }
}
