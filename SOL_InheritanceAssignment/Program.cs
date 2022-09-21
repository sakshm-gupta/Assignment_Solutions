using System.Drawing;
using System.Security.Cryptography;

namespace SOL_InheritanceAssignment
{
     
    
     class Furniture
    {
         public int orderID;
         public int quantity;
         public int amount;
         public string orderDate;
         public int furnitureType;
         public string paymentMode;

       

        public void GetData()
        {
            Console.WriteLine("Enter order id");
            orderID= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter order date dd-mmm-yyyy");
            orderDate = Console.ReadLine();
            Console.WriteLine("Enter payment mode(credit/debit)");
            paymentMode = Console.ReadLine();
            Console.WriteLine("Enter 1 for chair and 2 for Cot");
            furnitureType = int.Parse(Console.ReadLine());
            if(furnitureType==1)
            {
                chair c1 = new chair();
                c1.GetData();
                ShowData();
                c1.ShowData();

            }
            if(furnitureType==2)    
            {
                cot cot1 = new cot();
                cot1.GetData();
                ShowData();
                cot1.ShowData();
            }

            

        }
        public void ShowData()
        {
            Console.WriteLine($"OrderID = {orderID}\nQuantity = {quantity} \nAmount ={amount} \nOrder Date = {orderDate} \nPayment Mode = {paymentMode}\n-------");
        }
    }
        
    class chair: Furniture
    {
        public int chairType;
        public string chairTyp;
        public string purpose = null;
        public int woodTyp;
        public string woodtype;
        public int steelTyp;
        public string steelType = null;
        public int plasticcol;
        public string plasticColor = null;
        public int rate;
        public void GetData()
        {

            //base.GetData();
            Console.WriteLine("Enter purpose");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter chairType\n1-wood\n2-steel\n3-plastic\n---------");
            chairType = int.Parse(Console.ReadLine());
            if(chairType==1)
            {
                chairTyp = "Wood";
                Console.WriteLine("Wood type\n 1-Teak Wood\n2-Rose Wood\n----------");
                woodTyp = int.Parse(Console.ReadLine());
                if(woodTyp==1)
                {
                    woodtype = "Teak Wood";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if(woodTyp==2)
                {
                    woodtype = "Rose Wood";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                
            }
            else if(chairType==2)
            {
                chairTyp = "Steel";
                Console.WriteLine("Enter Steel type\n 1-Gray Steel\n2-Green Steel\n3-Brown Steel----------");
                steelTyp = int.Parse(Console.ReadLine());
                if (steelTyp == 1)
                {
                    steelType = "Gray Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (steelTyp == 2)
                {
                    steelType = "Green Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if(steelTyp == 3)
                {
                    steelType = "Brown  Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
            }
            if(chairType==3)
            {
                chairTyp = "Plastic";
                Console.WriteLine("Enter plastic color type\n 1-Green\n2-Red\n3-Blue\n4-White----------");
                steelTyp = int.Parse(Console.ReadLine());
                if (plasticcol == 1)
                {
                    plasticColor = "Green";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (plasticcol == 2)
                {
                    plasticColor = "Red";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (plasticcol == 3)
                {
                    plasticColor = "Blue";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if(plasticcol == 4)
                {
                    plasticColor = "White";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
            }
            
            
            
        }


        new public void ShowData()
        {
            
            Console.WriteLine("Details of Chair:\nChair Type: " + chairTyp + "\nPurpose: " + purpose + "\nWood Type: " 
                + woodtype + "\nSteel Type: " + steelType + "\nPlastic Color: " + plasticColor + "\nRate of a chair: " + rate);
        }
    }



    //--------------------------------

    class cot : Furniture
    {
        public int cotType;
        public int capac;
        public string capacity;
        public int rate;
        public int woodTyp;
        public string woodtype;
        public int steelTyp;
        public string steelType = null;
        public string cotTyp;

        public void GetData()
        {
            Console.WriteLine("Enter Capacity \n 1-Single\n 2-Double");
            capac = int.Parse(Console.ReadLine());
            if(capac==1)
            {
                capacity = "single";
            }
            else
            {
                capacity = "Double";

            }
            Console.WriteLine("Enter Cot Type\n1-wood\n2-steel\n---------");
            cotType = int.Parse(Console.ReadLine());
            if (cotType == 1)
            {
                cotTyp = "Wood";
                Console.WriteLine("Wood type\n 1-Teak Wood\n2-Rose Wood\n----------");
                woodTyp = int.Parse(Console.ReadLine());
                if (woodTyp == 1)
                {
                    woodtype = "Teak Wood";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (woodTyp == 2)
                {
                    woodtype = "Rose Wood";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }

            }
            else if (cotType == 2)
            {
                cotTyp = "Steel";
                Console.WriteLine("Enter Steel type\n 1-Gray Steel\n2-Green Steel\n3-Brown Steel----------");
                steelTyp = int.Parse(Console.ReadLine());
                if (steelTyp == 1)
                {
                    steelType = "Gray Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (steelTyp == 2)
                {
                    steelType = "Green Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
                if (steelTyp == 3)
                {
                    steelType = "Brown  Steel";
                    Console.WriteLine("Enter rate");
                    rate = int.Parse(Console.ReadLine());
                }
            }
        }


        public void ShowData()
        {
            
                Console.WriteLine("Details of Cot:\nCot Type: " + cotTyp + "\nWood Type: " 
                    + woodtype + "\nSteel Type: " + steelType + "\nCapacity: " + capacity + "\nRate of a cot: " + rate);

            
        }
    }



    class Program
    {
        static void Main()
        {
            Furniture F1 = new Furniture();
            //chair C1 = new chair();
            F1.GetData();
            
            
            //F1.ShowData();
            //C1.GetData();
            //C1.ShowData();
            
            
            
        }
    }

}
