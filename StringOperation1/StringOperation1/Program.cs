using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            String s2 = "Suman";
            //Concat
            Console.WriteLine(s1+s2);
            Console.WriteLine(string.Concat(s2,s1));
            char[] arr = s2.ToCharArray();
            //Reverse
            Array.Reverse(arr);
            string word=new string(arr);
            Console.WriteLine(word);
            //Clone
            string name = "suman";
            string title = "ghosh";
            Console.WriteLine(title);
            title = (string)name.Clone();
            Console.WriteLine(title);

            //Compare
            string a = "secon";
            string b = "secon";
            string c = "Hello";
            string d= "hello";
            Console.WriteLine(string.Compare(a,b));
            Console.WriteLine(string.Compare(c,d));
            //CompareOrdinal
            string a1 = "ABCE";
            string b1 = "ABCD";
            Console.WriteLine(string.CompareOrdinal(a1, b1));
            //CompareTo
            string c1 = "hello";
            string c2 = "hello";
            string c3 = "helloi";
            Console.WriteLine(c1.CompareTo(c2));//0
            Console.WriteLine(c1.CompareTo(c3));//1
            string namep = "Suman Kumar Ghosh";
            Console.WriteLine(namep.Contains(" Ku"));//true
            Console.WriteLine(namep.Contains(" Kun"));//false
            //Copy
            string s0 = "Suman";
            string s10=string.Copy(s0);
            Console.WriteLine(s10);

            //Remove
            string word1 = "Hello World";
            string word2 = word1.Remove(5,1);
            Console.WriteLine(word2);


            //Replace
            string abc = "Helld";
            Console.WriteLine(abc.Replace('d', 'o'));

            string myname = "suman kumar ghosh";
            string[] arr1 = myname.Split(' ');
            Array.Reverse(arr1);
            foreach (string s in arr1)
            {
                Console.Write(s);
                Console.Write(" ");
            }
            Console.WriteLine(Convert.ToInt32('z'));

            //StratsWith
            string xyz = "hello world";
            Console.WriteLine(xyz.StartsWith("hel"));

            //ToUpper
            string abcd= "suKjnjn";
            Console.WriteLine(abcd.ToUpper()); 
            //ToLower
            string abcdd= "sDEFRKjnjn";
            Console.WriteLine(abcdd.ToLower());

            //Trim
            /*
            string demo = " Hello C ";
            string d0 = demo.Trim();
            Console.WriteLine(d0);
            */
            //TrimEnd
            /*
            string demo = "Hello C#o";
            char[] arr4 = { '#','o' };
            string d0 = demo.TrimEnd(arr4);
            Console.WriteLine(d0);*/
            //Trimstart
            string demo = "Hello C#o";
            char[] arr4 = { 'H','o' };
            string d0 = demo.TrimStart(arr4);
            Console.WriteLine(d0);

        }
    }
}
