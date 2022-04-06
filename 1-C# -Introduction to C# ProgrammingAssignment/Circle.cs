using System;

class circle
{

    static void circumference_area_circle(int radius)
    {
        float pi = 3.14F;

        float area;
        float circumference;

        area = pi * radius * radius;
        circumference = 2 * pi * radius;

        Console.WriteLine("Circumference : " + circumference);
        Console.WriteLine("Area : " + area);
    }
    static void Main()
    {
        int radius;


        Console.WriteLine("Enter the Radius : ");
        radius = Convert.ToInt32(Console.ReadLine());

        circumference_area_circle(radius);
        
    }
}