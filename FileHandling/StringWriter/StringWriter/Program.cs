using System;
using System.IO;
using System.Linq;
using System.Text;


namespace StringWriterex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder buobj=new StringBuilder();    
            StringWriter swr=new StringWriter(buobj);
            string text = "My name is Suman\n" + "This is my c# code";
            swr.WriteLine(text);
            swr.Close();

            StringReader sr=new StringReader(buobj.ToString());
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
           
            sr.Close();
        }
    }
}
