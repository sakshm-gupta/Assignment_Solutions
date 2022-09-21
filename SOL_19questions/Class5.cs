using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class Class5
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            int odd = 0, even = 0;

            Console.WriteLine("Enter Array Values");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                //arr1[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Even Numbers:" + even);
            Console.WriteLine("Total Odd Numbers:" + odd);
            Console.ReadLine();
        }
    }
}
