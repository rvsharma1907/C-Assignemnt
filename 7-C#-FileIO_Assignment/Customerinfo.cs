
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Enter Customer Details\n2. Display Customer Detials");
            int choice = int.Parse(Console.ReadLine());

 
                if (choice == 1)
                {
                    FileStream f = new FileStream("E:\\b.txt", FileMode.OpenOrCreate);

                    Console.WriteLine("File opened");

                    //declared stream writer
                    StreamWriter s = new StreamWriter(f);

                    Console.WriteLine("Writing data to file");

                    s.WriteLine("Writing data into file using stream writer");



                    //closing stream writer
                    s.Close();
                    f.Close();

                    Console.WriteLine("File Stream closed");
                }
                else if (choice == 2)
                {
                    FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

                    Console.WriteLine("File opened");

                    //declared stream reader
                    StreamReader sr = new StreamReader(f);
                    Console.WriteLine("Reading data from the file");

                    string line = sr.ReadLine();

                    Console.WriteLine("The data from the file is : " + line);

                    //closing stream writer
                    sr.Close();
                    f.Close();

                    Console.WriteLine("File Stream closed");

                    Console.ReadLine();
                }
   
            
        }
    }
}
