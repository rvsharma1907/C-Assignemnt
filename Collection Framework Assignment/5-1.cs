using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Array\n");
            Console.WriteLine("Enter the number of elements : ");
            int size_int = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size_int];
            int[] arr2 = new int[size_int];
            for (int i = 0; i < size_int; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size_int; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("\nOriginal Int Array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Console.WriteLine("\nCopied Array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Array.Reverse(arr2);
            Console.WriteLine("\nReversed Array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Console.WriteLine("\nSorted Array : ");
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Console.WriteLine("\nCleared Array : ");
            Array.Clear(arr2, 1, 2);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Console.WriteLine("\nString Array\n");
            Console.WriteLine("Enter the number of elements : ");
            int size_str = Convert.ToInt32(Console.ReadLine());
            string[] arr3 = new string[size_str];
            string[] arr4 = new string[size_str];
            for (int i = 0; i < size_str; i++)
            {
                arr3[i] = Console.ReadLine();
            }
            for (int i = 0; i < size_str; i++)
            {
                arr4[i] = arr3[i];
            }
            Console.WriteLine("\nOriginal String Array : ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + "  ");
            }
            Console.WriteLine("\nCopied Array : ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr4[i] + "  ");
            }
            Array.Reverse(arr4);
            Console.WriteLine("\nReversed Array : ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr4[i] + "  ");
            }
            Console.WriteLine("\nSorted Array : ");
            Array.Sort(arr4);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr4[i] + "  ");
            }
            Console.WriteLine("\nCleared Array : ");
            Array.Clear(arr4, 1, 2);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr4[i] + "  ");
            }


            Console.ReadKey();



                
        }
    }
}
