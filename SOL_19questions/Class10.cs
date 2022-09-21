using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _10
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int nc = n * n * n;
            if (n < 5)
            {
                for(int i = nc + 1; i < 125; i++)
                {
                    sum = sum + i * i * i;
                }
            }
            else if (n > 5)
            {
                for (int i = 126; i < nc; i++)
                {
                    sum = sum + i * i * i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
