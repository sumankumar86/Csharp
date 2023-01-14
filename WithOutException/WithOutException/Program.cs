using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOutException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"a","b","c","d","e"};
            Console.WriteLine(list[5]);//From these remaining program will be not executed
            //So need to handel exception

            Console.WriteLine(list[4]);
          
        }
    }
}
