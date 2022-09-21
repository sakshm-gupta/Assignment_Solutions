using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _14
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            int[] a = new int[5];
            for(int i = 0; i < 5; i++)
            {
                a[i]= int.Parse(Console.ReadLine());
            }
            int min = a[0];
            for(int j = 1; j < 5; j++)
            {
                if(a[j] < min)
                    min = a[j];
            }
            Console.WriteLine(min);
        }
    }
}
