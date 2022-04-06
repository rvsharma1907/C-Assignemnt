using System;
class HelloWorld {
static int sum_of_array()
{
    int n;
    int sum = 0;
    Console.WriteLine("Enter the number of intgers : ");
    n = Convert.ToInt32(Console.ReadLine());
    
    int[] arr = new int[n];
    
    for(int i = 0; i<n ; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    for (int i = 0 ; i < n ; i++)
    {
        sum = sum + arr[i];
        
    }
    
    return sum;
}


  static void Main() {
      
      Console.WriteLine("The sum of array element : " + sum_of_array());
    
  }
}
