using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAndObjects
{
     class Bank
    {
        public string name;
        public long accountno;
        public string typeaccount;
        public double balance;
        
        public void Show()
        {
            Console.WriteLine($"NAME:{name} \n" + $" ACC.No:{accountno} \n" + $" Acc Type:{typeaccount}\n " + $" Balance:{balance}");
        }

        public void deposit(double amt)
        {
            Console.WriteLine(amt + balance);
        }
        public void withdraw(double sum)
        {
            if(sum<balance)
            {
                balance = balance - sum;
                Console.WriteLine("balance left after withdrawl: ",balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public static void Main()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter Name");
            bank.name=Console.ReadLine();
            Console.WriteLine("Enter Account No");
            bank.accountno = long.Parse(Console.ReadLine());
            Console.WriteLine("Type of Accopunt");
            bank.typeaccount = Console.ReadLine();
            Console.WriteLine("Enter Balance");
            bank.balance = double.Parse(Console.ReadLine());


            
            bank.Show();
            Console.WriteLine("Enter what to do 1-deposit \n 2-withdraw");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Enter amount to deposit");

                double amount = double.Parse(Console.ReadLine());
                bank.deposit(amount);
            }
            else
            {
                Console.WriteLine("Enter amount to withdraw");

                double ammt = double.Parse(Console.ReadLine());
                bank.withdraw(ammt);
            }

            
        }

        






     }
}


