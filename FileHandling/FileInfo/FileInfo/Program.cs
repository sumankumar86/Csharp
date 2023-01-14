using System;
using System.IO;

namespace FileInfoex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Training\\C# Revision\\FileHandling\\File Read Write\\output.txt";
            FileInfo obj = new FileInfo(path);
       
            if (obj.Exists)
            {

                Console.WriteLine(obj.FullName);
                Console.WriteLine(obj.CreationTime);
            }
            obj.Create();
        }
    }
}
