using System;
class HelloWorld {
  static void Main() {
    int[] avg_marks = new int[5];
    
    int i;int j;
    Console.WriteLine("Enter the Marks : ");
    for (i = 0; i < 5; i++)
    {
        avg_marks[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    int highest_marks = avg_marks[0];
    for (j = 0 ; j < 5 ; j++)
    {
        if (avg_marks[j] > highest_marks)
        {
            highest_marks = avg_marks[j];
        }
    }
    
    Console.WriteLine("Highest Marks : " + highest_marks);
}
}
