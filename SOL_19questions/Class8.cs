using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    //using System;
    internal class Class8
    {
        public static void Main(string[] args)
        {
            int i, fact = 1;
            Console.Write("Enter any Number: ");
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
    }
}
