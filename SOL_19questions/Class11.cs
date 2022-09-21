using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i*n);
            }
        }
    }
}
