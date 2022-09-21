using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _19
    {
        static void Main()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter a number to check palindrome:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("It is palindrome");
            else
                Console.WriteLine("It is not palindrome");
        }
    }
}
