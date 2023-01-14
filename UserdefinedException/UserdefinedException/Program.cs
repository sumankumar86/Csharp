using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserdefinedException
{

    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter age:");
            int age=int.Parse(Console.ReadLine());
            try
            {
                if (age > 18)
                {
                    Console.WriteLine("You are valid");
                }
                else
                {
                    Thread.Sleep(1000);
                    throw new Exception("You are not valid");
                }
            }
         
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Thread.Sleep(3000);
            Console.WriteLine("Rest of the code");
         
        }
    }
}
