using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19questions
{
    internal class Class9
    {
        static void Main()
        {
            int n1 = 0, n2 = 1, n3=n1+n2, i;
               
            for (i = 2; i < 40; ++i) 
            {
                if (n1+n2<40)
                {

                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
        }
    }
}
