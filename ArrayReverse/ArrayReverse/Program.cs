using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 10, 20 };
          

            Array.Reverse(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
