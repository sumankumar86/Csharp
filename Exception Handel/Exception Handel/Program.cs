using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "a", "b", "c", "d", "e" };
            try
            {
                Console.WriteLine(list[5]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(list.Count);
            Console.WriteLine(list[4]);
        }
    }
}
