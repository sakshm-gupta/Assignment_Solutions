using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class _15
    {
        static void Main()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 marks:");
            for(int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            for(int i = 0; i < 10; i++)
            {
                total += a[i];
            }
            Console.WriteLine("Total=" + total);

            float average = (float)total / 10;
            Console.WriteLine("Average=" + average);

            int min = a[0];
            for (int j = 1; j < 10; j++)
            {
                if (a[j] < min)
                    min = a[j];
            }
            Console.WriteLine("Minimum marks=" + min);

            int max = a[0];
            for (int j = 1; j < 10; j++)
            {
                if (a[j] > max)
                    max = a[j];
            }
            Console.WriteLine("Maximum marks=" + max);

            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending order:");
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

            temp = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
