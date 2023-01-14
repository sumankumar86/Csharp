using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinmumNumberInArray
{
    internal class Program
    {
        class Result
        {
            public int show(int[] arr)
            {
                int min=arr[0];
                for(int i = 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                   
                }
                return min;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i= 0; i < size; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Result obj = new Result();
            int minimum=obj.show(arr);
            Console.WriteLine("The min value of array is {0}",minimum);
            
            
        }
    }
}
