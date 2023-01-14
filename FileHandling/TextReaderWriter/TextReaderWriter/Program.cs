using System;
using System.IO;


namespace TextReaderWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw=File.CreateText("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\Textwriteread.txt");
            tw.WriteLine("I am suman Kumar Ghosh");
            string word=Console.ReadLine();
            
            tw.WriteLine(word);
            
            tw.Close();
            TextReader tr = File.OpenText("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\Textwriteread.txt");
            Console.WriteLine(tr.ReadToEnd());
        }
    }
}
