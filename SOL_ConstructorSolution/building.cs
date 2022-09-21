using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Transactions;

namespace ConstructorSolution
{
    class building
    {
        string type;
        string capacity;
        char dimension;
        string dateofcompletion;

        public building(string a, string b, char c, string d)
        {
            this.type = a;
            this.capacity = b;
            this.dimension = c;
            this.dateofcompletion = d;
        }
        public void showdata()
        {

            Console.WriteLine("-----------------------------\n-----------------------------");
            Console.WriteLine($"Type of Flat:{type} \n Capacity of Flat:{capacity}\n Dimension:{dimension}\n Date of Completion:{dateofcompletion}");
        }

        
    }
    class Test2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Type Flat/Villa");

            string a = Console.ReadLine();
            if (a == "FLAT" || a=="Flat")
            {
                Console.WriteLine("Enter the Floor on which flat is avsailable");
                char q = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Capacity(2BHK/3BHK/4BHK)");
                string b = Console.ReadLine();
                Console.WriteLine("date of completion");

                string d = Console.ReadLine();
                building B1 = new building(a, b, q, d);
                B1.showdata();
            }
            
           
            
            else
            {
                Console.WriteLine("Enter the Land Dimension(20X30/60X40/30X40)");
                char q= char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Capacity(2BHK/3BHK/4BHK)");
                string b = Console.ReadLine();
                Console.WriteLine("date of completion");

                string d = Console.ReadLine();
                building B1 = new building(a, b, q, d);
                B1.showdata();
            }
            
            

            
            


        }


    }
}










    