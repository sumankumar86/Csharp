using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
                int c = a/b;
                Console.WriteLine(c);

            }
            catch(Exception e)
            {
                int[] arr = { 10, 20, 3, 04, 50 };
                Console.WriteLine(e.Message);
                Console.WriteLine(arr[5]);
            }
            finally
            {
                Console.WriteLine("This is the last line of the program");
            }
        }
    }
}
