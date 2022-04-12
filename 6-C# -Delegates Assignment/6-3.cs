using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Account
    {
        int account_number;
        string customer_name;
        int balance;

        public Account(int account_number, string customer_name, int balance)
        {
            this.account_number = account_number;
            this.customer_name = customer_name;
            this.balance = balance;
        }
        public void Withdraw(int withdraw_amount)
        {
            if (this.balance == 0)
            {
                Console.WriteLine("Zero Balance");
            }
            else if (this.balance < withdraw_amount)
            {
                Console.WriteLine("Under Balance");
            }
            else
            {
                this.balance = this.balance - withdraw_amount;
                Console.WriteLine("Remaining Balance : " + this.balance);
            }
        }


        public void deposit(int deposit_amount)
        {
            this.balance = this.balance + deposit_amount;
            Console.WriteLine("Remaining Balance : "+ this.balance);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account number : ");
            int account_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name : ");
            string customer_name = Console.ReadLine();
            Console.WriteLine("Enter current amount : ");
            int balance = int.Parse(Console.ReadLine());
            Account acc = new Account(account_number, customer_name, balance);

            while (true)
            {
                Console.WriteLine("1.ENTER DEPOSIT AMOUNT\n2. ENTER WITHDRAWL AMOUNT\n3.EXIT\n");
                Console.WriteLine("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter amount to be deposited : ");
                    int deposit_amount = int.Parse(Console.ReadLine());
                    acc.deposit(deposit_amount);
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Enter amount to be withdraw : ");
                    int withdraw_amount = int.Parse(Console.ReadLine());
                    acc.Withdraw(withdraw_amount);
                }
                else if(choice >= 3)
                {
                    break;
                }
            }

        }
    }
}
