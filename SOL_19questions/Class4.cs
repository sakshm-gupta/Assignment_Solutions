using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class Class4
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }    
        }
    }
}
