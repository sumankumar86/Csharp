using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        eligibile:
            {
                Console.WriteLine("Eligible for vote");

            }
            Console.WriteLine("Enter Age:");
            int age=int.Parse(Console.ReadLine());
            if (age > 18)
            {
                goto eligibile;
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
          
        }
    }
}
