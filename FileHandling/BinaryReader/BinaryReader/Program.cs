using System;
using System.IO;


namespace BinaryReaderex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryReader obj = new BinaryReader(File.Open("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\BinaryWrite.dat",FileMode.Open));
           
            Console.WriteLine("String:{0}", obj.ReadString()); 
            Console.WriteLine("Double:{0}", obj.ReadDouble()); 
            Console.WriteLine("Integer:{0}", obj.Read()); 
            Console.WriteLine("Boolean:{0}", obj.ReadBoolean()); 
        }
    }
}
