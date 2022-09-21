 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SOL_CollectionsAssignment
{
    internal class Question4_Bookstore
    {
        static void Main()
        {
            
            Hashtable hs = new Hashtable();
            {
                
                int i;
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("BookID");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("BookName");
                    String s = Console.ReadLine();
                    hs.Add(a, s);
                }
                foreach(DictionaryEntry o in hs)
                {
                    Console.WriteLine("id:{0} \nname: {1}-----", o.Key, o.Value);

                }
            }
            



    }
    }
}
