using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _17
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            for(int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                arr[i] = str[j];
                arr[j] = str[i];
            }
            Console.WriteLine(arr);
        }
    }
}
