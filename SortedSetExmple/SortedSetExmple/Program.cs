using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetExmple
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var obj=new SortedSet<string>();
            obj.Add("Suman");
            obj.Add("Apurba");
            obj.Add("Boski");
            obj.Add("Apurba");
            obj.Add("Priyanshu");
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(obj.Count);
        }
    }
}
