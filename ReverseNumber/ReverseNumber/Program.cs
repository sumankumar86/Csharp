using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            int sum = 0;
            int rem;
            int temp= number;
            /* while (number > 0)
             {
                 rem = number % 10;
                 sum = sum * 10 + rem;
                 number /= 10;

             }

             Console.WriteLine("Reverse number of {0} is {1}", number, sum);*/
            /*Console.WriteLine("Length is {0} ", number.ToString().Length);
            int size=number.ToString().Length;
            for (int i = 0; i < size; i++)
            {
                rem=number % 10;
                sum = sum * 10 + rem;
                number /= 10;
            }
            Console.WriteLine("Reverse number of {0} is {1}",temp, sum);*/
            /*
            do
            {
                rem = number % 10;
                sum = sum * 10 + rem;
                number = number / 10;
            }
            while (number > 0);
            Console.WriteLine("Reverse number of {1} is {1}", temp, sum);
            */

            string num = number.ToString();
            char[] arr = num.ToCharArray();
            string rnum = "";
            for(int i=arr.Length-1; i >=0; i--)
            {
               rnum = rnum+arr[i];
            }
            Console.WriteLine(rnum);
        }
    }
}
