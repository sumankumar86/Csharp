using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Example
    {
        public Example()
        {
            Console.WriteLine("Inside Constructor1");
        } 
        public Example(double a)
        { 
            Console.WriteLine("Inside Constructor2"+a);
        }  
        public Example(int number)
        {
            Console.WriteLine("Inside Constructor3"+number);
        }
       
        ~Example(){
            Console.WriteLine("Inside Destructor");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Example example1 = new Example(5/2);
            Example obj = new Example(10);

            
        }
    }
}
