using System;
using System.IO;


namespace StreamWriterex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream obj = new FileStream("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\streamwriter.txt", FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(obj);
           
            
            sw.Write(Console.ReadLine());
            sw.Close();
            obj.Close();
           
         

        }
    }
}
