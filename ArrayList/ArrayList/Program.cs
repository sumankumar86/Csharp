using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var araylistobj = new ArrayList();
            araylistobj.Add(10);
            araylistobj.Add("Suman");
            araylistobj.Add(true);
            araylistobj.Add('A');
            araylistobj.Add(10.5);
            araylistobj.Add(null) ;

            foreach(var item in araylistobj)
            {
                Console.WriteLine(item);
            }
            araylistobj.Reverse();
            foreach (var item in araylistobj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(araylistobj.Count);
            //araylistobj.Clear();
            //Console.WriteLine(araylistobj.Count);
            //araylistobj.Insert(0,"Suman");
            /*foreach (var item in araylistobj)
            {
                Console.WriteLine(item);
            }*/
            araylistobj.Remove(araylistobj[0]);
            araylistobj.RemoveAt(1);
            araylistobj.RemoveRange(0, 2);
            foreach (var item in araylistobj)
            {
                Console.WriteLine(item);
            }
            var obj = new ArrayList()
            {
                1,"Suman","Anik",true
            };
            foreach(var item in obj)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
