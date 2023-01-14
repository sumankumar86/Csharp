using System;
using System.IO;

namespace Count_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
      
                int number = int.Parse(Console.ReadLine());

            
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine("The Number of digit is {0}", count);
        }
    }
}
