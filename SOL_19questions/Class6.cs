using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class Class6
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            int temp = int.Parse(Console.ReadLine());
            double cel = (temp - 32) * 0.556;
            Console.WriteLine(cel);
        }
    }
}
