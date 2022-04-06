using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("1.ADDITION\n2.SUBTRACTION\n3.MULTIPLICATION\n4.DIVISION");

        bool Bool = true;

        while(Bool == true)
        {
            Console.WriteLine("Enter your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 4)
            {
                Console.WriteLine("Enter Number 1 : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2 : ");
                int number2 = Convert.ToInt32(Console.ReadLine());
    
                if(choice == 1)
                {
                    int sum = number1+number2;
                    Console.WriteLine("Addition : " + sum);
                }
                else if (choice == 2)
                {
                    int sub = number1 - number2;
                    Console.WriteLine("Subtraction : " + sub);
                }
                else if (choice == 3)
                {
                    int mul = number1 * number2;
                    Console.WriteLine("Multiplication : " + mul);
                }
                else if(choice == 4)
                {
                    float div = number1/ number2;
                    Console.WriteLine("Division : " + div);
                }
                else
                {
                    Console.WriteLine("Wrong choice entered");
                }
                Console.WriteLine("Do you want to enter again(y/n)");
                string ch = Console.ReadLine();
                if (ch == "n" || ch == "N")
                {
                    Bool = false;
                    break;
                }
                Bool = true;
            }
            else
            {
                Console.WriteLine("Wrong choice Entered");
                Console.WriteLine("Do you want to enter again(y/n)");
                string ch = Console.ReadLine();
                if (ch == "n" || ch == "N")
                {
                    Bool = false;
                    break;
                }
                Bool = true;
            }
            

            
        }
    }
}
