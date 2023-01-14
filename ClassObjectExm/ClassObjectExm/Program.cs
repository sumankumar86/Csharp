using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectExm
{
    class Basic
    {
        int id;
        string name;
        public Basic(int id,String name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Name is {0}", name);
            Console.WriteLine("Id is {0}", id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic obj1 = new Basic(2, "Suman");
            Basic obj2 = new Basic(1, "Sunanda");
            obj1.display();
            obj2.display();
        }
    }
}
