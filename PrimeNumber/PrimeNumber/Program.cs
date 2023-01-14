using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a number:");
            int number=int.Parse(Console.ReadLine());
            int temp = 0;
            for(int i = 2; i < Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    temp = 1;
                    break;
                    
                }
                Console.WriteLine("In loop");
            }
            if(temp== 0)
            {
                Console.WriteLine("prime number");
            }
            else{
                Console.WriteLine("Not prime");
            }*/
            /*nth prime no*/

            Console.WriteLine("Enter StartingPoint:");
            int range1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EndingPoint:");
            int range2=int.Parse(Console.ReadLine());
            ArrayList obj=new ArrayList();
            int count = 0;
            for(int i=range1; i<=range2; i++)
            {
                int temp = 0;
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        temp = 1;
                        break;
                     
                    }
                }
                if(temp == 0)
                {
                
                    obj.Add(i);
                    count+=1;
                }
             
            }
            Console.WriteLine(count);
           
            
            foreach(int num in obj)
            {
                Console.WriteLine(num);
            }
            int nth = int.Parse(Console.ReadLine());
            if (nth <= obj.Count)
            {
                Console.WriteLine(obj[nth-1]);
            }
        }
    }
}
