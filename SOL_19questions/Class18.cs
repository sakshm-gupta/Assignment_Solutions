using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _18
    {
        static void Main()
        {
            Console.WriteLine("Enter first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string str2 = Console.ReadLine();
            if (str1 != str2)
                Console.WriteLine("Not same");
            else
                Console.WriteLine("Same");
        }
    }
}
