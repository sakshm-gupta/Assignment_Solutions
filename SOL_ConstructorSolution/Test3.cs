using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSolution
{
    class shapes
    {
       
        public void Area(int len, int brt)
        {
            
            Console.WriteLine(len * brt);

        }
        public void Area(double len, double brt)
        {
            Console.WriteLine((len * brt)/2);
        }
        public void Area(double r)
        {
            Console.WriteLine(3.14*r*r);
        }
        public void Area(int r)
        {
            Console.WriteLine(r * r);
        }
    }



    internal class Test3
    {
        public static void Main()
        {
            shapes s = new shapes();
            s.Area(5);
            s.Area(5,5);
            s.Area(5.5,10.50);
            s.Area(5.5);

        }
    }
}
