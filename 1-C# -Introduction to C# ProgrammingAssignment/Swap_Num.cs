using System;


class swap
{

    static void swap_num(ref int num1, ref int num2)
    {
        int temp_num;
        temp_num = num1;
        num1 = num2;
        num2 = temp_num;
    }
    static void Main()
    {
        int num1;
        int num2;

        Console.WriteLine("Enter number 1 : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2 : ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before Swap : num1 = {0} and num2 = {1}", num1, num2);

        swap_num(ref num1, ref num2);

        Console.WriteLine("After Swap : num1 = {0} and num2 = {1}", num1, num2);

    }
}