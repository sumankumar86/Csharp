using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();
            string nword = "";
            for(int i=letter.Length-1; i>=0; i--)
            {
                nword=nword + letter[i];
            }
            Console.WriteLine(nword);
        }
    }
}
