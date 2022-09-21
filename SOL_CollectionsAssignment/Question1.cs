using System.Collections;

namespace SOL_CollectionsAssignment
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Enter 10 numbers");
            for(int i = 0; i < 10; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();    
            foreach(var i in list)
            {
                Console.WriteLine(Convert.ToInt32(i));
            }
        }
    }
}