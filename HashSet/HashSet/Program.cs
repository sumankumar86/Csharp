using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj=new HashSet<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(1);//Cannot aloow duplicate value
            
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(obj.Count);
        }
    }
}
