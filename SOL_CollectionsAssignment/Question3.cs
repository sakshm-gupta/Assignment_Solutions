using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace SOL_CollectionsAssignment
{
    internal class Question3

    {
        static void Main()
        {
            SortedList list = new SortedList();
            list.Add(4, "saksham");
            list.Add(2, "Sakshi");
            list.Add(1, "honey");
            list.Add(9, "singh");

            foreach (var i in list.Keys)
            {
                Console.WriteLine("emp code={0} emp name={1}", i, list[i]);
            }
            //or another way
            foreach (DictionaryEntry i in list)
            {
                Console.WriteLine("emp code={0} emp name={1}", i.Key, i.Value);
            }

        }
    }
}
